using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBasariHesaplama
{
    public partial class Form1 : Form
    {
        int ogrenciSayisi;
        bool mutlakBasari = true; // varsayýlan olarak 100'lük not sistemine göre hesaplama yapýlacak

        List<Ogrenci> ogrenciler = new List<Ogrenci>(); // girilen öðrenci bilgilerini tutmak için liste oluþturuldu

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciSayisi_Click(object sender, EventArgs e)
        {
            ogrenciSayisi = Convert.ToInt32(OgrenciSayisi.Text);
            MessageBox.Show("Öðrenci baþarý durumunu 100'lük not sistemine göre hesaplamak istiyorsanýz 'Tamam', baðýl sistemine göre hesaplamak istiyorsanýz 'Ýptal' butonuna týklayýn.");
            if (MessageBox.Show("Öðrenci baþarý durumunu 100'lük not sistemine göre hesaplamak istiyor musunuz?", "Hesaplama Türü Seçimi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                mutlakBasari = false;
            }
        }

        private void OgrenciEkle_Click(object sender, EventArgs e)
        {
            int sira = ogrenciler.Count + 1; // sýra numarasý öðrenci sayýsý kadar arttýrýlýyor
            int ogrenciNo = Convert.ToInt32(OgrenciNo.Text);
            string ogrenciAdi = OgrenciAdi.Text;
            string ogrenciSoyadi = OgrenciSoyadi.Text;
            int vizeNotu = Convert.ToInt32(VizeNotu.Text);
            int finalNotu = Convert.ToInt32(FinalNotu.Text);
            int butNotu = Convert.ToInt32(ButNotu.Text);

            Ogrenci ogrenci = new Ogrenci(sira, ogrenciNo, ogrenciAdi, ogrenciSoyadi, vizeNotu, finalNotu, butNotu, mutlakBasari);
            ogrenciler.Add(ogrenci);

            MessageBox.Show("Öðrenci baþarý bilgileri eklendi.");
        }

        private void OgrenciBilgileri_Click(object sender, EventArgs e)
        {
            int ogrenciNo = Convert.ToInt32(OgrenciNoAra.Text);

            Ogrenci ogrenci = ogrenciler.Find(x => x.OgrenciNo == ogrenciNo); // girilen öðrenci numarasýna göre öðrenci aranýyor

            OgrenciNoGoster.Text = ogrenci.OgrenciNo.ToString();
            OgrenciAdiGoster.Text = ogrenci.OgrenciAdi;
            OgrenciSoyadiGoster.Text = ogrenci.OgrenciSoyadi;
            VizeNotuGoster.Text = ogrenci.VizeNotu.ToString();
            FinalNotuGoster.Text = ogrenci.FinalNotu.ToString();
            // Baþarý notunu hesapla
            double basariNotu = 0.0;
            if (radioButton100.Checked) // 100'lük sistem seçilmiþ
            {
                basariNotu = (ogrenci.VizeNotu * 0.3) + (ogrenci.FinalNotu * 0.5) + (ogrenci.ButNotu * 0.2);
            }
            else // Baðýl sistem seçilmiþ
            {
                double sinifOrtalamasi = SinifOrtalamasiHesapla();
                double standartSapma = StandartSapmaHesapla(sinifOrtalamasi);
                double ogrenciOrtalamasi = (ogrenci.VizeNotu + ogrenci.FinalNotu) / 2.0;
                double zScore = (ogrenciOrtalamasi - sinifOrtalamasi) / standartSapma;
                basariNotu = 50.0 + (10.0 * zScore);
            }
            BasariNotuGoster.Text = basariNotu.ToString("0.##");

            // Harf notunu hesapla
            string harfNotu = HarfNotuHesapla(basariNotu);
            HarfNotuGoster.Text = harfNotu;
        }

        private double SinifOrtalamasiHesapla()
        {
            double toplamNot = 0.0;
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                toplamNot += (ogrenci.VizeNotu + ogrenci.FinalNotu);
            }
            double sinifOrtalamasi = toplamNot / (ogrenciler.Count * 2.0);
            return sinifOrtalamasi;
        }

        private double StandartSapmaHesapla(double sinifOrtalamasi)
        {
            double toplamKareFark = 0.0;
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                double ogrenciOrtalamasi = (ogrenci.VizeNotu + ogrenci.FinalNotu) / 2.0;
                toplamKareFark += Math.Pow((ogrenciOrtalamasi - sinifOrtalamasi), 2);
            }
            double varyans = toplamKareFark / ogrenciler.Count;
            double standartSapma = Math.Sqrt(varyans);
            return standartSapma;
        }

        private string HarfNotuHesapla(double basariNotu)
        {
            if (basariNotu >= 90)
            {
                return "AA";
            }
            else if (basariNotu >= 85)
            {
                return "BA";
            }
            else if (basariNotu >= 80)
            {
                return "BB";
            }
            else if (basariNotu >= 75)
            {
                return "CB";
            }
            else if (basariNotu >= 70)
            {
                return "CC";
            }
            else if (basariNotu >= 65)
            {
                return "DC";
            }
            else if (basariNotu >= 60)
            {
                return "DD";
            }
            else if (basariNotu >= 55)
            {
                return "FD";
            else 
                {
                    return "FF";
                }
            }
            private void OgrenciGoster_Click(object sender, EventArgs e)
            {
                int arananOgrenciNo = Convert.ToInt32(OgrenciNoGoster.Text);
                Ogrenci ogrenci = ogrenciler.Find(x => x.OgrenciNo == arananOgrenciNo);

                if (ogrenci == null)
                {
                    MessageBox.Show("Aradýðýnýz öðrenci bulunamadý!");
                }
                else
                {
                    OgrenciNoGoster.Text = ogrenci.OgrenciNo.ToString();
                    OgrenciAdiGoster.Text = ogrenci.OgrenciAdi;
                    OgrenciSoyadiGoster.Text = ogrenci.OgrenciSoyadi;
                    VizeNotuGoster.Text = ogrenci.VizeNotu.ToString();
                    FinalNotuGoster.Text = ogrenci.FinalNotu.ToString();
                    ButunlemeNotuGoster.Text = ogrenci.ButunlemeNotu.ToString();
                    BasariNotuGoster.Text = ogrenci.BasariNotu.ToString();
                    HarfNotuGoster.Text = ogrenci.HarfNotu;

                    int ogrenciSayisi = ogrenciler.Count;
                    double sinifOrtalamasi = ogrenciler.Average(x => x.BasariNotu);

                    double degerlendirmeyeKatilanlarinOrtalamasi = 0;
                    if (ogrenciSayisi > 0)
                    {
                        degerlendirmeyeKatilanlarinOrtalamasi = ogrenciler.Where(x => x.BasariNotu > 0).Average(x => x.BasariNotu);
                    }

                    OgrenciSayisiGoster.Text = ogrenciSayisi.ToString();
                    SinifOrtalamasiGoster.Text = sinifOrtalamasi.ToString();
                    DegerlendirmeyeKatilanlarinOrtalamasiGoster.Text = degerlendirmeyeKatilanlarinOrtalamasi.ToString();
                }
            }
        }
    }
    private void OgrenciBilgisiGoster_Click(object sender, EventArgs e)
    {
        if (ogrenciler.Count == 0)
        {
            MessageBox.Show("Öðrenci bilgisi girilmedi!");
            return;
        }

        // Hangi öðrencinin bilgilerinin gösterileceði sorgusu
        string ogrenciNoGoster = Microsoft.VisualBasic.Interaction.InputBox("Hangi öðrencinin bilgileri gösterilsin?", "Öðrenci No", "");

        // Girilen öðrenci numarasýna sahip öðrenci bulunuyor mu kontrolü
        Ogrenci ogrenci = ogrenciler.Find(o => o.OgrenciNo == ogrenciNoGoster);

        if (ogrenci == null)
        {
            MessageBox.Show("Girilen öðrenci numarasýna sahip öðrenci bulunamadý!");
            return;
        }

        // Öðrenci bilgilerini form üzerinde gösterme
        OgrenciNoGoster.Text = ogrenci.OgrenciNo.ToString();
        OgrenciAdiGoster.Text = ogrenci.OgrenciAdi;
        OgrenciSoyadiGoster.Text = ogrenci.OgrenciSoyadi;
        VizeNotuGoster.Text = ogrenci.VizeNotu.ToString();
        FinalNotuGoster.Text = ogrenci.FinalNotu.ToString();
        ButNotuGoster.Text = ogrenci.ButNotu.ToString();
        HarfNotuGoster.Text = ogrenci.HarfNotu;

        // Sýnýf ortalamasý, deðerlendirmeye katýlan öðrencilerin ortalamasý ve öðrenci sayýsý bilgilerinin gösterilmesi
        OgrenciSayisiGoster.Text = ogrenciler.Count.ToString();
        SinifOrtalamasiGoster.Text = sinifOrtalamasi.ToString();
        DegerlendirmeyeKatilanlarinOrtalamasiGoster.Text = degerlendirmeyeKatilanlarinOrtalamasi.ToString();
    }
