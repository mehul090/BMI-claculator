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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialRadio
            // 
            this.ImperialRadio.AutoSize = true;
            this.ImperialRadio.Location = new System.Drawing.Point(3, 3);
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
            this.MetricRadio.Location = new System.Drawing.Point(142, 3);
            this.MetricRadio.Name = "MetricRadio";
            this.MetricRadio.Size = new System.Drawing.Size(106, 35);
            this.MetricRadio.TabIndex = 3;
            this.MetricRadio.TabStop = true;
            this.MetricRadio.Text = "Metric";
            this.MetricRadio.UseVisualStyleBackColor = true;
            this.MetricRadio.CheckedChanged += new System.EventHandler(this.MetricRadio_CheckedChanged);
            // 
            // HeightLable
            // 
            this.HeightLable.AutoSize = true;
            this.HeightLable.Location = new System.Drawing.Point(5, 2);
            this.HeightLable.Name = "HeightLable";
            this.HeightLable.Size = new System.Drawing.Size(140, 31);
            this.HeightLable.TabIndex = 4;
            this.HeightLable.Text = "MY Height";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(172, 5);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(59, 38);
            this.HeightTextBox.TabIndex = 5;
            // 
            // InchLable
            // 
            this.InchLable.AutoSize = true;
            this.InchLable.Location = new System.Drawing.Point(246, 167);
            this.InchLable.Name = "InchLable";
            this.InchLable.Size = new System.Drawing.Size(64, 31);
            this.InchLable.TabIndex = 6;
            this.InchLable.Text = "inch";
            // 
            // WightLable
            // 
            this.WightLable.AutoSize = true;
            this.WightLable.Location = new System.Drawing.Point(5, 53);
            this.WightLable.Name = "WightLable";
            this.WightLable.Size = new System.Drawing.Size(145, 31);
            this.WightLable.TabIndex = 7;
            this.WightLable.Text = "MY Weight";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(172, 56);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(59, 38);
            this.WeightTextBox.TabIndex = 5;
            // 
            // lbsLable
            // 
            this.lbsLable.AutoSize = true;
            this.lbsLable.Location = new System.Drawing.Point(247, 213);
            this.lbsLable.Name = "lbsLable";
            this.lbsLable.Size = new System.Drawing.Size(49, 31);
            this.lbsLable.TabIndex = 9;
            this.lbsLable.Text = "lbs";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(69, 261);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(162, 70);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate\r\nBMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ResultextBox
            // 
            this.ResultextBox.Enabled = false;
            this.ResultextBox.Location = new System.Drawing.Point(12, 333);
            this.ResultextBox.Multiline = true;
            this.ResultextBox.Name = "ResultextBox";
            this.ResultextBox.Size = new System.Drawing.Size(280, 54);
            this.ResultextBox.TabIndex = 11;
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(3, 0);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(94, 31);
            this.NameLable.TabIndex = 12;
            this.NameLable.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(143, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(134, 38);
            this.NameTextBox.TabIndex = 13;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(143, 53);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(94, 38);
            this.AgeTextBox.TabIndex = 14;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // AgeLable
            // 
            this.AgeLable.AutoSize = true;
            this.AgeLable.Location = new System.Drawing.Point(3, 50);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.NameLable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AgeLable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AgeTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 100);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel2.Controls.Add(this.ImperialRadio, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MetricRadio, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 45);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.0339F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.9661F));
            this.tableLayoutPanel3.Controls.Add(this.HeightLable, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.HeightTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.WeightTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.WightLable, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 156);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(236, 100);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // BmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ClerAllButton);
            this.Controls.Add(this.ResultextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.lbsLable);
            this.Controls.Add(this.InchLable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BmiCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BmiCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

