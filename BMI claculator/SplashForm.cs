using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*name:mehul khosla
 student number-300932741
 date:august 10,2017
 description:this is the splash form class for BMI calculator
 version:0.4-created progress bar for timer*/
namespace BMI_claculator
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is the event handler for the "tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            BmiCalculator bmiCalculator = new BmiCalculator();
            bmiCalculator.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;//turn timer off
            this.LoadBar.Increment(1);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            this.SplashFormTimer.Start();
        }
    }
}
