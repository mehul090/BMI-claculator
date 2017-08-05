namespace BMI_claculator
{
    partial class BmiCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImperialRadio = new System.Windows.Forms.RadioButton();
            this.MetricRadio = new System.Windows.Forms.RadioButton();
            this.HeightLable = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.InchLable = new System.Windows.Forms.Label();
            this.WightLable = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.lbsLable = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultextBox = new System.Windows.Forms.TextBox();
            this.NameLable = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLable = new System.Windows.Forms.Label();
            this.ClerAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImperialRadio
            // 
            this.ImperialRadio.AutoSize = true;
            this.ImperialRadio.Location = new System.Drawing.Point(12, 109);
            this.ImperialRadio.Name = "ImperialRadio";
            this.ImperialRadio.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadio.TabIndex = 2;
            this.ImperialRadio.TabStop = true;
            this.ImperialRadio.Text = "Imperial";
            this.ImperialRadio.UseVisualStyleBackColor = true;
            // 
            // MetricRadio
            // 
            this.MetricRadio.AutoSize = true;
            this.MetricRadio.Location = new System.Drawing.Point(186, 109);
            this.MetricRadio.Name = "MetricRadio";
            this.MetricRadio.Size = new System.Drawing.Size(106, 35);
            this.MetricRadio.TabIndex = 3;
            this.MetricRadio.TabStop = true;
            this.MetricRadio.Text = "Metric";
            this.MetricRadio.UseVisualStyleBackColor = true;
            // 
            // HeightLable
            // 
            this.HeightLable.AutoSize = true;
            this.HeightLable.Location = new System.Drawing.Point(8, 147);
            this.HeightLable.Name = "HeightLable";
            this.HeightLable.Size = new System.Drawing.Size(140, 31);
            this.HeightLable.TabIndex = 4;
            this.HeightLable.Text = "MY Height";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(175, 144);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(60, 38);
            this.HeightTextBox.TabIndex = 5;
            // 
            // InchLable
            // 
            this.InchLable.AutoSize = true;
            this.InchLable.Location = new System.Drawing.Point(235, 152);
            this.InchLable.Name = "InchLable";
            this.InchLable.Size = new System.Drawing.Size(64, 31);
            this.InchLable.TabIndex = 6;
            this.InchLable.Text = "inch";
            // 
            // WightLable
            // 
            this.WightLable.AutoSize = true;
            this.WightLable.Location = new System.Drawing.Point(8, 189);
            this.WightLable.Name = "WightLable";
            this.WightLable.Size = new System.Drawing.Size(145, 31);
            this.WightLable.TabIndex = 7;
            this.WightLable.Text = "MY Weight";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(175, 186);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(60, 38);
            this.WeightTextBox.TabIndex = 5;
            // 
            // lbsLable
            // 
            this.lbsLable.AutoSize = true;
            this.lbsLable.Location = new System.Drawing.Point(235, 195);
            this.lbsLable.Name = "lbsLable";
            this.lbsLable.Size = new System.Drawing.Size(49, 31);
            this.lbsLable.TabIndex = 9;
            this.lbsLable.Text = "lbs";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(69, 248);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(162, 70);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate\r\nBMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ResultextBox
            // 
            this.ResultextBox.Enabled = false;
            this.ResultextBox.Location = new System.Drawing.Point(12, 325);
            this.ResultextBox.Multiline = true;
            this.ResultextBox.Name = "ResultextBox";
            this.ResultextBox.Size = new System.Drawing.Size(280, 54);
            this.ResultextBox.TabIndex = 11;
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(13, 13);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(94, 31);
            this.NameLable.TabIndex = 12;
            this.NameLable.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(113, 13);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(179, 38);
            this.NameTextBox.TabIndex = 13;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(175, 67);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(60, 38);
            this.AgeTextBox.TabIndex = 14;
            // 
            // AgeLable
            // 
            this.AgeLable.AutoSize = true;
            this.AgeLable.Location = new System.Drawing.Point(19, 69);
            this.AgeLable.Name = "AgeLable";
            this.AgeLable.Size = new System.Drawing.Size(67, 31);
            this.AgeLable.TabIndex = 15;
            this.AgeLable.Text = "age:";
            // 
            // ClerAllButton
            // 
            this.ClerAllButton.Location = new System.Drawing.Point(80, 394);
            this.ClerAllButton.Name = "ClerAllButton";
            this.ClerAllButton.Size = new System.Drawing.Size(144, 44);
            this.ClerAllButton.TabIndex = 16;
            this.ClerAllButton.Text = "clear all";
            this.ClerAllButton.UseVisualStyleBackColor = true;
            // 
            // BmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ClerAllButton);
            this.Controls.Add(this.AgeLable);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.ResultextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.lbsLable);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WightLable);
            this.Controls.Add(this.InchLable);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.HeightLable);
            this.Controls.Add(this.MetricRadio);
            this.Controls.Add(this.ImperialRadio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BmiCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BmiCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ImperialRadio;
        private System.Windows.Forms.RadioButton MetricRadio;
        private System.Windows.Forms.Label HeightLable;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label InchLable;
        private System.Windows.Forms.Label WightLable;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label lbsLable;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox ResultextBox;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLable;
        private System.Windows.Forms.Button ClerAllButton;
    }
}

