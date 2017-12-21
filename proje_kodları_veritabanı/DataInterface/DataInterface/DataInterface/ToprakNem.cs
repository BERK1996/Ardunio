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
    public partial class ToprakNem : Form
    {
        public ToprakNem()
        {
            InitializeComponent();
        }
        SqlConnection server = new SqlConnection("Data Source = DESKTOP-0A6NIS3\\SQLEXPRESS; Initial Catalog = Arduino; Integrated Security = True");
        private void ToprakNem_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // TODO: Bu kod satırı 'arduinoDataSet.nem' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.nemTableAdapter.Fill(this.arduinoDataSet.nem);
            listele();

        }
        public void listele()
        {
            server.Open();
            SqlCommand cmd = new SqlCommand(("select * from nem"), server);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //SqlDataReader dr = cmd.ExecuteReader();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.chart1.DataBind();
            cmd.ExecuteNonQuery();
            server.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            server.Open();
            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE nem", server);
            dataGridView1.DataSource = "";
            cmd.ExecuteNonQuery();

            server.Close();

            chart1.Series["nem"].Points.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            this.chart1.Update();
        }
    }
}
