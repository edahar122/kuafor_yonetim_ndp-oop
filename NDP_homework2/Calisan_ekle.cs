using System;
using System.Windows.Forms;

namespace NDP_homework2 {
    public partial class Calisan_ekle : Form {
        Calisan calisan;
        public Calisan_ekle(Calisan calisan) {
            InitializeComponent();
            this.calisan = calisan;
        }

        private void button1_Click(object sender, EventArgs e) {
            calisan.Ad = textBox1.Text;
            calisan.Soyad = textBox2.Text;
            calisan.Phone = textBox3.Text;
            this.Close();
        }

        private void Calisan_ekle_Load(object sender, EventArgs e) {

        }
    }
}