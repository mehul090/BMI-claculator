﻿using System;
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
 version:0.5-REMOVED progress bar for timer*/
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
            
            //progressBar1.Increment(1);

            //  progressBar1.Minimum = 0;
            //  progressBar1.Maximum = 200;
            //
            //  for (i = 0; i <= 200; i++)
            //  {
            //      progressBar1.Value = i;
            //  }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //progressBar1.Increment(100);
        }
    }
}
