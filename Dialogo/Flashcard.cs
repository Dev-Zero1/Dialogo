using System;
using System.Collections;
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
    public partial class Flashcard : BaseForm
    {
        public enum LANG { ENG, PTBR, LAST };
        int lang;
       // int index;
      //  int [] wordIDs;
       // byte [] seen;
        public Flashcard()
        {
            InitializeComponent();
            Populate();
        }

        public override void Populate()
        {
            // base.Populate();
            lang = (int)LANG.ENG;
            index = 0;
            wordIDs = new int[local.amountMAX];
            seen = new byte[local.amountMAX];

            BuildFilteredWordIdList();
            updateLocalWordIdList();

            //set data back to the first word.
            updateWordValues("English", wordIDs[0]);
            hideIcons();
                       
            //initialize with the first random word ID in the array.
            //wordIDs[index] = local.word.ID;
            remainingLabel.Text = $"Flashcard Number: 1";
        }

        /*
        private void updateWordValues(string lang)
        {
            //set up the random words
            int r = getRandomInt(1, 1001);
            local.word = getWordByID(r);

            wordLabel.Text = lang == "English" ? local.word.ENG : local.word.PTBR;
        }*/
        public override void updateWordValues(string lang, int r)
        {
            local.word = getWordByID(r);
            wordLabel.Text = lang == "English" ? local.word.ENG : local.word.PTBR;
        }
        private void homeIcon_Click(object sender, EventArgs e)
        {
            BaseForm.GotoScreen((int)BaseForm.FORMS.home, this);
        }
        private void hideIcons()
        {
            label1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            convertWord();

        }

        private void wordLabel_Click(object sender, EventArgs e)
        {
            convertWord();           
        }
        private void convertWord()
        {
            if (this.lang == (int)LANG.ENG) { this.lang = (int)LANG.PTBR; }
            else { this.lang = (int)LANG.ENG; }

            string word = "";
            word = this.lang == 0 ? local.word.ENG : local.word.PTBR;
            wordLabel.Text = word;
            local.word.updateIntColByID("seen", 1);
        }

        private void prevBT_Click(object sender, EventArgs e)
        {
            index -= 1;
            //gives the previous word!  
            try 
            { 
                updateWordValues("English", wordIDs[index]); 
            }
            //else it circles back tothe last word in the flashcard
            catch (IndexOutOfRangeException) 
            { 
                index = wordIDs.Length - 1; 
                updateWordValues("English", wordIDs[index]); 
            }
            seen[index] = 1;
            remainingLabel.Text = $"Flashcard Number: {index+1}";
            checkAllSeen();
        }
        private void checkAllSeen() 
        {
            byte allSeen = 1;
            for (int i = 0; i < local.amountMAX; i++)
            {
                if (seen[i].Equals(0)) { allSeen = 0; }
            }

            if (allSeen == 1) local.amount = 0;

            if (local.amount <= 1)
            {
                label1.Text = $"Get a new set of {local.amountMAX} words!";
                label1.Show();
            }
        }
        private void nextBT_Click(object sender, EventArgs e)
        {         
            nextFlashcard();
        }    
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            local.amount = local.amountMAX;
            Populate();
        }
        private void nextFlashcard()
        {         
            
            //if this element ends up being the last element, go back to the start, else go to the next index.
            //index = index == wordIDs.Length - 1 ?  0 : index += 1;
            
            try { index += 1; updateWordValues("English", wordIDs[index]); }
            //else it circles back to the first word in the flashcard
            catch (IndexOutOfRangeException) { index = 0; updateWordValues("English", wordIDs[index]); }
            // wordLabel.Text = local.word.ENG;
            seen[index] = 1;
            //gives you a random next word!
            remainingLabel.Text = $"Flashcard Number: {index + 1}";
            if (local.data.getCurrentIntColVal("seen") == 1000) { local.data.updateAllSeen(); }
            checkAllSeen();
           
        }

    }
}
