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
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            AnimateLauncher();
        }
        private async void AnimateLauncher()
        {
            //move x little by little to match the progressbar
            for (int x = 0; x < progressBar1.Maximum; x++)
            {
                await Task.Delay(TimeSpan.FromSeconds(0.005));
                progressBar1.Value = x;
            }
            // a wait to let the human eye catch up visually
            await Task.Delay(TimeSpan.FromSeconds(1.0));

            BaseForm.GotoScreen((int)BaseForm.FORMS.home, this);
        }
    }
}
