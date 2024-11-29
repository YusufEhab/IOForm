namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._26e2781d32e619a2acd6dee2b43baafa;
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(966, 640);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(638, 542);
            button3.Name = "button3";
            button3.Size = new Size(154, 41);
            button3.TabIndex = 34;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(382, 542);
            button2.Name = "button2";
            button2.Size = new Size(154, 41);
            button2.TabIndex = 33;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(71, 542);
            button1.Name = "button1";
            button1.Size = new Size(154, 41);
            button1.TabIndex = 32;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Process Analysis", "Performance Optimization", "User Experience", "Maintenance Services" });
            comboBox1.Location = new Point(382, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(410, 28);
            comboBox1.TabIndex = 31;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(382, 476);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(410, 27);
            textBox5.TabIndex = 30;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(382, 422);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(410, 27);
            textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(382, 295);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(410, 27);
            textBox3.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(382, 238);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(410, 27);
            textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(382, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(410, 27);
            textBox1.TabIndex = 26;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.BackColor = SystemColors.ControlDark;
            checkBox7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox7.Location = new Point(71, 478);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(180, 27);
            checkBox7.TabIndex = 25;
            checkBox7.Text = "FeaturesNotTested";
            checkBox7.UseVisualStyleBackColor = false;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged_1;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = SystemColors.ControlDark;
            checkBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox6.Location = new Point(71, 424);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(138, 27);
            checkBox6.TabIndex = 24;
            checkBox6.Text = "CurrentIssues";
            checkBox6.UseVisualStyleBackColor = false;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged_1;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = SystemColors.ControlDark;
            checkBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox5.Location = new Point(71, 355);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(224, 27);
            checkBox5.TabIndex = 23;
            checkBox5.Text = "ExistingAllMaintainance";
            checkBox5.UseVisualStyleBackColor = false;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = SystemColors.ControlDark;
            checkBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(71, 295);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(295, 27);
            checkBox4.TabIndex = 22;
            checkBox4.Text = "ExistingApplicationEnhancement";
            checkBox4.UseVisualStyleBackColor = false;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged_1;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = SystemColors.ControlDark;
            checkBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(71, 238);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 27);
            checkBox3.TabIndex = 21;
            checkBox3.Text = "TopPriority";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged_1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = SystemColors.ControlDark;
            checkBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(71, 179);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(154, 27);
            checkBox2.TabIndex = 20;
            checkBox2.Text = "ProcessAnalysis";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ControlDark;
            checkBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(71, 127);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 27);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "ChooseServices";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(382, 51);
            label1.Name = "label1";
            label1.Size = new Size(274, 41);
            label1.TabIndex = 18;
            label1.Text = "MobileAppDesign";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 643);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label1;
    }
}
