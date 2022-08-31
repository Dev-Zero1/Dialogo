using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dialogo.local;

namespace Dialogo
{
    public partial class BaseForm : Form
    {
        public enum FORMS { launch, home, set, quiz, flash, report, LAST };
        public int index;
        public int[] wordIDs;
        public byte[] seen;

        public BaseForm()
        {
            InitializeComponent();
            local.data = new Tried();
            local.searchWordIDs = new BindingList<int>();           
        }

        virtual public void Populate() { }
        virtual public void updateWordValues(string lang, int r) { local.word = getWordByID(r); }

        public static void GotoScreen(int screen, Form ThisScreen)
        {
            //as long as the enum int value isn't the Last one/max, transition. 
            if (screen < (int)FORMS.LAST)
            {
                Form NextScreen = AppScreen(screen);

                ThisScreen.Hide();
                NextScreen.Show();
                ThisScreen.Cursor = Cursors.Default;
            }
        }

        //Given an int value for the screen, use the tools.FORMS enum to transition to the corresponding screen
        public static Form AppScreen(int screen)
        {
            Form form = new Form();

            if (screen < (int)FORMS.LAST)
            {
                switch (screen)
                {
                    //creates a form out of the given int screen
                    case (int)FORMS.launch: form = new Launcher(); break;
                    case (int)FORMS.home: form = new Home(); break;
                    case (int)FORMS.set: form = new Selections(); break;
                    case (int)FORMS.quiz: form = new Quiz(); break;
                    case (int)FORMS.flash: form = new Flashcard(); break;
                    case (int)FORMS.report: form = new Reports(); break;
                }
            }
            //returns the given form to transition to
            return form;
        }
        public void SetupBaseDGV(DataGridView dgv)
        {
            //dgv.Font = new Font(dgv.Font, FontStyle.Bold);

            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            //dgv.AutoResizeColumns();
            //  dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.RowHeadersVisible = true;
            dgv.AllowUserToAddRows = false;
        }
        //-------------------------------------------------------------------//
        //Function to Load the date info to the database
        //-------------------------------------------------------------------//
        public void LoadInfo(string query, BindingSource list, DataGridView DGV)
        {
            Connection TempConnection = new Connection();

            try
            {
                TempConnection.DisplayDBtoDGV(TempConnection.Conn, query);
            }
            catch (ArgumentOutOfRangeException e)
            {
            }
            list = new BindingSource();
            list.DataSource = TempConnection.dt;
            DGV.AutoGenerateColumns = true;
            DGV.DataSource = list;
        }

        public Word getWordByID(int id) 
        {
            Word w = new Word();
            Connection c = new Connection();
            w.ID = id;
            w.ENG = c.GetQueryTextField(c.Conn, $"SELECT English FROM translations.words where id = {id}");
            w.PTBR = c.GetQueryTextField(c.Conn, $"SELECT Portuguese FROM translations.words where id = {id}");
            w.CorrectAns = c.GetIntQuery(c.Conn, $"SELECT correctAns FROM translations.words where id = {id}");
            w.IncorrectAns = c.GetIntQuery(c.Conn, $"SELECT incorrectAns FROM translations.words where id = {id}");
            w.TotalAns = w.CorrectAns + w.IncorrectAns;
            return w;
        }
        //grab any random english word from the database
        public string getRandomWord(string lang, int r) {
           
            r = getRandomInt(1,1001); //for an int 1 - 1000
           
            string searchWord = "";
            string cmd = $"select {lang} from translations.words where id = " + r.ToString();
            Connection conn = new Connection();
            searchWord = conn.GetQueryTextField(conn.Conn, cmd);

            return searchWord;
        }
        public void BuildFilteredWordIdList()
        {
            InitializeLocalWordList();
            AugmentLocalWordList();                     
        }
        public void InitializeLocalWordList()
        {
            string cmd = "";

            if (local.wordFilter.Equals("Rand"))
            {
                cmd = $"select id from translations.words ORDER BY RAND() LIMIT {1000} ;";
            }
            else if (local.wordFilter.Equals("Never"))
            {
                //only totalAns < 1 and seen = 0 indicate they have never been seen or attempted   
                cmd = $"select id from translations.words where ( totalAns = 0 and seen = 0 ) ORDER BY RAND() LIMIT {1000} ;";
            }
            else if (local.wordFilter.Equals("Missed"))
            {
                //incorrectAns/totalAns > .6 missed freq     
                cmd = $"select id from translations.words where (((CAST(incorrectAns AS Decimal(5,2))) / CAST(totalAns AS Decimal(5,2))) >= 0.60 and totalAns >= 5) ORDER BY RAND()  LIMIT {1000};";
            }

            Connection conn = new Connection();
            local.searchWordIDs = conn.GetIntListOfQuery(conn.Conn, cmd);
        }
        public void AugmentLocalWordList() 
        {
            string cmd = "";
            //if nothing came up, just use random words.
            if (local.searchWordIDs.Count < 1)
            {
                Connection conn = new Connection();
                cmd = $"select id from translations.words ORDER BY RAND();";
                local.searchWordIDs = conn.GetIntListOfQuery(conn.Conn, cmd);
            }//else, just supplement the missing words with randoms.
            else if (local.searchWordIDs.Count < amountMAX)
            {
                Random rand = new Random();
                int need = amountMAX - local.searchWordIDs.Count;

                for (int i = 0; i < need; i++)
                {
                    int r = rand.Next(1, 1001);
                    local.searchWordIDs.Add(r);
                }
            }          
        }
        
        public void updateLocalWordIdList()
        {
           //set the shortenedword list to the first x amount of random elements.
            for (int i = 0; i < local.amountMAX; i++)
            {             
                seen[i] = 0;
                wordIDs[i] = local.searchWordIDs.ElementAt(i);           
            }
        }
        public int getRandomInt(int start, int end) 
        {
            Random rand = new Random();           
            return rand.Next(start, end); 
        }
        //given a word, picks a different non-dupicate word string to send back
        public string getOtherWord(string word1, string word2, string word3, string lang)
        {
            bool alive = true;
            int r = 0;
            string word = getRandomWord(lang, r);

            while (alive)
            {
                if (word.Equals(word1) || word.Equals(word2) || word.Equals(word3))
                {
                    word = getRandomWord(lang, r);
                }
                if ((!word.Equals(word1) && !word.Equals(word2) && !word.Equals(word3)))
                {
                    alive = false;
                }
            }
            return word;
        }
     
        public string getWord(string word, string native, string getEquiv)

        {
           // Console.WriteLine(word);
            string cmd = $"select {native} from translations.words where id = {local.word.ID}";
            Connection conn = new Connection();
            string searchWord = conn.GetQueryTextField(conn.Conn, cmd);
            //Console.WriteLine(searchWord);
            return searchWord;
        }
        public int getWordID(string word, string lang) 
        {
            Connection c = new Connection();
            return c.GetIntQuery(c.Conn,$"select id from translations.words where {lang} = '{word}'");
        }

        //given a string, display it within a MessageBox component
        public void ShowMsgBox(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }

        //---------------------------------------------------------------------------//
        //A function to update the customer record with name, active, lastUpdate, and lastUpdateBy values
        //---------------------------------------------------------------------------//

    }
}
