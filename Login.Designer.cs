namespace GymDesktop
{
    partial class Login
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
            label2 = new Label();
            UidTb = new TextBox();
            pictureBox2 = new PictureBox();
            PassTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gym;
            pictureBox1.Location = new Point(162, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(537, 526);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Peru;
            label2.Location = new Point(1156, 240);
            label2.Name = "label2";
            label2.Size = new Size(288, 81);
            label2.TabIndex = 2;
            label2.Text = "BIG GYM";
            label2.Click += label2_Click;
            // 
            // UidTb
            // 
            UidTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UidTb.Location = new Point(1114, 411);
            UidTb.Name = "UidTb";
            UidTb.Size = new Size(339, 47);
            UidTb.TabIndex = 3;
            UidTb.TextChanged += textBox1_TextChanged_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(1449, 411);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // PassTb
            // 
            PassTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassTb.Location = new Point(1114, 495);
            PassTb.Name = "PassTb";
            PassTb.PasswordChar = '*';
            PassTb.Size = new Size(339, 47);
            PassTb.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1136, 584);
            button1.Name = "button1";
            button1.Size = new Size(155, 53);
            button1.TabIndex = 7;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1320, 584);
            button2.Name = "button2";
            button2.Size = new Size(143, 53);
            button2.TabIndex = 8;
            button2.Text = "Log in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pass;
            pictureBox3.Location = new Point(1449, 495);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1532, 865);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PassTb);
            Controls.Add(pictureBox2);
            Controls.Add(UidTb);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private TextBox UidTb;
        private PictureBox pictureBox2;
        private TextBox PassTb;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox3;
    }
}
