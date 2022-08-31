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
    public partial class Selections : BaseForm
    {
        public Selections()
        {
            InitializeComponent();
            this.Populate();
        }
        override public void Populate() 
        {
            wordFilter.Items.Add("Random");
            wordFilter.Items.Add("Never Seen");
            wordFilter.Items.Add("Missed Freq.");

            gameFilter.Items.Add("Quiz");
            gameFilter.Items.Add("Flashcards");
            wordFilter.SelectedIndex = 0;
            gameFilter.SelectedIndex = 0;
            amountFilter.Value = 10;
             
        }

        private void homeBT_Click(object sender, EventArgs e)
        {
            BaseForm.GotoScreen((int)BaseForm.FORMS.home, this);
        }
        private void saveSelections() 
        {
            local.filterIndex = wordFilter.SelectedIndex;

            switch (local.filterIndex) 
            {
                case 0: { local.wordFilter = "Rand";    } break; //random
                case 1: { local.wordFilter = "Never";   } break; //never seen
                case 2: { local.wordFilter = "Missed";  } break; //missed
                //case 0: { } break;            
            }
            local.amount =  ((int)amountFilter.Value);
            local.amountMAX =  ((int)amountFilter.Value);
        }

        private void goPIC_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("gameType = "+gameFilter.SelectedIndex.ToString());
           // Console.WriteLine("wordType = "+wordFilter.SelectedIndex.ToString());

            bool isValidGameType = false;
            bool isValidWordType = false;
            if (gameFilter.SelectedIndex == 0 || gameFilter.SelectedIndex == 1)
            {
                isValidGameType = true;
            }
            if (wordFilter.SelectedIndex == 0 || wordFilter.SelectedIndex == 1 || wordFilter.SelectedIndex == 2)
            {
                isValidWordType = true;
            }

            if (isValidGameType == false || isValidWordType == false) 
            { ShowMsgBox("The game or word type is not a valid selection.\nPlease update your selections to proceed."); }



            if (isValidGameType && isValidWordType)
            {
                saveSelections();
                if (gameFilter.SelectedIndex == 0) BaseForm.GotoScreen((int)BaseForm.FORMS.quiz, this);
                if (gameFilter.SelectedIndex == 1) BaseForm.GotoScreen((int)BaseForm.FORMS.flash, this);
            }
        }

        private void goLabel_Click(object sender, EventArgs e)
        {
            saveSelections();
            if (gameFilter.SelectedIndex == 0)  BaseForm.GotoScreen((int)BaseForm.FORMS.quiz, this);  
            if (gameFilter.SelectedIndex == 1)  BaseForm.GotoScreen((int)BaseForm.FORMS.flash, this);  
        }

        private void amountFilter_ValueChanged(object sender, EventArgs e)
        {
            
               
        }

        private void gameFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (gameFilter.SelectedIndex == 0) { amountFilter.Show(); pictureBox2.Show(); }
           // if (gameFilter.SelectedIndex == 1) { amountFilter.Hide(); pictureBox2.Hide(); }
        }

        private void gameFilter_TextUpdate(object sender, EventArgs e)
        {

        }

        private void wordFilter_TextUpdate(object sender, EventArgs e)
        {

        }
    }
}
