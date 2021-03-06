﻿using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GemBox.Document;
using System.Text.RegularExpressions;

namespace Veri_Arama_Motoru
{
    public partial class Arama : Form
    {
        
        string b;
        public StreamWriter bulunanSw;
        public Arama()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

           
            ComponentInfo.FreeLimitReached += (sender, e) => e.FreeLimitReachedAction = FreeLimitReachedAction.Stop;
            InitializeComponent();
        }

       
        #region ARAMA İŞLEMİ YAP
        public void Sedat()
            {
            bulunanSw = new StreamWriter("sonuclar.txt");/*Bulduğumuz sonuçları sonuclar.txt dosyasına yazmak için bulunanSW adında yazma nesnesi oluşturdum*/

            DirectoryInfo klasorum = new DirectoryInfo("Arama Yapılacak Dosyalar\\");/*Arama Yapılacak Dosyalar adlı klasörün bilgisi klasorum adlı nesnede tutulacak*/
            FileInfo[] txtDosya = klasorum.GetFiles("*.txt");/*Klasörüm nesnesinin içerisinceki txt uzantılı dosyaları txtDosya adlı nesneye alıyoruz*/
            FileInfo[] docDosya = klasorum.GetFiles("*.docx");/*Klasörüm nesnesinin içerisinceki docx uzantılı dosyaları docDosya adlı nesneye alıyoruz*/
            FileInfo[] pdfDosya = klasorum.GetFiles("*.pdf");/*Klasörüm nesnesinin içerisinceki txt uzantılı dosyaları pdfDosya adlı nesneye alıyoruz*/
            FileInfo[] htmlDosya = klasorum.GetFiles("*.html");/*Klasörüm nesnesinin içerisinceki txt uzantılı dosyaları htmlDosya adlı nesneye alıyoruz*/

            
            TumTurlerdeAramaYap(docDosya);
            TumTurlerdeAramaYap(pdfDosya);
            TumTurlerdeAramaYap(htmlDosya);
            TumTurlerdeAramaYap(txtDosya);

            bulunanSw.Close();
            string snc = @"sonuclar.txt";     
            System.Diagnostics.Process.Start(snc);
        }
        #endregion

        #region BUNU MU DEMEK İSTEDİNİZ ? - FONKSİYON -

        /*Google gibi bunu mu demek istediniz demek için Levenshtein Distance Algoritmasını kullanarak bulduracağız*/

        public int LevenshteinDistance(string source,string target)/*2 parametre geliyor- source aranmak istenen - target yaklaşık değer(ilk seferde diğer karakterlerden ayrılmış şeklini buraya yolluyoruz)*/
        {

            /*Gelen değerlerin uzunluklarını aktarılıyor*/
            int sourceWordCount = source.Length;
            int targetWordCount = target.Length;  
            
            /*Aktarılan uzunluklara +1 ekleyerek 2 boyutlu bir dizi (algoritma zaten matris mantığıyla yaklaşık değer buluyor) oluşturuyoruz*/
            int[,] distance = new int[sourceWordCount + 1, targetWordCount + 1]; 

           /*Harf karşılaştırmaları yapılarak aradaki değişim farkı elde edilecek*/
            
            for (int ki = 0; ki <= sourceWordCount; distance[ki, 0] = ki++) ;
            for (int kj = 0; kj <= targetWordCount; distance[0, kj] = kj++) ;

            for (int ki = 1; ki <= sourceWordCount; ki++)
            {
                for (int kj = 1; kj <= targetWordCount; kj++)
                {
                   
                    int cost = (target[kj - 1] == source[ki - 1]) ? 0 : 1;

                    
                    distance[ki, kj] = Math.Min(Math.Min(distance[ki - 1, kj] + 1, distance[ki, kj - 1] + 1), distance[ki - 1, kj - 1] + cost);
                }
            }
            return distance[sourceWordCount, targetWordCount];/*Geriye değer döndürme*/
        }
        #endregion

        #region TÜM TÜRLERDE ARAMA FONKSİYONU
        /*Asıl arama fonksiyonu*/
        /*Doğrusal (Lineer) Arama Algoritması sırayla bakarak varsa bulacak*/
       
