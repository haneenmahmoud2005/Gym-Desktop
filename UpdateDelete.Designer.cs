namespace GymDesktop
{
    partial class UpdateDelete
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            AmountTb = new MaskedTextBox();
            AgeTb = new MaskedTextBox();
            NameTb = new MaskedTextBox();
            PhoneTb = new MaskedTextBox();
            TimingCb = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            GenderCb = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label10 = new Label();
            MemberSDGV = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Peru;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(102, 728);
            button3.Name = "button3";
            button3.Size = new Size(109, 53);
            button3.TabIndex = 46;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(228, 728);
            button2.Name = "button2";
            button2.Size = new Size(101, 53);
            button2.TabIndex = 45;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(228, 805);
            button1.Name = "button1";
            button1.Size = new Size(101, 53);
            button1.TabIndex = 44;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.DimGray;
            AmountTb.BorderStyle = BorderStyle.None;
            AmountTb.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AmountTb.ForeColor = Color.DarkOrange;
            AmountTb.Location = new Point(105, 576);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(224, 24);
            AmountTb.TabIndex = 43;
            // 
            // AgeTb
            // 
            AgeTb.BackColor = Color.DimGray;
            AgeTb.BorderStyle = BorderStyle.None;
            AgeTb.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgeTb.ForeColor = Color.DarkOrange;
            AgeTb.Location = new Point(104, 480);
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(224, 24);
            AgeTb.TabIndex = 42;
            // 
            // NameTb
            // 
            NameTb.BackColor = Color.DimGray;
            NameTb.BorderStyle = BorderStyle.None;
            NameTb.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameTb.ForeColor = Color.DarkOrange;
            NameTb.Location = new Point(104, 201);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(224, 24);
            NameTb.TabIndex = 41;
            NameTb.Tag = "";
            // 
            // PhoneTb
            // 
            PhoneTb.BackColor = Color.DimGray;
            PhoneTb.BorderStyle = BorderStyle.None;
            PhoneTb.Font = new Font("Engravers MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PhoneTb.ForeColor = Color.DarkOrange;
            PhoneTb.Location = new Point(104, 293);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(224, 24);
            PhoneTb.TabIndex = 40;
            // 
            // TimingCb
            // 
            TimingCb.FormattingEnabled = true;
            TimingCb.Items.AddRange(new object[] { "6Am-8Am", "8Am-10Am", "6Pm-8Pm", "8Pm-10PM" });
            TimingCb.Location = new Point(104, 671);
            TimingCb.Name = "TimingCb";
            TimingCb.Size = new Size(224, 28);
            TimingCb.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkOrange;
            label9.Location = new Point(104, 629);
            label9.Name = "label9";
            label9.Size = new Size(78, 28);
            label9.TabIndex = 38;
            label9.Text = "Timing";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkOrange;
            label8.Location = new Point(105, 545);
            label8.Name = "label8";
            label8.Size = new Size(174, 28);
            label8.TabIndex = 37;
            label8.Text = "Monthly Amount";
            // 
            // GenderCb
            // 
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(105, 387);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(224, 28);
            GenderCb.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(105, 345);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 35;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(105, 449);
            label6.Name = "label6";
            label6.Size = new Size(49, 28);
            label6.TabIndex = 34;
            label6.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(104, 252);
            label5.Name = "label5";
            label5.Size = new Size(154, 28);
            label5.TabIndex = 33;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(104, 158);
            label4.Name = "label4";
            label4.Size = new Size(153, 28);
            label4.TabIndex = 32;
            label4.Text = "Member Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Peru;
            label3.Location = new Point(1309, 9);
            label3.Name = "label3";
            label3.Size = new Size(46, 50);
            label3.TabIndex = 31;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(500, 59);
            label1.Name = "label1";
            label1.Size = new Size(531, 54);
            label1.TabIndex = 30;
            label1.Text = "Update And Delete Member";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Peru;
            label2.Location = new Point(671, 5);
            label2.Name = "label2";
            label2.Size = new Size(191, 54);
            label2.TabIndex = 29;
            label2.Text = "BIG GYM";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label10.ForeColor = Color.Peru;
            label10.Location = new Point(680, 176);
            label10.Name = "label10";
            label10.Size = new Size(426, 35);
            label10.TabIndex = 48;
            label10.Text = "Click On The Member To Be Deleted";
            // 
            // MemberSDGV
            // 
            MemberSDGV.BackgroundColor = SystemColors.HighlightText;
            MemberSDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberSDGV.GridColor = SystemColors.ControlLight;
            MemberSDGV.Location = new Point(412, 229);
            MemberSDGV.Name = "MemberSDGV";
            MemberSDGV.RowHeadersWidth = 51;
            MemberSDGV.Size = new Size(929, 629);
            MemberSDGV.TabIndex = 49;
            MemberSDGV.CellContentClick += MemberSDGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Peru;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(102, 805);
            button4.Name = "button4";
            button4.Size = new Size(109, 53);
            button4.TabIndex = 50;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1367, 904);
            Controls.Add(button4);
            Controls.Add(MemberSDGV);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AmountTb);
            Controls.Add(AgeTb);
            Controls.Add(NameTb);
            Controls.Add(PhoneTb);
            Controls.Add(TimingCb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(GenderCb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDelete";
            Load += UpdateDelete_Load;
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private MaskedTextBox AmountTb;
        private MaskedTextBox AgeTb;
        private MaskedTextBox NameTb;
        private MaskedTextBox PhoneTb;
        private ComboBox TimingCb;
        private Label label9;
        private Label label8;
        private ComboBox GenderCb;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label10;
        private DataGridView MemberSDGV;
        private Button button4;
    }
}