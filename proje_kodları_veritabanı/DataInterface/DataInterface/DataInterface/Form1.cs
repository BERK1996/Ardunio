using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Data.SqlClient;


namespace DataInterface
{
    public partial class Form1 : Form
    {
        string[] ports = SerialPort.GetPortNames();
        public Form1()
        {
            InitializeComponent();
        }

        string sonuc;



        SqlConnection server = new SqlConnection("Data Source = DESKTOP-0A6NIS3\\SQLEXPRESS; Initial Catalog = Arduino; Integrated Security = True");






        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            {
                if (serialPort1.IsOpen == true)//Serial Portu kapatma
                {
                    serialPort1.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //toolStripStatusLabel3.Text = DateTime.Now.ToString();
            label6.Text = DateTime.Now.ToString();
            
            



        }

       
        
        private void timer2_Tick(object sender, EventArgs e)
        {

            try
            {
                
                    sonuc = serialPort1.ReadLine();
                    label5.Text = sonuc;


                if (Convert.ToInt32(sonuc) >= 100 && Convert.ToInt32(sonuc) < 200)
                {
                    string sicaklik = sonuc;
                    label8.Text = sicaklik.Substring(1, 2);
                    server.Open();
                    SqlCommand cmd = new SqlCommand("insert into sicaklik(tarih,sicaklik) values (@tarih, @sicaklik)", server);
                    cmd.Parameters.AddWithValue("@tarih", label6.Text);
                    cmd.Parameters.AddWithValue("@sicaklik", Convert.ToInt32(label8.Text));
                    cmd.ExecuteNonQuery();
                    server.Close();
                    sc.chart2.DataBind();

                }
                else
                {
                    string nem = sonuc;
                    label9.Text = nem;
                    server.Open();
                    SqlCommand cmd = new SqlCommand("insert into nem(tarih,nem) values (@tarih, @nem)", server);
                    cmd.Parameters.AddWithValue("@tarih", label6.Text);
                    cmd.Parameters.AddWithValue("@nem", Convert.ToInt32(label9.Text));
                    cmd.ExecuteNonQuery();
                    server.Close();
                    tn.chart1.DataBind();
                }





            }
            catch (Exception ex)
            {

                
                timer2.Stop();
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();

            if (serialPort1.IsOpen == false)
            {
                if (comboBox1.Text == "")
                    return;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                try
                {
                    serialPort1.Open();
                    label3.ForeColor = Color.Green;
                    label3.Text = "Bağlantı Açık";
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata :" + hata.Message);


                }
            }
            else
            {
                label3.Text = "Bağlantı Kuruldu";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                label3.ForeColor = Color.Red;
                label3.Text = "Bağlantı Kapalı";
                label5.Text = "";
                label11.Text = "";
            }
        }

        

        



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        ToprakNem tn = new ToprakNem();
        Sicaklik sc = new Sicaklik();

        private void Form1_Load(object sender, EventArgs e)
        {
           timer1.Start();
            label6.Text = DateTime.Now.ToString();
            

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
            }
            comboBox2.Items.Add("2400");
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("19200");
            comboBox2.Items.Add("115200");
            comboBox2.SelectedIndex = 2;
            label3.Text = "Bağlantı Kapalı";
            comboBox1.DataSource = SerialPort.GetPortNames();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sicaklik sc = new Sicaklik();
            sc.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ToprakNem tn = new ToprakNem();
            tn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
