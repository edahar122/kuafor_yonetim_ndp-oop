using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NDP_homework2 {
    public partial class Calisankontrol : Form {
        List<Calisan> calisanlar;

        public Calisankontrol(List<Calisan> calisanlar, Boolean isDelete) {//calisan kontrol form uygulamasını yukleyen fonksiyon
            InitializeComponent();
            if (isDelete.Equals(true)) {//calisan silme veya calisan düzenleme hangi işlem için ise ona uygun form yukleniyor
                button2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            else if (isDelete.Equals(false)) {
                button1.Visible = false;
            }

            dataGridView2.DataSource = null;
            this.calisanlar = calisanlar;
            dataGridView2.DataSource = calisanlar;
        }

        public Calisan CalisanAra(String id) {//ID ile çalısan arama fonksiyonu
            foreach (Calisan calisan in calisanlar) {
                if (calisan.CalisanID.ToString().Equals(id)) {
                    return calisan;
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e) {//calisan silme fonksiyonu
            Calisan calisan = CalisanAra(textBox1.Text);

            if (calisan != null) {
                dataGridView2.DataSource = null;
                calisanlar.Remove(calisan);
                dataGridView2.DataSource = calisanlar;

            }
            else {
                MessageBox.Show("Böyle bir çalışan bulunmamaktadır!");
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {//calisan guncelleme fonksiyonu
            Calisan calisan = CalisanAra(textBox1.Text);

            if (calisan != null) {
                dataGridView2.DataSource = null;
                if (textBox2.Text != "") {
                    calisan.Ad = textBox2.Text;
                }
                if (textBox3.Text != "") {
                    calisan.Soyad = textBox3.Text;
                }
                if (textBox4.Text != "") {
                    calisan.Phone = textBox4.Text;
                }

                dataGridView2.DataSource = calisanlar;
                MessageBox.Show("Calisan başarıyla güncellendi!");
            }

            else {
                MessageBox.Show("Böyle bir çalışan bulunmamaktadır!");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}