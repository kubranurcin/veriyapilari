namespace veriyapilarikub
{
    partial class Form1
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
            this.ara_btn = new System.Windows.Forms.Button();
            this.aranan_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.time_txt_lbl = new System.Windows.Forms.Label();
            this.soru_txt_lbl = new System.Windows.Forms.Label();
            this.txt_sonuc2_lbx = new System.Windows.Forms.ListBox();
            this.sonuc_txt_lbl = new System.Windows.Forms.Label();
            this.txt_sonuc_lbx = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.time_html_lbl = new System.Windows.Forms.Label();
            this.soru_html_lbl = new System.Windows.Forms.Label();
            this.html_sonuc2_lbx = new System.Windows.Forms.ListBox();
            this.sonuc_html_lbl = new System.Windows.Forms.Label();
            this.html_sonuc_lbx = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.time_word_lbl = new System.Windows.Forms.Label();
            this.soru_word_lbl = new System.Windows.Forms.Label();
            this.word_sonuc2_lbx = new System.Windows.Forms.ListBox();
            this.sonuc_word_lbl = new System.Windows.Forms.Label();
            this.word_sonuc_lbx = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.time_pdf_lbl = new System.Windows.Forms.Label();
            this.soru_pdf_lbl = new System.Windows.Forms.Label();
            this.pdf_sonuc2_lbx = new System.Windows.Forms.ListBox();
            this.sonuc_pdf_lbl = new System.Windows.Forms.Label();
            this.pdf_sonuc_lbx = new System.Windows.Forms.ListBox();
            this.metinleri_oku_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ara_btn
            // 
            this.ara_btn.Enabled = false;
            this.ara_btn.Location = new System.Drawing.Point(975, 16);
            this.ara_btn.Name = "ara_btn";
            this.ara_btn.Size = new System.Drawing.Size(311, 53);
            this.ara_btn.TabIndex = 0;
            this.ara_btn.Text = "Ara";
            this.ara_btn.UseVisualStyleBackColor = true;
            this.ara_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // aranan_txt
            // 
            this.aranan_txt.Location = new System.Drawing.Point(691, 26);
            this.aranan_txt.Name = "aranan_txt";
            this.aranan_txt.Size = new System.Drawing.Size(278, 22);
            this.aranan_txt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.time_txt_lbl);
            this.groupBox1.Controls.Add(this.soru_txt_lbl);
            this.groupBox1.Controls.Add(this.txt_sonuc2_lbx);
            this.groupBox1.Controls.Add(this.sonuc_txt_lbl);
            this.groupBox1.Controls.Add(this.txt_sonuc_lbx);
            this.groupBox1.Location = new System.Drawing.Point(18, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 449);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TXT";
            // 
            // time_txt_lbl
            // 
            this.time_txt_lbl.AutoSize = true;
            this.time_txt_lbl.Location = new System.Drawing.Point(6, 414);
            this.time_txt_lbl.Name = "time_txt_lbl";
            this.time_txt_lbl.Size = new System.Drawing.Size(0, 17);
            this.time_txt_lbl.TabIndex = 8;
            // 
            // soru_txt_lbl
            // 
            this.soru_txt_lbl.AutoSize = true;
            this.soru_txt_lbl.Location = new System.Drawing.Point(6, 244);
            this.soru_txt_lbl.Name = "soru_txt_lbl";
            this.soru_txt_lbl.Size = new System.Drawing.Size(183, 17);
            this.soru_txt_lbl.TabIndex = 5;
            this.soru_txt_lbl.Text = "Bunları mı demek istediniz ?";
            // 
            // txt_sonuc2_lbx
            // 
            this.txt_sonuc2_lbx.FormattingEnabled = true;
            this.txt_sonuc2_lbx.ItemHeight = 16;
            this.txt_sonuc2_lbx.Location = new System.Drawing.Point(6, 269);
            this.txt_sonuc2_lbx.Name = "txt_sonuc2_lbx";
            this.txt_sonuc2_lbx.Size = new System.Drawing.Size(299, 132);
            this.txt_sonuc2_lbx.TabIndex = 4;
            this.txt_sonuc2_lbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox5_MouseDoubleClick);
            // 
            // sonuc_txt_lbl
            // 
            this.sonuc_txt_lbl.AutoSize = true;
            this.sonuc_txt_lbl.Location = new System.Drawing.Point(6, 25);
            this.sonuc_txt_lbl.Name = "sonuc_txt_lbl";
            this.sonuc_txt_lbl.Size = new System.Drawing.Size(68, 17);
            this.sonuc_txt_lbl.TabIndex = 1;
            this.sonuc_txt_lbl.Text = "Sonuçlar:";
            // 
            // txt_sonuc_lbx
            // 
            this.txt_sonuc_lbx.FormattingEnabled = true;
            this.txt_sonuc_lbx.ItemHeight = 16;
            this.txt_sonuc_lbx.Location = new System.Drawing.Point(6, 45);
            this.txt_sonuc_lbx.Name = "txt_sonuc_lbx";
            this.txt_sonuc_lbx.Size = new System.Drawing.Size(299, 196);
            this.txt_sonuc_lbx.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.time_html_lbl);
            this.groupBox2.Controls.Add(this.soru_html_lbl);
            this.groupBox2.Controls.Add(this.html_sonuc2_lbx);
            this.groupBox2.Controls.Add(this.sonuc_html_lbl);
            this.groupBox2.Controls.Add(this.html_sonuc_lbx);
            this.groupBox2.Location = new System.Drawing.Point(335, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 448);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTML";
            // 
            // time_html_lbl
            // 
            this.time_html_lbl.AutoSize = true;
            this.time_html_lbl.Location = new System.Drawing.Point(6, 414);
            this.time_html_lbl.Name = "time_html_lbl";
            this.time_html_lbl.Size = new System.Drawing.Size(0, 17);
            this.time_html_lbl.TabIndex = 9;
            // 
            // soru_html_lbl
            // 
            this.soru_html_lbl.AutoSize = true;
            this.soru_html_lbl.Location = new System.Drawing.Point(6, 243);
            this.soru_html_lbl.Name = "soru_html_lbl";
            this.soru_html_lbl.Size = new System.Drawing.Size(183, 17);
            this.soru_html_lbl.TabIndex = 7;
            this.soru_html_lbl.Text = "Bunları mı demek istediniz ?";
            // 
            // html_sonuc2_lbx
            // 
            this.html_sonuc2_lbx.FormattingEnabled = true;
            this.html_sonuc2_lbx.ItemHeight = 16;
            this.html_sonuc2_lbx.Location = new System.Drawing.Point(9, 268);
            this.html_sonuc2_lbx.Name = "html_sonuc2_lbx";
            this.html_sonuc2_lbx.Size = new System.Drawing.Size(299, 132);
            this.html_sonuc2_lbx.TabIndex = 6;
            this.html_sonuc2_lbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox6_MouseDoubleClick);
            // 
            // sonuc_html_lbl
            // 
            this.sonuc_html_lbl.AutoSize = true;
            this.sonuc_html_lbl.Location = new System.Drawing.Point(6, 24);
            this.sonuc_html_lbl.Name = "sonuc_html_lbl";
            this.sonuc_html_lbl.Size = new System.Drawing.Size(68, 17);
            this.sonuc_html_lbl.TabIndex = 3;
            this.sonuc_html_lbl.Text = "Sonuçlar:";
            // 
            // html_sonuc_lbx
            // 
            this.html_sonuc_lbx.FormattingEnabled = true;
            this.html_sonuc_lbx.ItemHeight = 16;
            this.html_sonuc_lbx.Location = new System.Drawing.Point(6, 44);
            this.html_sonuc_lbx.Name = "html_sonuc_lbx";
            this.html_sonuc_lbx.Size = new System.Drawing.Size(299, 196);
            this.html_sonuc_lbx.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.time_word_lbl);
            this.groupBox3.Controls.Add(this.soru_word_lbl);
            this.groupBox3.Controls.Add(this.word_sonuc2_lbx);
            this.groupBox3.Controls.Add(this.sonuc_word_lbl);
            this.groupBox3.Controls.Add(this.word_sonuc_lbx);
            this.groupBox3.Location = new System.Drawing.Point(655, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 448);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Word";
            // 
            // time_word_lbl
            // 
            this.time_word_lbl.AutoSize = true;
            this.time_word_lbl.Location = new System.Drawing.Point(6, 414);
            this.time_word_lbl.Name = "time_word_lbl";
            this.time_word_lbl.Size = new System.Drawing.Size(0, 17);
            this.time_word_lbl.TabIndex = 10;
            // 
            // soru_word_lbl
            // 
            this.soru_word_lbl.AutoSize = true;
            this.soru_word_lbl.Location = new System.Drawing.Point(3, 243);
            this.soru_word_lbl.Name = "soru_word_lbl";
            this.soru_word_lbl.Size = new System.Drawing.Size(183, 17);
            this.soru_word_lbl.TabIndex = 7;
            this.soru_word_lbl.Text = "Bunları mı demek istediniz ?";
            // 
            // word_sonuc2_lbx
            // 
            this.word_sonuc2_lbx.FormattingEnabled = true;
            this.word_sonuc2_lbx.ItemHeight = 16;
            this.word_sonuc2_lbx.Location = new System.Drawing.Point(6, 268);
            this.word_sonuc2_lbx.Name = "word_sonuc2_lbx";
            this.word_sonuc2_lbx.Size = new System.Drawing.Size(299, 132);
            this.word_sonuc2_lbx.TabIndex = 6;
            this.word_sonuc2_lbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox7_MouseDoubleClick);
            // 
            // sonuc_word_lbl
            // 
            this.sonuc_word_lbl.AutoSize = true;
            this.sonuc_word_lbl.Location = new System.Drawing.Point(6, 24);
            this.sonuc_word_lbl.Name = "sonuc_word_lbl";
            this.sonuc_word_lbl.Size = new System.Drawing.Size(68, 17);
            this.sonuc_word_lbl.TabIndex = 3;
            this.sonuc_word_lbl.Text = "Sonuçlar:";
            // 
            // word_sonuc_lbx
            // 
            this.word_sonuc_lbx.FormattingEnabled = true;
            this.word_sonuc_lbx.ItemHeight = 16;
            this.word_sonuc_lbx.Location = new System.Drawing.Point(6, 44);
            this.word_sonuc_lbx.Name = "word_sonuc_lbx";
            this.word_sonuc_lbx.Size = new System.Drawing.Size(299, 196);
            this.word_sonuc_lbx.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.time_pdf_lbl);
            this.groupBox4.Controls.Add(this.soru_pdf_lbl);
            this.groupBox4.Controls.Add(this.pdf_sonuc2_lbx);
            this.groupBox4.Controls.Add(this.sonuc_pdf_lbl);
            this.groupBox4.Controls.Add(this.pdf_sonuc_lbx);
            this.groupBox4.Location = new System.Drawing.Point(975, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 449);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PDF";
            // 
            // time_pdf_lbl
            // 
            this.time_pdf_lbl.AutoSize = true;
            this.time_pdf_lbl.Location = new System.Drawing.Point(6, 415);
            this.time_pdf_lbl.Name = "time_pdf_lbl";
            this.time_pdf_lbl.Size = new System.Drawing.Size(0, 17);
            this.time_pdf_lbl.TabIndex = 8;
            // 
            // soru_pdf_lbl
            // 
            this.soru_pdf_lbl.AutoSize = true;
            this.soru_pdf_lbl.Location = new System.Drawing.Point(3, 244);
            this.soru_pdf_lbl.Name = "soru_pdf_lbl";
            this.soru_pdf_lbl.Size = new System.Drawing.Size(183, 17);
            this.soru_pdf_lbl.TabIndex = 7;
            this.soru_pdf_lbl.Text = "Bunları mı demek istediniz ?";
            // 
            // pdf_sonuc2_lbx
            // 
            this.pdf_sonuc2_lbx.FormattingEnabled = true;
            this.pdf_sonuc2_lbx.ItemHeight = 16;
            this.pdf_sonuc2_lbx.Location = new System.Drawing.Point(6, 269);
            this.pdf_sonuc2_lbx.Name = "pdf_sonuc2_lbx";
            this.pdf_sonuc2_lbx.Size = new System.Drawing.Size(299, 132);
            this.pdf_sonuc2_lbx.TabIndex = 6;
            this.pdf_sonuc2_lbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox8_MouseDoubleClick);
            // 
            // sonuc_pdf_lbl
            // 
            this.sonuc_pdf_lbl.AutoSize = true;
            this.sonuc_pdf_lbl.Location = new System.Drawing.Point(6, 25);
            this.sonuc_pdf_lbl.Name = "sonuc_pdf_lbl";
            this.sonuc_pdf_lbl.Size = new System.Drawing.Size(68, 17);
            this.sonuc_pdf_lbl.TabIndex = 3;
            this.sonuc_pdf_lbl.Text = "Sonuçlar:";
            // 
            // pdf_sonuc_lbx
            // 
            this.pdf_sonuc_lbx.FormattingEnabled = true;
            this.pdf_sonuc_lbx.ItemHeight = 16;
            this.pdf_sonuc_lbx.Location = new System.Drawing.Point(6, 45);
            this.pdf_sonuc_lbx.Name = "pdf_sonuc_lbx";
            this.pdf_sonuc_lbx.Size = new System.Drawing.Size(299, 196);
            this.pdf_sonuc_lbx.TabIndex = 2;
            // 
            // metinleri_oku_btn
            // 
            this.metinleri_oku_btn.Location = new System.Drawing.Point(24, 12);
            this.metinleri_oku_btn.Name = "metinleri_oku_btn";
            this.metinleri_oku_btn.Size = new System.Drawing.Size(240, 55);
            this.metinleri_oku_btn.TabIndex = 6;
            this.metinleri_oku_btn.Text = "Dosyaları uygulamaya yükle";
            this.metinleri_oku_btn.UseVisualStyleBackColor = true;
            this.metinleri_oku_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 534);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.metinleri_oku_btn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aranan_txt);
            this.Controls.Add(this.ara_btn);
            this.Name = "Form1";
            this.Text = "Arama Motoru";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ara_btn;
        private System.Windows.Forms.TextBox aranan_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label soru_txt_lbl;
        private System.Windows.Forms.ListBox txt_sonuc2_lbx;
        private System.Windows.Forms.Label sonuc_txt_lbl;
        private System.Windows.Forms.ListBox txt_sonuc_lbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label sonuc_html_lbl;
        private System.Windows.Forms.ListBox html_sonuc_lbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label sonuc_word_lbl;
        private System.Windows.Forms.ListBox word_sonuc_lbx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label sonuc_pdf_lbl;
        private System.Windows.Forms.ListBox pdf_sonuc_lbx;
        private System.Windows.Forms.Label soru_html_lbl;
        private System.Windows.Forms.ListBox html_sonuc2_lbx;
        private System.Windows.Forms.Label soru_word_lbl;
        private System.Windows.Forms.ListBox word_sonuc2_lbx;
        private System.Windows.Forms.Label soru_pdf_lbl;
        private System.Windows.Forms.ListBox pdf_sonuc2_lbx;
        private System.Windows.Forms.Button metinleri_oku_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label time_txt_lbl;
        private System.Windows.Forms.Label time_html_lbl;
        private System.Windows.Forms.Label time_word_lbl;
        private System.Windows.Forms.Label time_pdf_lbl;
    }
}

