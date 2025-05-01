namespace genetik_algoritma
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
            label1 = new Label();
            populasyon_size_textbox = new TextBox();
            button_coz = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            caprazlama_oranı_up_down = new NumericUpDown();
            mutasyon_oranı_up_down = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            jenerasyon_textbox = new TextBox();
            label5 = new Label();
            secicilik_up_down = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)caprazlama_oranı_up_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mutasyon_oranı_up_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secicilik_up_down).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Italic);
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(179, 23);
            label1.TabIndex = 0;
            label1.Text = "Popülasyon Boyutu:";
            // 
            // populasyon_size_textbox
            // 
            populasyon_size_textbox.Location = new Point(209, 25);
            populasyon_size_textbox.Name = "populasyon_size_textbox";
            populasyon_size_textbox.Size = new Size(146, 27);
            populasyon_size_textbox.TabIndex = 1;
            populasyon_size_textbox.Text = "100";
            populasyon_size_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // button_coz
            // 
            button_coz.Font = new Font("Segoe UI Black", 10F);
            button_coz.Location = new Point(128, 288);
            button_coz.Name = "button_coz";
            button_coz.Size = new Size(143, 61);
            button_coz.TabIndex = 2;
            button_coz.Text = "Çöz";
            button_coz.UseVisualStyleBackColor = true;
            button_coz.Click += button_coz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Italic);
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(170, 23);
            label2.TabIndex = 3;
            label2.Text = "Çaprazlama Oranı:";
            // 
            // caprazlama_oranı_up_down
            // 
            caprazlama_oranı_up_down.DecimalPlaces = 1;
            caprazlama_oranı_up_down.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            caprazlama_oranı_up_down.InterceptArrowKeys = false;
            caprazlama_oranı_up_down.Location = new Point(208, 81);
            caprazlama_oranı_up_down.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            caprazlama_oranı_up_down.Name = "caprazlama_oranı_up_down";
            caprazlama_oranı_up_down.Size = new Size(146, 27);
            caprazlama_oranı_up_down.TabIndex = 4;
            caprazlama_oranı_up_down.TextAlign = HorizontalAlignment.Center;
            caprazlama_oranı_up_down.Value = new decimal(new int[] { 7, 0, 0, 65536 });
            // 
            // mutasyon_oranı_up_down
            // 
            mutasyon_oranı_up_down.DecimalPlaces = 1;
            mutasyon_oranı_up_down.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            mutasyon_oranı_up_down.InterceptArrowKeys = false;
            mutasyon_oranı_up_down.Location = new Point(208, 126);
            mutasyon_oranı_up_down.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            mutasyon_oranı_up_down.Name = "mutasyon_oranı_up_down";
            mutasyon_oranı_up_down.Size = new Size(146, 27);
            mutasyon_oranı_up_down.TabIndex = 6;
            mutasyon_oranı_up_down.TextAlign = HorizontalAlignment.Center;
            mutasyon_oranı_up_down.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Italic);
            label3.Location = new Point(24, 130);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 5;
            label3.Text = "Mutasyon Oranı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Italic);
            label4.Location = new Point(24, 177);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 7;
            label4.Text = "Seçicilik:";
            // 
            // jenerasyon_textbox
            // 
            jenerasyon_textbox.Location = new Point(209, 217);
            jenerasyon_textbox.Name = "jenerasyon_textbox";
            jenerasyon_textbox.Size = new Size(146, 27);
            jenerasyon_textbox.TabIndex = 10;
            jenerasyon_textbox.Text = "10";
            jenerasyon_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Italic);
            label5.Location = new Point(24, 221);
            label5.Name = "label5";
            label5.Size = new Size(164, 23);
            label5.TabIndex = 9;
            label5.Text = "Jenerasyon Sayısı:";
            // 
            // secicilik_up_down
            // 
            secicilik_up_down.DecimalPlaces = 1;
            secicilik_up_down.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            secicilik_up_down.InterceptArrowKeys = false;
            secicilik_up_down.Location = new Point(209, 173);
            secicilik_up_down.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            secicilik_up_down.Name = "secicilik_up_down";
            secicilik_up_down.Size = new Size(146, 27);
            secicilik_up_down.TabIndex = 12;
            secicilik_up_down.TextAlign = HorizontalAlignment.Center;
            secicilik_up_down.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(382, 365);
            Controls.Add(secicilik_up_down);
            Controls.Add(jenerasyon_textbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(mutasyon_oranı_up_down);
            Controls.Add(label3);
            Controls.Add(caprazlama_oranı_up_down);
            Controls.Add(label2);
            Controls.Add(button_coz);
            Controls.Add(populasyon_size_textbox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            ShowIcon = false;
            Text = "Genetik Algoritma";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)caprazlama_oranı_up_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)mutasyon_oranı_up_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)secicilik_up_down).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox populasyon_size_textbox;
        private Button button_coz;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private NumericUpDown caprazlama_oranı_up_down;
        private NumericUpDown mutasyon_oranı_up_down;
        private Label label3;
        private Label label4;
        private TextBox jenerasyon_textbox;
        private Label label5;
        private NumericUpDown secicilik_up_down;
    }
}
