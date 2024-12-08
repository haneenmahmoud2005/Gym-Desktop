//Payment 

namespace GymDesktop
{
    partial class Payment
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            Periode = new DateTimePicker();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            PaymentSDGV = new DataGridView();
            AmountTb = new MaskedTextBox();
            NameCb = new ComboBox();
            label7 = new Label();
            button1 = new Button();
            SearchName = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentSDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Peru;
            label3.Location = new Point(1294, 9);
            label3.Name = "label3";
            label3.Size = new Size(46, 50);
            label3.TabIndex = 8;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(525, 58);
            label1.Name = "label1";
            label1.Size = new Size(236, 60);
            label1.TabIndex = 7;
            label1.Text = "PAYMENTS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Peru;
            label2.Location = new Point(547, 9);
            label2.Name = "label2";
            label2.Size = new Size(191, 54);
            label2.TabIndex = 6;
            label2.Text = "BIG GYM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(180, 490);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 43;
            label5.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(180, 378);
            label4.Name = "label4";
            label4.Size = new Size(153, 28);
            label4.TabIndex = 42;
            label4.Text = "Member Name";
            // 
            // Periode
            // 
            Periode.CalendarMonthBackground = Color.PeachPuff;
            Periode.CalendarTitleBackColor = Color.Linen;
            Periode.Location = new Point(180, 306);
            Periode.Margin = new Padding(1);
            Periode.Name = "Periode";
            Periode.Size = new Size(295, 27);
            Periode.TabIndex = 46;
            Periode.Value = new DateTime(2024, 11, 30, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(180, 254);
            label6.Name = "label6";
            label6.Size = new Size(164, 28);
            label6.TabIndex = 47;
            label6.Text = "Payment Month";
            // 
            // button3
            // 
            button3.BackColor = Color.Peru;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(178, 612);
            button3.Name = "button3";
            button3.Size = new Size(155, 53);
            button3.TabIndex = 49;
            button3.Text = "Pay";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(341, 612);
            button2.Name = "button2";
            button2.Size = new Size(134, 53);
            button2.TabIndex = 48;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(276, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Peru;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(178, 681);
            button4.Name = "button4";
            button4.Size = new Size(297, 53);
            button4.TabIndex = 53;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // PaymentSDGV
            // 
            PaymentSDGV.BackgroundColor = SystemColors.HighlightText;
            PaymentSDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentSDGV.GridColor = SystemColors.ControlLight;
            PaymentSDGV.Location = new Point(667, 300);
            PaymentSDGV.Name = "PaymentSDGV";
            PaymentSDGV.RowHeadersWidth = 51;
            PaymentSDGV.Size = new Size(551, 434);
            PaymentSDGV.TabIndex = 54;
            PaymentSDGV.CellContentClick += PaymentSDGV_CellContentClick;
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.DimGray;
            AmountTb.BorderStyle = BorderStyle.None;
            AmountTb.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AmountTb.ForeColor = Color.DarkOrange;
            AmountTb.Location = new Point(180, 544);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(295, 24);
            AmountTb.TabIndex = 56;
            AmountTb.Tag = "";
            // 
            // NameCb
            // 
            NameCb.FormattingEnabled = true;
            NameCb.Items.AddRange(new object[] { "6Am-8Am", "8Am-10Am", "6Pm-8Pm", "8Pm-10PM" });
            NameCb.Location = new Point(180, 430);
            NameCb.Name = "NameCb";
            NameCb.Size = new Size(295, 28);
            NameCb.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Peru;
            label7.Location = new Point(830, 167);
            label7.Name = "label7";
            label7.Size = new Size(199, 50);
            label7.TabIndex = 58;
            label7.Text = "PAYMENTS";
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(948, 224);
            button1.Name = "button1";
            button1.Size = new Size(116, 53);
            button1.TabIndex = 60;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SearchName
            // 
            SearchName.BackColor = Color.DimGray;
            SearchName.BorderStyle = BorderStyle.None;
            SearchName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchName.ForeColor = Color.DarkOrange;
            SearchName.Location = new Point(690, 224);
            SearchName.Multiline = true;
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(252, 53);
            SearchName.TabIndex = 59;
            // 
            // button5
            // 
            button5.BackColor = Color.Peru;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(1070, 224);
            button5.Name = "button5";
            button5.Size = new Size(116, 53);
            button5.TabIndex = 61;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1352, 813);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(SearchName);
            Controls.Add(label7);
            Controls.Add(NameCb);
            Controls.Add(AmountTb);
            Controls.Add(PaymentSDGV);
            Controls.Add(button4);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(Periode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentSDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private DateTimePicker Periode;
        private Label label6;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button4;
        private DataGridView PaymentSDGV;
        private MaskedTextBox AmountTb;
        private ComboBox NameCb;
        private Label label7;
        private Button button1;
        private TextBox SearchName;
        private Button button5;
    }
}