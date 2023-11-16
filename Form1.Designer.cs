namespace onlyfun
{
    partial class Onlyfun
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
            playButton = new Button();
            LB2 = new ListBox();
            pictureBox1 = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Location = new Point(94, 382);
            playButton.Name = "playButton";
            playButton.Size = new Size(117, 56);
            playButton.TabIndex = 1;
            playButton.Text = "spel spelen";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += button4_Click;
            // 
            // LB2
            // 
            LB2.FormattingEnabled = true;
            LB2.ItemHeight = 20;
            LB2.Location = new Point(15, 3);
            LB2.Name = "LB2";
            LB2.Size = new Size(295, 364);
            LB2.TabIndex = 0;
            LB2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.of2;
            pictureBox1.Location = new Point(581, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 400);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(361, 142);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Trivia crack";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(361, 187);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(183, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dirty Never Have I Ever";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(361, 235);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(139, 24);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Ik heb nog nooit";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Onlyfun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 527);
            Controls.Add(playButton);
            Controls.Add(radioButton3);
            Controls.Add(LB2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Name = "Onlyfun";
            Text = "l";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ranButton;
        private ListBox LB2;
        private PictureBox pictureBox1;
        private Button playButton;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton Trivia;
    }
}