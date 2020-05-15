using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Keripik Tempe")
            {
                textBox5.Text = "4000";
            }
            else if (comboBox1.Text == "Keripik Pisang")
            {
                textBox5.Text = "5000";
            }
            else if (comboBox1.Text == "Peyek Kacang")
            {
                textBox5.Text = "3500";
            }
            else if (comboBox1.Text == "Peyek Bayam")
            {
                textBox5.Text = "3500";
            }
            else if (comboBox1.Text == "Peyek Teri")
            {
                textBox5.Text = "3500";
            }
        }
        
        List <int> jumlah = new List<int>();
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) && string.IsNullOrWhiteSpace(textBox5.Text) && string.IsNullOrWhiteSpace(comboBox2.Text) && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Pilih Item Terlebih Dahulu");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox5.Text);
                c = a * b;
                this.textBox5.Text = Convert.ToString(c);
                jumlah.Add(c);
                int total = 0;
                total = jumlah.Sum();
                this.textBox2.Text = Convert.ToString(total);
                listBox1.Items.Add("        " + comboBox1.Text + "   " + comboBox2.Text + "            " + textBox5.Text);
                
                comboBox1.Text = "";
                textBox5.Text = "";
                comboBox2.Text = "";
                textBox1.Text = "";
                
            }
        }
        public void ATM()
        {
            ArrayList Pilihan = new ArrayList() { "BNI","BRI","BTN","MANDIRI" };
            {
                foreach (var x in Pilihan)
                {
                    comboBox4.Items.Add(x);
                }
            }
        }
        public void Uang()
        {
            ArrayList Pilihan = new ArrayList() { "GOPAY", "OVO", "DANA"};
            if (comboBox3.Text == "Uang Elektronik")
            {
                foreach (var x in Pilihan)
                {
                    comboBox4.Items.Add(x);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kamu Yakin ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                MessageBox.Show("Terima Kasih Telah Mengunjungi Toko Kami");
                this.Close();
            }
            else
            {
   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] x = { "1. Pastikan memasukan data pesanan dengan benar"," 2. Pilih Jenis Rekening Pembayaran", "3. Masukkan No Rekening dengan benar",
                "4. Masukkan Total Harga Pesanan ","5. Jika data yang anda masukan sudah benar tekan tombol Beli"};
            foreach (string s in x)
            {
                MessageBox.Show(s);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "ATM")
            {
                comboBox4.Items.Clear();
                ATM ();
            }
            else if (comboBox3.Text == "Uang Elektronik")
            {
                comboBox4.Items.Clear();
                Uang();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox3.Text) && string.IsNullOrWhiteSpace(textBox3.Text) && string.IsNullOrWhiteSpace(comboBox4.Text) && string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Masukkan Data Terlebih Dahulu");
            }
            else if(comboBox3.Text == "Manual")
            {
                MessageBox.Show("Silahkan Melakukan Pembayaran Dikasir");
                comboBox3.Text = "";
                comboBox4.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                listBox1.Text = "";
            }
            else if(comboBox3.Text=="ATM")
            {
                MessageBox.Show("Transaksi Anda dari Rekening"+" "+comboBox4.Text+" "+"Dengan No Rekening"+" "+textBox3.Text+" "+"Sebesar Rp."+textBox4.Text+" "+"Telah Berhasil");
                comboBox3.Text = "";
                comboBox4.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                listBox1.Text = "";
            }
            else if (comboBox3.Text == "Uang Elektronik")
            {
                MessageBox.Show("Transaksi Anda dari Rekening" + " " + comboBox4.Text + " " + "Dengan No Rekening" + " " + textBox3.Text + " " + "Sebesar Rp." + textBox4.Text + " " + "Telah Berhasil");
                comboBox3.Text = "";
                comboBox4.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                listBox1.Text = "";
            }
            
        }
    }
} 
        
   