        public void TumTurlerdeAramaYap(FileInfo[] gelenDosya)
        {
            for (int i = 0; i < gelenDosya.Length; i++)
            {
                int sayac = 0;
                TextReader okunan = new StreamReader("Arama Yapılacak Dosyalar\\" + gelenDosya[i], Encoding.GetEncoding("UTF-8"), false);
                var belgem = DocumentModel.Load(gelenDosya[i].FullName);
                string yazi = belgem.Content.ToString();
                String[] cumleDizim = yazi.Split('.','?','!'); /*Nokta - soru işareti- ünlem görene kadar alan yani cümlelerden oluşturduğumuz dizi*/
                foreach (string cumle in cumleDizim) /*Cümle dizisinde sıradan ilerliyoruz*/
                {
                    string[] kelimelerim = cumle.Split(' '); /*Boşluk görünce boşluktan önceki kısmı yani kelimeleri alıyoruz*/
                    sayac++;
                    StringBuilder sb = new StringBuilder(); /*string değerleri birleştirmek için kullandığımız nesne*/
                    for (int x = 0; x < kelimelerim.Length; x++) /*Kelimenin harf sayısı kadar döngü açıyoruz*/
                    {
                        sb.Clear();
                        foreach (char c in kelimelerim[x]) /*Kelime sayımızca dönen bir döngü ve sırasıyla c değişkenine aktarıyoruz.*/
                        {
                            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))/*Harfler dışında kalan diğer karakterlerden ayırma yapıyoruz*/
                            {
                                sb.Append(c);
                            }
                        }

                        string source = textBox1.Text.ToLower();
                        string target = sb.ToString().ToLower();

                        if (LevenshteinDistance(source, target) == 2) /*2 farkla yaklaşık bir kelime bulmasını istiyorum eğer öyleyse değereri yazıyor*/
                        {
                            b = target;
                            yaklasikDeger.Text = b;
                        }

                        if (sb.ToString().ToLower() == textBox1.Text.ToLower())/*Eğer istenilen ifade ayıklanmış kelimeye eşitse bulundu demektir.*/
                        {
                       
                            bulunanlarLB.Items.Add( gelenDosya[i] + "- " + sayac + ". cümle - " + DateTime.Now + " - " + cumle);
                            bulunanSw.WriteLine(gelenDosya[i] + "- " + sayac + ". cümle - " + DateTime.Now + " - " + cumle);
                            bulunanSw.WriteLine("");
                        }

                    }

                }
            }
            
        }



        #endregion

        private void yaklasikDeger_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Text = yaklasikDeger.Text;
            bulunanlarLB.Items.Clear();
            Sedat();
            label5.Text = "ADET:";
            label5.Text = label5.Text + " " + bulunanlarLB.Items.Count.ToString();
        }

        private void AraBtn_Click(object sender, EventArgs e)
        {
            bulunanlarLB.Items.Clear();
            Sedat();
            label5.Text = "ADET:";
            label5.Text = label5.Text + " " + bulunanlarLB.Items.Count.ToString();
        }

        private void bulunanlarLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Listboxda Listelenenlere tıklanınca ilgili dosyanın açılması için*/
            try
            {
                int sonuc = -1;
                int sonuc2 = -1;
                int sonuc3 = -1;
                int sonuc4 = -1;

                /*IndexOfile metin içerisinde dosya uzantımızı aratıyoruz varsa 0'dan buyuk deger donecek*/
                sonuc = bulunanlarLB.SelectedItem.ToString().IndexOf("docx", 0);
                sonuc2 = bulunanlarLB.SelectedItem.ToString().IndexOf("pdf", 0);
                sonuc3 = bulunanlarLB.SelectedItem.ToString().IndexOf("html", 0);
                sonuc4 = bulunanlarLB.SelectedItem.ToString().IndexOf("txt", 0);


                if (sonuc > 0)
                {
                    string snc = @"Arama Yapılacak Dosyalar\\Doğan Cüceloğlu.docx";
                    System.Diagnostics.Process.Start(snc);
                }


                else if (sonuc2 > 0)
                {
                    string snc2 = @"Arama Yapılacak Dosyalar\\Saatleri Ayarlama Enstitüsü.pdf";
                    System.Diagnostics.Process.Start(snc2);
                }


                else if (sonuc3 > 0)
                {
                    string snc3 = @"Arama Yapılacak Dosyalar\\Olasılıksız.html";
                    System.Diagnostics.Process.Start(snc3);
                }


                else if (sonuc4 > 0)
                {
                    string snc4 = @"Arama Yapılacak Dosyalar\\Ejderha Dövmeli Kız.txt";
                    System.Diagnostics.Process.Start(snc4);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir sorun oldu");
            }
           
        }
    }
    }
   

