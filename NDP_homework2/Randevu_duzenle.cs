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
    public partial class Randevu_duzenle : Form {
        List<Randevu> randevular1;
        public Randevu_duzenle(List<Randevu> randevular, Boolean isDelete) {
            InitializeComponent();
            if (isDelete.Equals(true)) {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                button1.Visible = false;
                dateTimePicker1.Visible = false;
            }
            else if (isDelete.Equals(false)) {
                label12.Visible = false;
                button2.Visible = false;
                textBox5.Visible = false;
            }
            dataGridView2.DataSource = randevular;
            randevular1 = randevular;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        public Randevu randevuAra(String id) {
            foreach (Randevu randevu in randevular1) {
                if (randevu.WorkID.ToString().Equals(id)) {
                    return randevu;
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e) {
            Randevu randevu = randevuAra(textBox4.Text);

            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked) {
                randevu.hizmet = "";
                randevu.ucret = 0;
            }

            if (randevu != null) {
                dataGridView2.DataSource = null;
                if (textBox1.Text != "" && textBox3.Text != "") {
                    randevu.müşteri = textBox1.Text + " " + textBox3.Text;
                }
                if (textBox1.Text != "" && textBox3.Text == "") {
                    String soyad = textBox3.Text;
                    randevu.müşteri = textBox1.Text + " " + soyad;
                }
                if (textBox1.Text == "" && textBox3.Text != "") {
                    String isim = textBox1.Text;
                    randevu.müşteri = isim + " " + textBox3.Text;
                }
                if (textBox2.Text != "") {
                    randevu.müşteri_ulaşım = textBox2.Text;
                }
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
                if (comboBox2.SelectedIndex != -1) {
                    randevu.calisan = comboBox2.Text;
                }
                if (comboBox1.SelectedIndex != -1) {
                    //randevu.tarih
                }
                dataGridView2.DataSource = randevular1;
                MessageBox.Show("Randevu başarıyla güncellendi!");
            }
            else {
                MessageBox.Show("Boyle bir randevu bulunmamaktadır");
            }

            /*if (randevu != null) {
                dataGridView2.DataSource = null;
                randevular1.Remove(randevu);
                dataGridView2.DataSource = randevular1;

            }
            else {
                MessageBox.Show("Böyle bir randevu bulunmamaktadır!");
            }*///silme bu
        }

        private void Randevu_duzenle_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            Randevu randevu = randevuAra(textBox5.Text);

            if (randevu != null) {
                dataGridView2.DataSource = null;
                randevular1.Remove(randevu);
                dataGridView2.DataSource = randevular1;

            }
            else {
                MessageBox.Show("Böyle bir çalışan bulunmamaktadır!");
            }
        }
    }
}

