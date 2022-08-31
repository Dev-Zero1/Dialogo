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
    public partial class Quiz : BaseForm
    {
        public int correctWord;
        public Quiz()
        {
            InitializeComponent();
            Populate();
        }
        public override void Populate()
        {
            //base.Populate();
            correctWord = 1;
            index = 0;
            wordIDs = new int[local.amountMAX];
            seen = new byte[local.amountMAX];
            BuildFilteredWordIdList();
            updateLocalWordIdList();
            hideIcons();
            initLabels();
            showGameStart();
            randomizeAnswers();                  
        }
        private void initLabels()
        {
            local.correctAnswers  = 0;
            local.incorrectAnswers  = 0;
            correctLabel.Text = local.correctAnswers.ToString();
            amtLabel.Text = local.amount.ToString();
            directionControl.Items.Add("English -> Portuguese");
            directionControl.Items.Add("Portuguese -> English");
            directionControl.SelectedIndex = 0;
            directionControl.Visible = false;
            directionControl.Hide();
            GameOver.Hide();
        }
        private void hideIcons() 
        {
            goldStarIcon.Hide();
            blueStarIcon.Hide();
            silverStarIcon.Hide();
        }
        private void randomizeAnswers()
        {
            if (directionControl.SelectedIndex == 0) setRandomEng_PtBr(index);
           // if (directionControl.SelectedIndex == 1) setRandomPtBr_Eng();
            shuffle();
        }
        /*
        private void setRandomPtBr_Eng()
        {
            //set up the random words
            int r = 0;
            word1.Text = getRandomWord("English", r);
           // local.word.DisplayData();
            word.Text  = getWord(word1.Text, "English","Portuguese");

            word2.Text = getOtherWord(word1.Text, word3.Text, word4.Text, "English");
            word3.Text = getOtherWord(word2.Text,word1.Text, word4.Text, "English");
            word4.Text = getOtherWord(word3.Text, word1.Text,word2.Text, "English");
        }
        */
        private void setRandomEng_PtBr(int ind) 
        {         
            updateWordValues("Portuguese",wordIDs[ind]);

            word.Text = local.word.ENG;
            word1.Text = local.word.PTBR;

            //remove the duplicates by comparing the word to the other 3 listed.
            word2.Text = getOtherWord(word1.Text, word3.Text, word4.Text, "Portuguese");
            word3.Text = getOtherWord(word2.Text, word3.Text, word4.Text, "Portuguese");
            word4.Text = getOtherWord(word1.Text, word3.Text, word2.Text, "Portuguese");
        }

        private void updateWordValues(string lang) 
        {
            //set up the random words
            int r = getRandomInt(1,1001);
            local.word = getWordByID(r);                              
        }
        public override void updateWordValues(string lang, int r)
        {
            local.word = getWordByID(r);           
        }
        private void homeIcon_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            BaseForm.GotoScreen((int)BaseForm.FORMS.home, this);           
        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            bool correct = false;
            correct = checkCorrect();
            sendAnswerToDB(correct);            
            local.amount -= 1;
            amtLabel.Text = local.amount.ToString();

            if (correct)
            { 
                resultBox.Text += $"CORRECT\n";       
            } 
            else
            {                 
               resultBox.Text += $"* INCORRECT\n";
               engBox.Text += "* ";
               ptbrBox.Text += "* ";
            }

            engBox.Text += (local.word.ENG + "\n");
            ptbrBox.Text += (local.word.PTBR + "\n");

            if (local.amount >= 1)
            {
                index += 1;
                randomizeAnswers();
                //shuffle();      
            }
            else 
            {
                showGameOver();
                showStars();
            } 
           
        }
        private void showStars() 
        {
            //Console.WriteLine($"{local.correctAnswers} / {local.amountMAX} = SCORE { ((double)local.correctAnswers / (double)local.amountMAX)}");
            if(local.correctAnswers == 0) { hideIcons(); }
            else if (local.correctAnswers == local.amountMAX) { showAllStars(); }
            else if ((double)local.correctAnswers / (double)local.amountMAX >= 0.5) { showTwoStars(); }
            else if ((double)local.correctAnswers / (double)local.amountMAX < 0.5) { showOneStar(); }         
        }
        private void showAllStars() 
        {
            goldStarIcon.Show();
            blueStarIcon.Show();
            silverStarIcon.Show();
        }
        private void showTwoStars()
        {
            goldStarIcon.Show();
            blueStarIcon.Show();
        }
        private void showOneStar()
        {
            goldStarIcon.Show();
        }
        private void showGameOver() 
        {
            submitBT.Enabled = false;

            label1.Hide();
            correctLabel.Hide();

            word.Hide();
            word1.Hide();
            word2.Hide();
            word3.Hide();
            word4.Hide();

            submitBT.Hide();
            word1BT.Hide();
            word2BT.Hide();
            word3BT.Hide();
            word4BT.Hide();
            resultBox.Show(); 
            engBox.Show(); 
            ptbrBox.Show(); 
           
            GameOver.Text = $"Game Over!\nScore : {local.correctAnswers} out of {(local.incorrectAnswers + local.correctAnswers)} correct!";
            GameOver.Show();
        }
        private void showGameStart() 
        {
            submitBT.Enabled = true;
            resultBox.Hide();
            engBox.Hide();
            ptbrBox.Hide();
            GameOver.Hide();

            label1.Show();
            correctLabel.Show();

            word.Show();
            word1.Show();
            word2.Show();
            word3.Show();
            word4.Show();
             
            submitBT.Show();
            word1BT.Show();
            word2BT.Show();
            word3BT.Show();
            word4BT.Show();
            
            GameOver.Text = $"Game Over!\nScore : {local.correctAnswers} out of {(local.incorrectAnswers + local.correctAnswers)} correct!";
            
        }
        private void sendAnswerToDB(bool correct) 
        {
            if (correct)
            {
                local.word.incrementCorrectAns();
                local.correctAnswers += 1;
                correctLabel.Text = local.correctAnswers.ToString();
            }
            else
            {
                local.word.incrementIncorrectAns();
                local.incorrectAnswers += 1;
            }
            local.word.updateTotalAns();
            local.word.updateIntColByID("seen", 1);
            local.data.updateSeenAmount();
            local.data.updateUnseenAmount();

            if (local.data.getCurrentIntColVal("seen") == 1000) { local.data.updateAllSeen(); }
        }

        private bool checkCorrect() 
        {
            bool correct = false;
            // did i select it and did it match the correct word?
            if      (word1BT.Checked == true && correctWord == 1)   { correct = true; }
            else if (word2BT.Checked == true && correctWord == 2)   { correct = true; }
            else if (word3BT.Checked == true && correctWord == 3)   { correct = true; }
            else if (word4BT.Checked == true && correctWord == 4)   { correct = true; }
            return correct;
        }

        public void shuffle() 
        {
            Random rand = new Random();
            int r = rand.Next(1, 5); //for an int 1 - 4
            
            switch (r) 
            {
                case 1: { shuffle1(); } break;
                case 2: { shuffle2(); } break;
                case 3: { shuffle3(); } break;
                case 4: { shuffle4(); } break;
            }
        }


        //store word1 because its the equivalent
        //save it, then change them around.
        public void shuffle1() 
        {
            //shuffle nothing,  let it lie!
            correctWord = 1;
        }
        public void shuffle2() 
        {
            string temp = word1.Text;

            word1.Text = word3.Text;
            word3.Text = word4.Text;
            word4.Text = word2.Text;

            word2.Text = temp;
            correctWord = 2;
        }
        public void shuffle3() 
        {

            string temp = word1.Text;

            word1.Text = word4.Text;
            word4.Text = word2.Text;
            word2.Text = word3.Text;

            word3.Text = temp;
            correctWord = 3;          
        }
        public void shuffle4() 
        {
            string temp = word1.Text;

            word1.Text = word2.Text;
            word2.Text = word3.Text;
            word3.Text = word4.Text;

            word4.Text = temp;
            correctWord = 4;
        }
        /*
        private void directionControl_SelectedValueChanged(object sender, EventArgs e)
        {
            convertLabels();
            //shuffle();
        }
        private void convertLabels() 
        {
            if (directionControl.SelectedIndex == 0) convertPtBr_Eng(); 
            if (directionControl.SelectedIndex == 1) convertEng_PtBr();          
        }
        private void convertEng_PtBr()
        {
            word.Text = getWord(word.Text,  "English"   ,"Portuguese");

            word1.Text = getWord(word1.Text,"Portuguese","English");
            word2.Text = getWord(word2.Text,"Portuguese","English");
            word3.Text = getWord(word3.Text,"Portuguese","English");
            word4.Text = getWord(word4.Text,"Portuguese","English");
        }
        private void convertPtBr_Eng() 
        {
            word.Text = getWord(word.Text, "Portuguese", "English");

            word1.Text = getWord(word1.Text, "English", "Portuguese");
            word2.Text = getWord(word2.Text, "English", "Portuguese");
            word3.Text = getWord(word3.Text, "English", "Portuguese");
            word4.Text = getWord(word4.Text, "English", "Portuguese");
        }
        */
    }
}
