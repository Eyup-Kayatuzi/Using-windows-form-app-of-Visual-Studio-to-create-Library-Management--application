using KütüphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon
{
    public partial class Form1 : Form
    {
        public static List<Kisi> kisilerim = new List<Kisi>();
        public static List<Kitap> kitaplarim = new List<Kitap>();
        
        public Form1(int id, string isim, string soyisim, DateTime tt, string kullaniciAd, string sifre, string yetki)
        {
            kisilerim.Add(new Kisi(id, isim.ToLower(), soyisim.ToLower(), tt, kullaniciAd.ToLower(), sifre.ToLower(), yetki.ToLower()));
        }
        public Form1(int kitapid, string kitapisim, string kitapyazar, string kitapdili, string yayinevi, string tur, int adet, int sayfasayisi, int basimyil)
        {
            kitaplarim.Add(new Kitap(kitapid, kitapisim.ToLower(), kitapyazar.ToLower(), kitapdili, yayinevi.ToLower(), tur.ToLower(), adet, sayfasayisi, basimyil));
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {

            foreach (Control c in grpbx_giris.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            
            
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = null;
            kullaniciAdi = txt_kullaniciAd.Text;
            sifre = txt_sifre.Text;
            bool kontrol = false;

            foreach (var kisi in kisilerim)
            {
                if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi().ToLower() && sifre.ToLower() == kisi.getSifre().ToLower() && kisi.getYetki() == "admin")
                {
                    kontrol = true;
                    AdminSayfasi admin = new AdminSayfasi();
                    admin.Show();
                    this.Hide();
                    break;
                    
                }
                else if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi().ToLower() && sifre.ToLower() == kisi.getSifre().ToLower() && kisi.getYetki() == "uye")
                {
                    kontrol = true;
                    UyeSayfasi uye = new UyeSayfasi();
                    uye.Show();
                    this.Hide();
                    break;
                }
            }
            if (kontrol == false)
            {
                DialogResult result = MessageBox.Show("Wrong enter. Click yes if try again and click no if close", "Try", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.Close();
                }

            }


        }

        private void txt_kullaniciAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                kisilerim.Add(new Kisi(1, "eyüp", "kayatuzi", DateTime.Now, "eypkytz", "343434", "admin"));
                kisilerim.Add(new Kisi(2, "adile", "caca", DateTime.Now, "adile", "222222", "uye"));
                kisilerim.Add(new Kisi(3, "Muhammed", "bahaddin", DateTime.Now, "Muhammed", "333333", "uye"));
                kisilerim.Add(new Kisi(4, "sebahat", "SSS", DateTime.Now, "sebahat", "444444", "uye"));

                kitaplarim.Add(new Kitap(1, "içimizdeki şeytan", "sebahattin ali", "türkçe", "yapı kredi yayınları", "roman", 100, 250, 2016));
                kitaplarim.Add(new Kitap(2, "tutunamayanlar", "oğuz atay", "türkçe", "iletişim yayıncılık", "roman", 350, 760, 2015));
                kitaplarim.Add(new Kitap(3, "uçurtma avcısı", "khaled Hosseini", "ingilizce", "everest yayıncılık", "roman", 100, 350, 2010));
                kitaplarim.Add(new Kitap(4, "küçük prens", "antoine de saint-exupery", "ingilizce", "can çocuk yayınları", "roman", 50, 60, 2018));
                kitaplarim.Add(new Kitap(5, "kürk mantolu madonna", "sebahattin ali", "türkçe", "yapı kredi yayınları", "roman", 650, 220, 2015));
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
