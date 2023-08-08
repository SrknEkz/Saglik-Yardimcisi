namespace Saglik_Yardimcisi
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
            components = new System.ComponentModel.Container();
            Lbl_Bugün = new Label();
            Lbl_durum = new Label();
            DTP = new DateTimePicker();
            Btn_Alarm_Ayarla = new Button();
            Btn_durdur = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Lbl_Bugün
            // 
            Lbl_Bugün.AutoSize = true;
            Lbl_Bugün.Location = new Point(66, 9);
            Lbl_Bugün.Name = "Lbl_Bugün";
            Lbl_Bugün.Size = new Size(0, 15);
            Lbl_Bugün.TabIndex = 0;
            // 
            // Lbl_durum
            // 
            Lbl_durum.AutoSize = true;
            Lbl_durum.Location = new Point(12, 147);
            Lbl_durum.Name = "Lbl_durum";
            Lbl_durum.Size = new Size(0, 15);
            Lbl_durum.TabIndex = 1;
            // 
            // DTP
            // 
            DTP.CustomFormat = "HH:mm:ss";
            DTP.Format = DateTimePickerFormat.Custom;
            DTP.Location = new Point(91, 70);
            DTP.MaxDate = new DateTime(2027, 2, 26, 0, 0, 0, 0);
            DTP.Name = "DTP";
            DTP.Size = new Size(118, 23);
            DTP.TabIndex = 2;
            DTP.Value = new DateTime(2023, 8, 5, 0, 0, 0, 0);
            // 
            // Btn_Alarm_Ayarla
            // 
            Btn_Alarm_Ayarla.Location = new Point(107, 99);
            Btn_Alarm_Ayarla.Name = "Btn_Alarm_Ayarla";
            Btn_Alarm_Ayarla.Size = new Size(84, 23);
            Btn_Alarm_Ayarla.TabIndex = 3;
            Btn_Alarm_Ayarla.Text = "Alarm ayarla";
            Btn_Alarm_Ayarla.UseVisualStyleBackColor = true;
            // 
            // Btn_durdur
            // 
            Btn_durdur.Location = new Point(107, 195);
            Btn_durdur.Name = "Btn_durdur";
            Btn_durdur.Size = new Size(84, 23);
            Btn_durdur.TabIndex = 5;
            Btn_durdur.Text = "Durdur";
            Btn_durdur.UseVisualStyleBackColor = true;
            Btn_durdur.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 270);
            Controls.Add(Btn_durdur);
            Controls.Add(Btn_Alarm_Ayarla);
            Controls.Add(DTP);
            Controls.Add(Lbl_durum);
            Controls.Add(Lbl_Bugün);
            Name = "Form1";
            Text = "Sağlık Yardımcısı";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Bugün;
        private Label Lbl_durum;
        private DateTimePicker DTP;
        private Button Btn_Alarm_Ayarla;
        private Button Btn_durdur;
        private System.Windows.Forms.Timer timer1;
    }
}