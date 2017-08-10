﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:mehul khosla-300932741
 * Date: August 04, 2017
 * Description: BMI-calculator
 * Version: 0.2 -added form closing event handler
 */
namespace BMI_claculator
{
    public partial class BmiCalculator : Form
    {
        public BmiCalculator()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MetricRadio_CheckedChanged(object sender, EventArgs e)
        {
            WunitLable.Text = "Kg";
            HunitLable.Text = "m";
        }

        private void HunitLable_Click(object sender, EventArgs e)
        {

        }

        private void ImperialRadio_CheckedChanged(object sender, EventArgs e)
        {
            WunitLable.Text = "lbs";
            HunitLable.Text = "inch";

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(HeightTextBox.Text);
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double result;


            if (ImperialRadio.Checked)
            {

                result = (weight * 703) / (height * height);
               string Result = Convert.ToString(result)+" - ";
                if(result<18.5)
                { ResultextBox.Text = Result+ " - "+" UNDERWEIGHT" ; }
                else if(result>18.5&& result<24.9)
                { ResultextBox.Text = Result +" - " + " NORMAL"; }
                else if (result > 25 && result <= 29.9)
                { ResultextBox.Text = Result + " - " + " OVERWEIGHT"; }
                else if ( result >= 30)
                { ResultextBox.Text = Result + " - " + " OBESE"; }
            }
            else if (MetricRadio.Checked)
            {
                result = weight / (height * height);
                string Result = Convert.ToString(result)+" - ";
                if (result < 18.5)
                { ResultextBox.Text = Result + " - " + " UNDERWEIGHT"; }
                else if (result > 18.5 && result < 24.9)
                { ResultextBox.Text = Result + " - " + " NORMAL"; }
                else if (result >= 25 && result <= 29.9)
                { ResultextBox.Text = Result + " - " + " OVERWEIGHT"; }
                else if (result >= 30)
                { ResultextBox.Text = Result + " - " + " OBESE"; }
            }
        }


        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            //double height = Convert.ToDouble(HeightTextBox.Text);
        }

        private void ResultextBox_TextChanged(object sender, EventArgs e)
        {
            //  result = Convert.ToDouble(ResultextBox.Text);
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            //double weight = Convert.ToDouble(WeightTextBox.Text);
        }

        private void RemarkTextBox_TextChanged(object sender, EventArgs e)
        {
                        
            
        }

        private void ClerAllButton_Click(object sender, EventArgs e)
        {
            //NameTextBox.Text = "";
            //AgeTextBox.Text = "";
            //HeightTextBox.Text = "";
            //WeightTextBox.Text = "";
            // ResultextBox.Text = "";
            // RemarkTextBox.Text = "";
            BmiCalculator NewForm = new BmiCalculator();
            NewForm.Show();
            this.Dispose(false);

        }
        /// <summary>
        /// this is an event for the form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BmiCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

