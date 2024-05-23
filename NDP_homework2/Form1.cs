/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:3 PROJE
**				ÖĞRENCİ ADI............:SERHAT HAR
**				ÖĞRENCİ NUMARASI.......:G231210040
**              DERSİN ALINDIĞI GRUP...:2A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NDP_homework2 {
    public partial class Form1 : Form {

        List<Randevu> randevular = new List<Randevu>();//verileri kaydetmek için kullandığım diziler
        List<Müşteri> müşteriler = new List<Müşteri>();
        List<Calisan> calisanlar = new List<Calisan>();
        List<String> calisan_isimleri = new List<String>();

        public Form1() {
            InitializeComponent();//yıkama ve parfum devre dışı başlıyor
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            comboBox1.Enabled = false;
            dateTimePicker1.MinDate = DateTime.Today;
            comboBox2.DataSource = calisan_isimleri;
        }

        private void button1_Click(object sender, EventArgs e) {

            Randevu randevu = new Randevu();//randevu ekle butonuna basıldığında yeni nesneler oluşturuluyor.
            Müşteri müşteri = new Müşteri();

            müşteri.Ad = textBox1.Text;
            müşteri.Soyad = textBox2.Text;//veriler nesnelere yerleştiriliyor
            müşteri.Phone = textBox3.Text;

            randevu.müşteri = müşteri.Ad + " " + müşteri.Soyad;
            randevu.müşteri_ulaşım = müşteri.Phone;
            randevu.calisan = calisanlar[comboBox2.SelectedIndex].Ad + " " + calisanlar[comboBox2.SelectedIndex].Soyad;

            if (checkBox1.Checked) {
                randevu.ucret += 100;
                randevu.hizmet += " " + checkBox1.Text + "(100TL)";
            }
            if (checkBox2.Checked) {
                randevu.ucret += 30;
                randevu.hizmet += " " + checkBox2.Text + "(30TL)";
            }
            if (checkBox3.Checked) {
                randevu.ucret += 20;
                randevu.hizmet += " " + checkBox3.Text + "(20TL)";
            }
            if (checkBox4.Checked) {
                randevu.ucret += 15;
                randevu.hizmet += " " + checkBox4.Text + "(15TL)";
            }

            randevu.tarih = dateTimePicker1.Text + " " + comboBox1.Text;
            randevular.Add(randevu);
            müşteriler.Add(müşteri);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = randevular;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

        }

        private bool kontrol() {//checkbox 1'in işaretlenme işaretlenmeme durumunu kontrol ediyor.
            if (checkBox1.Checked) {
                return true;
            }
            else {
                return false;
            }
        }

        private void çalışanEkleToolStripMenuItem_Click(object sender, EventArgs e) {//calisan ekleme fonksiyonu
            Calisan calisan = new Calisan();
            bool varmi = false;
            Calisan_ekle calisan_Ekle = new Calisan_ekle(calisan);
            calisan_Ekle.ShowDialog();

            foreach (Calisan calisan1 in calisanlar) {
                if (calisan1.Phone == calisan.Phone) {
                    MessageBox.Show("Bu telefon numarasına sahip bir çalısan var!" + calisanlar.Count);
                    varmi = true;
                    break;
                }
            }

            if (varmi == false) {
                if (calisan.Phone.Length < 10) {
                    MessageBox.Show("telefon numarası bu kadar kısa olamaz" + calisan.Phone.Length);
                }
                MessageBox.Show("Calisan eklendi!");
                calisanlar.Add(calisan);
                calisan_isimleri.Add(calisan.Ad + " " + calisan.Soyad);
                comboBox2.DataSource = null;
                comboBox2.DataSource = calisan_isimleri;
                MessageBox.Show(" " + calisanlar.Count);
            }
        }


        private void calisan_isimleri_guncelle() {//calisan isimleri guncellendiginde DB fetch yapan fonksiyon
            calisan_isimleri = new List<String>();
            foreach (Calisan eleman in calisanlar) {
                calisan_isimleri.Add(eleman.Ad + " " + eleman.Soyad);
            }//dictionary kullan böyle olmaz
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            // İlk checkbox'un durumuna bağlı olarak diğer checkbox'ların etkinlik durumunu ayarla
            if (checkBox1.Checked) {
                // İlk checkbox işaretli ise diğer checkbox'ları etkinleştir
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }
            else {
                // İlk checkbox işaretli değilse diğer checkbox'ları devre dışı bırak
                checkBox3.Enabled = false;
                checkBox3.Checked = false; // İlk checkbox işaretli değilse diğerleri de işaretsiz olmalı
                checkBox4.Enabled = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            // İlk iki checkbox'un durumuna bağlı olarak son iki checkbox'un etkinlik durumunu ayarla
            if (kontrol()) {
                // İlk checkbox işaretli ise diğer checkbox'ları etkinleştir
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            // İlk iki checkbox'un durumuna bağlı olarak son iki checkbox'un etkinlik durumunu ayarla
            if (kontrol()) {
                // İlk checkbox işaretli ise diğer checkbox'ları etkinleştir
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }
        }

        private void çalışanÇıkarToolStripMenuItem_Click(object sender, EventArgs e) {//calisan silme fonksiyonu
            Calisankontrol kontrol = new Calisankontrol(calisanlar, true);
            kontrol.ShowDialog();
            comboBox2.DataSource = null;
            comboBox2.DataSource = calisan_isimleri;
            calisan_isimleri_guncelle();
        }

        private void çalışanlarıGüncelleToolStripMenuItem_Click(object sender, EventArgs e) {//calisan guncelleme fonksiyonu
            Calisankontrol kontrol = new Calisankontrol(calisanlar, false);
            kontrol.ShowDialog();
            comboBox2.DataSource = null;
            comboBox2.DataSource = calisan_isimleri;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            // comboBox1'deki seçili öğeyi kontrol et
            if (comboBox2.SelectedItem != null) {
                // Eğer seçili bir öğe varsa, comboBox2'yi etkinleştir
                comboBox1.Enabled = true;
            }
            else {
                // Seçili bir öğe yoksa, comboBox2'yi devre dışı bırak
                comboBox1.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }
        private void label7_Click(object sender, EventArgs e) {

        }
        private void label8_Click(object sender, EventArgs e) {

        }
        private void textBox3_TextChanged(object sender, EventArgs e) {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void button2_Click(object sender, EventArgs e) {

        }
        private void Form1_Load(object sender, EventArgs e) {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        private void randevuDüzenleToolStripMenuItem_Click(object sender, EventArgs e) {
            Randevu_duzenle duzenle = new Randevu_duzenle(randevular, false);
            duzenle.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = randevular;
        }

        private void randevuKaldırToolStripMenuItem_Click(object sender, EventArgs e) {
            Randevu_duzenle duzenle = new Randevu_duzenle(randevular, true);
            duzenle.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = randevular;
        }

        private void label10_Click(object sender, EventArgs e) {

        }
    }
}