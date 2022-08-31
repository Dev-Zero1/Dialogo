using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogo
{
    public partial class Home : BaseForm
    {
        //Used for datagridview binding and display
        private BindingSource DisplayList { get; set; }
        string name;

        public Home()
        {         
            name = "";
            InitializeComponent();
            Populate();            
        }

        private void randBT_Click(object sender, EventArgs e)
        {
            int r = 0;
            searchBox.Text = getRandomWord("English", r);
        }
        public override void Populate() 
        {
            Connection conn = new Connection();
            String NeverCmd = $"select count(totalAns) from translations.words where ( totalAns = 0 and seen = 0 )";
            String KnownCmd = $"select count(totalAns) from translations.words where ( totalAns > 0 or seen = 1 )";
            knownAmtLabel.Text = conn.GetQueryTextField(conn.Conn, KnownCmd); 
            neverSeenAmtLabel.Text = conn.GetQueryTextField(conn.Conn, NeverCmd);
            PlayerLabel.Text = "Hello " + conn.GetQueryTextField(conn.Conn, "select name from translations.user") + "!";

            switchToNormal();
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchWord = "";
            searchWord = searchBox.Text;
            
            string cmd = $"select English from translations.words where English LIKE '%{searchBox.Text}%'";
            Connection conn = new Connection();
            searchWord = conn.GetQueryTextField(conn.Conn, cmd);
            cmd = $"select id from translations.words where English = '{searchBox.Text}'";
            int wordID = 0;
            string query = "";

            try
            {
                wordID = conn.GetIntQuery(conn.Conn, cmd) > 0 ? conn.GetIntQuery(conn.Conn, cmd) : -1;
                if (wordID == -1) throw new IndexOutOfRangeException();

                // if it found a specific word with an id > 0, use that word exactly
                query = $"select id, English, Portuguese from translations.words where English = '{searchBox.Text}'"
                 + $" ORDER BY IF(words.id = {wordID}, 0, 1), words.id";
            }
            catch (IndexOutOfRangeException) {
                // if never found a specific word with an id > 0, use any similar word list in the display!
                query = $"select id, English, Portuguese from translations.words where English LIKE '%{searchBox.Text}%'"
                     + $" ORDER BY IF(words.id = {wordID}, 0, 1), words.id";
            }
                      
            LoadInfo(query, DisplayList, wordDGV);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            BaseForm.GotoScreen((int)BaseForm.FORMS.report, this);
        }
        private void start_Click(object sender, EventArgs e)
        {
            BaseForm.GotoScreen((int)BaseForm.FORMS.set, this);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            String query = "Select id, English,Portuguese FROM translations.words";
            LoadInfo(query, DisplayList, wordDGV);
            SetupBaseDGV(wordDGV);
            SetDGVColumnWidth();
        }
        private void SetDGVColumnWidth() 
        {
            wordDGV.Columns[0].Width = 50;
            wordDGV.Columns[1].Width = 80;
            wordDGV.Columns[2].Width = 80;
        }

        private void playerIcon_Click(object sender, EventArgs e)
        {
            switchToEdit();
        }
        public static string SanitizeStr(string str)
        {
            return new String(str.Where(Char.IsLetterOrDigit).ToArray());
        }
        private bool ValidateStr(string str) 
        {
            str = SanitizeStr(str);
            if (str.Length >= 1 && !str.Equals(""))
            {
                name = str;
                return true;
            }
            else 
            {
                ShowMsgBox("ONLY letters or numbers - name MUST have at least 1 value. Using default name - 'Player'.");
                name = "Player";
            }

            return true;
        }
        private void submitChangeBT_Click(object sender, EventArgs e)
        {
            if (ValidateStr(playerName.Text)) 
            {
                PlayerLabel.Text = "Hello " + name + "!";
                switchToNormal();
                deleteCreateNew();

                //wipe name for next run.
                playerName.Text = "";
            }
           
        }

        private void switchToEdit() 
        {
            playerIcon.Hide();  //hide the playerIcon until the user finishes.
            playerIcon.Enabled = false;

            PlayerLabel.Hide(); //hide the label that says hello until a new name is given

            playerName.Enabled = true;//enable the text box
            playerName.Show();//show it

            submitChangeBT.Show();
            submitChangeBT.Enabled = true;
            editLabel.Hide();
        }
        private void switchToNormal() 
        {                    
            playerName.Enabled = false;
            playerName.Hide();

            playerIcon.Enabled = true;
            playerIcon.Show();

            submitChangeBT.Hide();
            submitChangeBT.Enabled = false;

            editLabel.Show();
            PlayerLabel.Show();           
        }
        private void deleteCreateNew() 
        {           
             updateUsername(name);
        }
        public void updateUsername(string n)
        {
            local.user = new User();
            local.user.name = n;
            Connection c = new Connection();

            string query = $"delete From translations.user where id = 1";
            c.SendQueryToDB(c.Conn, query);

            query = $"INSERT INTO translations.user VALUES(1,'{local.user.name}')";
            c.SendQueryToDB(c.Conn, query);
        }

    }
}
