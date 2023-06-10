namespace tomono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnConvert = new Button();
            btnBrowseInput = new Button();
            btnBrowseOutput = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.Transparent;
            btnConvert.Image = (Image)resources.GetObject("btnConvert.Image");
            btnConvert.Location = new Point(632, 287);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(307, 143);
            btnConvert.TabIndex = 0;
            btnConvert.TabStop = false;
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnBrowseInput
            // 
            btnBrowseInput.BackColor = Color.Transparent;
            btnBrowseInput.Image = (Image)resources.GetObject("btnBrowseInput.Image");
            btnBrowseInput.Location = new Point(13, 287);
            btnBrowseInput.Margin = new Padding(4, 5, 4, 5);
            btnBrowseInput.Name = "btnBrowseInput";
            btnBrowseInput.Size = new Size(307, 143);
            btnBrowseInput.TabIndex = 3;
            btnBrowseInput.TabStop = false;
            btnBrowseInput.UseVisualStyleBackColor = false;
            btnBrowseInput.Click += btnBrowseInput_Click;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.BackColor = Color.Transparent;
            btnBrowseOutput.Image = (Image)resources.GetObject("btnBrowseOutput.Image");
            btnBrowseOutput.Location = new Point(323, 287);
            btnBrowseOutput.Margin = new Padding(4, 5, 4, 5);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(307, 143);
            btnBrowseOutput.TabIndex = 4;
            btnBrowseOutput.TabStop = false;
            btnBrowseOutput.UseVisualStyleBackColor = false;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(79, 84);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(805, 38);
            label1.TabIndex = 7;
            label1.Text = "Convert WAV files from Stereo to Mono in 3 steps for RVC users";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 131);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(410, 32);
            label2.TabIndex = 8;
            label2.Text = "Change the sample rate to 44,100 Hz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 195);
            label3.Name = "label3";
            label3.Size = new Size(217, 32);
            label3.TabIndex = 9;
            label3.Text = "Attenuate by -6 dB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(83, 163);
            label4.Name = "label4";
            label4.Size = new Size(343, 32);
            label4.TabIndex = 10;
            label4.Text = "Change the bit depth to 16-bit";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 478);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(355, 25);
            label5.TabIndex = 11;
            label5.Text = "This software was developed by - Eliel Hillel";
            label5.Click += label5_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(590, 508);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 25);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Donate";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 508);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(559, 25);
            label6.TabIndex = 13;
            label6.Text = "If this software is helpful to you and you'd like to invite me for coffee";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Assistant", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateBlue;
            label7.Location = new Point(70, 21);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(764, 63);
            label7.TabIndex = 14;
            label7.Text = "Take your Train a few steps forward...";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(951, 573);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBrowseOutput);
            Controls.Add(btnBrowseInput);
            Controls.Add(btnConvert);
            ForeColor = Color.FromArgb(13, 17, 23);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "RVC - Stereo To Mono Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private Button btnBrowseInput;
        private Button btnBrowseOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
        private Label label6;
        private Label label7;
    }
}