using System;
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
 * Version: 0.1 - created user inteface for calculator
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
                ResultextBox.Text = Convert.ToString(result);
            }
            else if (MetricRadio.Checked)
            {
                result = weight / (height * height);
                ResultextBox.Text = Convert.ToString(result);
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
            if()
            {

            }
        }
    }
}

