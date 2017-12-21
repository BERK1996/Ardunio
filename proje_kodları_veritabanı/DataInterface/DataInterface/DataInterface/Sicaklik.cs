using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataInterface
{
    public partial class Sicaklik : Form
    {
        public Sicaklik()
        {
            InitializeComponent();
        }
        SqlConnection server = new SqlConnection("Data Source = DESKTOP-0A6NIS3\\SQLEXPRESS; Initial Catalog = Arduino; Integrated Security = True");
        private void Sicaklik_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // TODO: Bu kod satırı 'arduinoDataSet.sicaklik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sicaklikTableAdapter.Fill(this.arduinoDataSet.sicaklik);
            listele();
        }

        public void listele()
        {
            server.Open();
            SqlCommand cmd = new SqlCommand(("select * from sicaklik"), server);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //SqlDataReader dr = cmd.ExecuteReader();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.chart2.DataBind();
            cmd.ExecuteNonQuery();
            server.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.Open();
            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE sicaklik", server);
            dataGridView1.DataSource = "";
            cmd.ExecuteNonQuery();
            
            server.Close();
            
            chart2.Series["sicaklik"].Points.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            this.chart2.Update();
        }
    }
}
