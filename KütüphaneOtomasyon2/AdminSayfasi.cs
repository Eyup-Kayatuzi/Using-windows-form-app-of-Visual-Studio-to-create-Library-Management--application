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
    public partial class AdminSayfasi : Form
    {
        public AdminSayfasi()
        {
            InitializeComponent();            
        } 

        private void groupBox_Uyeler_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_kullaniciAd_Click(object sender, EventArgs e)
        {

        }

        private void lbl_baslik_Click(object sender, EventArgs e)
        {

        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            
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

                dataGridView1.Rows.Add(id, isim, soyisim, date.ToShortDateString(), kullaniciadi, c.getSifre(), c.getYetki());
            }
            foreach (var a in Form1.kitaplarim)
            {
                dataGridView2.Rows.Add(Convert.ToInt32(a.getKitapId()), a.getkitapIsim(), a.getkitapYazar(), a.getkitapDili(), a.getyayinEvi(), a.gettur(), a.getadet(), a.getsayfaSayisi(), a.getbasimYil());
            }

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && txt_isim.Text != "")
            {
                dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyisim.Text, Convert.ToDateTime(textBoxenson.Text), txt_kullaniciAd.Text, txt_sifre.Text, txt_yetki.Text);
                Form1 gonder = new Form1(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyisim.Text, Convert.ToDateTime(textBoxenson.Text), txt_kullaniciAd.Text, txt_sifre.Text, txt_yetki.Text);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                dataGridView1.CurrentRow.Cells[0].Value = Convert.ToInt32(txt_id.Text);
                dataGridView1.CurrentRow.Cells[1].Value = txt_isim.Text;
                dataGridView1.CurrentRow.Cells[2].Value = txt_soyisim.Text;
                dataGridView1.CurrentRow.Cells[3].Value = Convert.ToDateTime(textBoxenson.Text);
                dataGridView1.CurrentRow.Cells[4].Value = txt_kullaniciAd.Text;
                dataGridView1.CurrentRow.Cells[5].Value = txt_sifre.Text;
                dataGridView1.CurrentRow.Cells[6].Value = txt_yetki.Text;
            }

        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxenson.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciAd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_id.Text = String.Empty;
            txt_isim.Text = String.Empty;
            txt_soyisim.Text = String.Empty;
            textBoxenson.Text = String.Empty;
            txt_kullaniciAd.Text = String.Empty;
            txt_sifre.Text = String.Empty;
            txt_yetki.Text = String.Empty;
            textBox1.Text = String.Empty;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_isim_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            if (txt_kitapisim.Text != "" && txt_kitaptür.Text != "")
            {
                dataGridView2.Rows.Add(Convert.ToInt32(txt_kitapid.Text), txt_kitapisim.Text, txt_kitapyazar.Text, txt_dil.Text, txt_kitapyayinevi.Text, txt_kitaptür.Text, Convert.ToInt32(txt_kitapadet.Text), Convert.ToInt32(txt_kitapsayfa.Text), Convert.ToInt32(txt_kitapbasimyil.Text));
                Form1 gonder = new Form1(Convert.ToInt32(txt_kitapid.Text), txt_kitapisim.Text, txt_kitapyazar.Text, txt_dil.Text, txt_kitapyayinevi.Text, txt_kitaptür.Text, Convert.ToInt32(txt_kitapadet.Text), Convert.ToInt32(txt_kitapsayfa.Text), Convert.ToInt32(txt_kitapbasimyil.Text));
            }
                
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            if (txt_kitapid.Text != "")
            {
                dataGridView2.CurrentRow.Cells[0].Value = Convert.ToInt32(txt_kitapid.Text);
                dataGridView2.CurrentRow.Cells[1].Value = txt_kitapisim.Text;
                dataGridView2.CurrentRow.Cells[2].Value = txt_kitapyazar.Text;
                dataGridView2.CurrentRow.Cells[3].Value = txt_dil.Text;
                dataGridView2.CurrentRow.Cells[4].Value = txt_kitapyayinevi.Text;
                dataGridView2.CurrentRow.Cells[5].Value = txt_kitaptür.Text;
                dataGridView2.CurrentRow.Cells[6].Value = Convert.ToInt32(txt_kitapadet.Text);
                dataGridView2.CurrentRow.Cells[7].Value = Convert.ToInt32(txt_kitapsayfa.Text);
                dataGridView2.CurrentRow.Cells[8].Value = Convert.ToInt32(txt_kitapbasimyil.Text);
            }

        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            foreach(Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            textBox2.Text = String.Empty;

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();    
            txt_kitapyazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_dil.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_kitapyayinevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_kitaptür.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_kitapadet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_kitapsayfa.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_kitapbasimyil.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_kisiAra_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Kisi hedefKisi = null;
                int secilenKisiID = Convert.ToInt32(textBox1.Text);

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

        private void btn_kisiYenile_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Clear();
            foreach (Kisi kisi in Form1.kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarih(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());
            }
        }

        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Kitap hedefkitap = null;
                int secilenKitapID = Convert.ToInt32(textBox2.Text);
                foreach (Kitap kitap in Form1.kitaplarim)
                {
                    if (kitap.getKitapId() == secilenKitapID)
                    {
                        hedefkitap = kitap;
                        break;
                    }
                }
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(hedefkitap.getKitapId(), hedefkitap.getkitapIsim(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayinEvi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getsayfaSayisi(), hedefkitap.getbasimYil());
            }

        }

        private void btn_kitapYenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            foreach (Kitap kitap in Form1.kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getkitapIsim(), kitap.getkitapYazar(), kitap.getkitapDili(), kitap.getyayinEvi(), kitap.gettur(), kitap.getadet(), kitap.getsayfaSayisi(), kitap.getbasimYil());
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1.kisilerim.Clear();
            Form1.kitaplarim.Clear();   
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
