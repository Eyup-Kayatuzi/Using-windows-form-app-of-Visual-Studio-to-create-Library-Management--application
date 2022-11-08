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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KütüphaneOtomasyon
{
    public partial class UyeSayfasi : Form
    {
        public UyeSayfasi()
        {
            InitializeComponent();
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach (var b in Form1.kitaplarim)
            {
                dataGridView11.Rows.Add(Convert.ToInt32(b.getKitapId()), b.getkitapIsim(), b.getkitapYazar(), b.getkitapDili(), b.getyayinEvi(), b.gettur(), b.getadet(), b.getsayfaSayisi(), b.getbasimYil());
            }

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "ISIM";
            dataGridView1.Columns[2].Name = "SOYISIM";
            dataGridView1.Columns[3].Name = "OLUSTURMA TARİH";
            dataGridView1.Columns[4].Name = "KULLANICI ADI";
            dataGridView1.Columns[5].Name = "SİFRE";
            dataGridView1.Columns[6].Name = "YETKİ";

            foreach (var c in Form1.kisilerim)
            {
                int id = c.getId();
                string isim = c.getIsim();
                string soyisim = c.getSoyisim();
                DateTime date = c.getOlusturmaTarih();
                string kullaniciadi = c.getKullaniciAdi();

                dataGridView1.Rows.Add(id, isim, soyisim, date, kullaniciadi, c.getSifre(), c.getYetki());
            }
        }

        private void btn_cikis1_Click(object sender, EventArgs e)
        {
            Form1.kisilerim.Clear();
            Form1.kitaplarim.Clear();
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_kitapAra_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_kitapYenile_Click(object sender, EventArgs e)
        {

        }

        private void btn_kitapYenile_Click_1(object sender, EventArgs e)
        {
            //dataGridView11.Rows.Remove(dataGridView11.CurrentRow);
            dataGridView11.Rows.Clear();
            foreach (Kitap kitap in Form1.kitaplarim)
            {
                dataGridView11.Rows.Add(kitap.getKitapId(), kitap.getkitapIsim(), kitap.getkitapYazar(), kitap.getkitapDili(), kitap.getyayinEvi(), kitap.gettur(), kitap.getadet(), kitap.getsayfaSayisi(), kitap.getbasimYil());
            }
        }

        private void btn_kisiara_Click(object sender, EventArgs e)
        {
            if (textBoxforkisiler.Text != "")
            {
                Kisi hedefKisi = null;
                int secilenKisiID = Convert.ToInt32(textBoxforkisiler.Text);

                foreach (Kisi kisi in Form1.kisilerim)
                {
                    if (kisi.getId() == secilenKisiID)
                    {
                        hedefKisi = kisi;
                        break;
                    }
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarih(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
            }
            
        }

        private void btn_kisiyenile_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Clear();
            foreach (Kisi kisi in Form1.kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarih(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());
            }
        }

        private void textBoxforkisiler_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.kisilerim.Clear();
            Form1.kitaplarim.Clear();
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
        }

        private void btn_kitapAra_Click_2(object sender, EventArgs e)
        {
            if (textBoxforkitap.Text != "")
            {
                Kitap hedefkitap = null;
                int secilenKitapID = Convert.ToInt32(textBoxforkitap.Text);
                foreach (Kitap kitap in Form1.kitaplarim)
                {
                    if (kitap.getKitapId() == secilenKitapID)
                    {
                        hedefkitap = kitap;
                        break;
                    }
                }
                dataGridView11.Rows.Clear();
                dataGridView11.Rows.Add(hedefkitap.getKitapId(), hedefkitap.getkitapIsim(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayinEvi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getsayfaSayisi(), hedefkitap.getbasimYil());
            }

        }
    }
}
