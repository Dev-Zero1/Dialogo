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
    public partial class Reports : BaseForm
    {
        private BindingSource DisplayList { get; set; }

        public Reports()
        {
            InitializeComponent();
            Populate();          
        }
        public override void Populate()
        {
            //base.Populate();           
            initLabels();
            SetupBaseDGV(reportDGV);
            SetDGVColumnWidth();
            hideReset();
            reportSelection.SelectedIndex = 0;
        }
        private void SetDGVColumnWidth()
        {
            reportDGV.Columns[0].Width = 40;
            reportDGV.Columns[1].Width = 80;
            reportDGV.Columns[2].Width = 80;
            reportDGV.Columns[3].Width = 70;
            reportDGV.Columns[4].Width = 70;
        }
        private void initLabels()
        {
            reportSelection.Items.Add("Most frequently missed words");
            reportSelection.Items.Add("Well Known words");
            reportSelection.Items.Add("Never seen words list");
            reportSelection.SelectedIndex = 2;         
        }

        private void reportSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            time.Text = "Report pulled at: " + DateTime.Now.ToString();
            switch (reportSelection.SelectedIndex)
            {
                case 0: { title.Text = "Most frequently missed words"; } break;
                case 1: { title.Text = "Well Known words"; } break;
                case 2: { title.Text = "Never seen words list"; } break;
            }

            String query = "";
            switch (reportSelection.SelectedIndex) 
            {
                case 0: { query = "select id, English, Portuguese, correctAns, incorrectAns  from translations.words where ( incorrectAns > 0 and incorrectAns > correctAns ) order by incorrectAns desc";  } break;
                case 1: { query = "select id, English, Portuguese, correctAns, incorrectAns  from translations.words where ( correctAns > 0 and correctAns > incorrectAns ) order by correctAns desc";  } break;
                case 2: { query = "select id, English, Portuguese, correctAns, incorrectAns  from translations.words where ( totalAns = 0 and seen = 0 )";  } break;
            }
            
            LoadInfo(query, DisplayList, reportDGV);
            
            zeroNotification1.Text = reportSelection.SelectedIndex == 2 ? "It looks like you've seen everything!" : "It doesn't look like we have enough data yet!";
            zeroNotification2.Text = reportSelection.SelectedIndex == 2 ? "Would you like to reset everything to 0?" : "Please try a quiz or flashcard!";
            

            if (reportDGV.Rows.Count < 1) 
            { 
                reportDGV.Hide(); 
                zeroNotification1.Show(); 
                zeroNotification2.Show();
                seenAllBT.Hide();
                if (reportSelection.SelectedIndex == 2) 
                { showReset(); } 
                else 
                { hideReset(); }
            }
            else 
            { 
                hideReset();  
                reportDGV.Show(); 
                zeroNotification1.Hide(); 
                zeroNotification2.Hide();
                seenAllBT.Show();
            }
            
        }

        private void showReset() 
        {
           // resetBT.Show();
           // resetBT.Enabled = true ;
            
            resetLabel.Show();
            resetLabel.Enabled = true;
            seenAllBT.Hide();
        }
        private void hideReset()
        {
            resetBT.Hide();
            resetBT.Enabled = false;

            resetLabel.Hide();
            resetLabel.Enabled = false;
        }

        private void homeBT_Click(object sender, EventArgs e)
        {
            BaseForm.GotoScreen((int)BaseForm.FORMS.home, this);
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            resetALL();
        }
        private void resetALL() 
        {
            Connection c = new Connection();

            string cmd = "update translations.words set seen = 0 where seen = 1";
            c.SendQueryToDB(c.Conn, cmd);

            cmd = "update translations.words set totalAns = 0 where totalAns != 0";
            c.SendQueryToDB(c.Conn, cmd);

            cmd = "update translations.words set correctAns = 0 where correctAns != 0";
            c.SendQueryToDB(c.Conn, cmd);

            cmd = "update translations.words set incorrectAns = 0 where incorrectAns != 0";
            c.SendQueryToDB(c.Conn, cmd);

            resetLabel.Enabled = false;
            resetLabel.Hide();
            reportSelection.SelectedIndex = 1;
            reportSelection.SelectedIndex = 2;
        }
        private void resetLabel_Click(object sender, EventArgs e)
        {
            resetALL();
        }

        private void seenAllBT_Click(object sender, EventArgs e)
        {
            local.word = new Word();
            local.word.setAllKnown();
            reportSelection.SelectedIndex = 1;
            reportSelection.SelectedIndex = 2;
        }
    }
}
