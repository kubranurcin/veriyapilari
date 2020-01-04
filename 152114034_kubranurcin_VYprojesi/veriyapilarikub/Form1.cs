using System;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Diagnostics;

namespace veriyapilarikub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //dosyalardaki metini alcagimiz degiskenler
        public string txtdosya = "";
        public string htmldosya = "";
        public string worddosya = "";
        public string pdfdosya = "";

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch okumasure = new Stopwatch();
            okumasure.Start();

            txtdosya = "";
            htmldosya = "";
            worddosya = "";
            pdfdosya = "";

            //dosyalarin tamamini gerekli degiskene oku
            StreamReader txtread = File.OpenText("C:\\Users\\kubra\\Desktop\\152114034_kubranurcin_VYprojesi\\veriyapilarikub\\txtmetin.txt");

            string metin;

            while ((metin = txtread.ReadLine()) != null)
            {
                txtdosya += metin.ToLower();
            }

            txtread.Close();

            StreamReader htmlread = File.OpenText("C:\\Users\\kubra\\Desktop\\152114034_kubranurcin_VYprojesi\\veriyapilarikub\\htmlmetin.html");

            metin = "";

            while ((metin = htmlread.ReadLine()) != null)
            {
                htmldosya += metin.ToLower();
            }
            //word dosyasini oku ve hizli çalşirtirmasini saglayan kodlar 
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            object miss = System.Reflection.Missing.Value;
            object path = "C:\\Users\\kubra\\Desktop\\152114034_kubranurcin_VYprojesi\\veriyapilarikub\\wordmetin.docx";
            object readOnly = true;
            Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
            string totaltext = "";

            object unit = Microsoft.Office.Interop.Word.WdUnits.wdLine;
            object count = docs.Words.Count;
            word.Selection.MoveEnd(ref unit, ref count);
            totaltext = word.Selection.Text;

            docs.Close(ref miss, ref miss, ref miss);
            word.Quit(ref miss, ref miss, ref miss);
            docs = null;
            word = null;

            worddosya = totaltext.ToLower();

            //pdf oku 
            PdfReader reader = new PdfReader("C:\\Users\\kubra\\Desktop\\152114034_kubranurcin_VYprojesi\\veriyapilarikub\\pdfmetin.pdf");


            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                pdfdosya += PdfTextExtractor.GetTextFromPage(reader, page);
            }

            reader.Close();

            pdfdosya = pdfdosya.ToLower();

            ara_btn.Enabled = true;
            metinleri_oku_btn.Enabled = false;
            okumasure.Stop();
            label9.Text = "Dosyalar programa yüklendi. Toplam Süre = "+ okumasure.Elapsed.Seconds.ToString() + " sn " + okumasure.Elapsed.Milliseconds.ToString() + " ms";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListboxlariTemizle();

            //textten aldigim kelimeyi kucult
            string kelime = aranan_txt.Text.ToLower();

            //kelimeyi ara
            //dosyayi okuma suresini ayri ayri hesapla ve ekrana yazdır
            Stopwatch txtsure = new Stopwatch();
            txtsure.Start();
            Bruteforce(txtdosya, kelime, 1);  //arama
            txtsure.Stop();
            Stopwatch htmlsure = new Stopwatch();
            htmlsure.Start();
            Bruteforce(htmldosya, kelime, 2);//arama
            htmlsure.Stop();
            Stopwatch wordsure = new Stopwatch();
            wordsure.Start();
            Bruteforce(worddosya, kelime, 3);//arama
            wordsure.Stop();
            Stopwatch pdfsure = new Stopwatch();
            pdfsure.Start();
            Bruteforce(pdfdosya, kelime, 4);//arama
            pdfsure.Stop();

            time_txt_lbl.Text = txtsure.Elapsed.Seconds.ToString() + " saniye " + txtsure.Elapsed.Milliseconds.ToString() + "    ms ";
            time_html_lbl.Text = htmlsure.Elapsed.Seconds.ToString() + " saniye " + htmlsure.Elapsed.Milliseconds.ToString() + " ms ";
            time_word_lbl.Text = wordsure.Elapsed.Seconds.ToString() + " saniye " + wordsure.Elapsed.Milliseconds.ToString() + " ms ";
            time_pdf_lbl.Text = pdfsure.Elapsed.Seconds.ToString() + " saniye " + pdfsure.Elapsed.Milliseconds.ToString() + "    ms ";

        }

        private void ListboxlariTemizle()
        {
            //labellari temizle
            txt_sonuc_lbx.Items.Clear();
            html_sonuc_lbx.Items.Clear();
            word_sonuc_lbx.Items.Clear();
            pdf_sonuc_lbx.Items.Clear();
            txt_sonuc2_lbx.Items.Clear();
            html_sonuc2_lbx.Items.Clear();
            word_sonuc2_lbx.Items.Clear();
            pdf_sonuc2_lbx.Items.Clear();
        }

        // Arama algoritmasi
        public void Bruteforce(String txt, String pat, int sozcuk)
        {

            int M = pat.Length; //aranan kelimenin nerede oldugu
            int N = txt.Length; // tum metnin uzunlugu

            string aranan = "";

            for (int i = 0; i <= N - M; i++)
            {
                int j;

                for (j = 0; j < M; j++)
                {
                    if (txt[i + j] != pat[j])
                    {
                        break;
                    }
                }

                // eslesme saglandiginda listboxa ekle

                // 1 = txt dosyasi
                // 2 = html dosyasi
                // 3 = word dosyasi
                // 4 = pdf dosyasi
                if (j == M)
                {
                    if (sozcuk == 1)
                        txt_sonuc_lbx.Items.Add(pat + " bulunduğu kaçıncı harf : " + i);
                    else if (sozcuk == 2)
                        html_sonuc_lbx.Items.Add(pat + " bulunduğu kaçıncı harf : " + i);
                    else if (sozcuk == 3)
                        word_sonuc_lbx.Items.Add(pat + " bulunduğu kaçıncı harf : " + i);
                    else if (sozcuk == 4)
                        pdf_sonuc_lbx.Items.Add(pat + " bulunduğu kaçıncı harf : " + i);
                }

                aranan = txt.Substring(i, M); // benzerlik algoritmasina gondermek icin buldugumuz kelimelerin baslangic ve boyutlarinin  yerini tutuyoruz

                // Metinler arasi benzerlik bulma 
                // Kelimemizle arasinda bir ve iki fark olan kelimeleri  bunu mu aradiniz labellerine ekle
                // Levenshtein Distance Algoritmasi ile bakiyoruz
                int benzerlikdurumu = LevenshteinDistance(aranan, pat);
                if (benzerlikdurumu != 0 && benzerlikdurumu < 3)
                {
                    if (sozcuk == 1)
                    {
                        if (!txt_sonuc2_lbx.Items.Contains(aranan))
                        {
                            txt_sonuc2_lbx.Items.Add(aranan);
                        }
                    }
                    else if (sozcuk == 2)
                    {
                        if (!html_sonuc2_lbx.Items.Contains(aranan))
                        {
                            html_sonuc2_lbx.Items.Add(aranan);
                        }
                    }
                    else if (sozcuk == 3)
                    {
                        if (!word_sonuc2_lbx.Items.Contains(aranan))
                        {
                            word_sonuc2_lbx.Items.Add(aranan);
                        }
                    }

                    else if (sozcuk == 4)
                    {
                        if (!pdf_sonuc2_lbx.Items.Contains(aranan))
                        {
                            pdf_sonuc2_lbx.Items.Add(aranan);
                        }
                    }
                }
            }
        }

        //Benzerlik algoritmamiz
        public static int LevenshteinDistance(string first, string second)
        {
            if (first.Length == 0) return second.Length;
            if (second.Length == 0) return first.Length;

            var lenFirst = first.Length;
            var lenSecond = second.Length;

            var d = new int[lenFirst + 1, lenSecond + 1];

            for (var i = 0; i <= lenFirst; i++)
                d[i, 0] = i;

            for (var i = 0; i <= lenSecond; i++)
                d[0, i] = i;

            for (var i = 1; i <= lenFirst; i++)
            {
                for (var j = 1; j <= lenSecond; j++)
                {
                    var match = (first[i - 1] == second[j - 1]) ? 0 : 1;

                    d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + match);
                }
            }

            return d[lenFirst, lenSecond];
        }

        // bunu mu demek istediniz kısmında labellara basarak aratma kismi
        private void listBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txt_sonuc2_lbx.SelectedIndex != -1)
            {
                string yeniarama = txt_sonuc2_lbx.SelectedItem.ToString();
                aranan_txt.Text = yeniarama;
                ara_btn.PerformClick();
            }
        }

        private void listBox6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (html_sonuc2_lbx.SelectedIndex != -1)
            {
                string yeniarama = html_sonuc2_lbx.SelectedItem.ToString();
                aranan_txt.Text = yeniarama;
                ara_btn.PerformClick();
            }
        }

        private void listBox7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (word_sonuc2_lbx.SelectedIndex != -1)
            {
                string yeniarama = word_sonuc2_lbx.SelectedItem.ToString();
                aranan_txt.Text = yeniarama;
                ara_btn.PerformClick();
            }
        }

        private void listBox8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pdf_sonuc2_lbx.SelectedIndex != -1)
            {
                string yeniarama = pdf_sonuc2_lbx.SelectedItem.ToString();
                aranan_txt.Text = yeniarama;
                ara_btn.PerformClick();
            }
        }
    }
}
