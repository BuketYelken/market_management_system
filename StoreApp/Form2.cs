using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;


namespace StoreApp
{
    public partial class Form2 : Form
    {
        //Thread th1;
        Form3 frm3 = new Form3();
        public Form2()
        {
            InitializeComponent();

            
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public MySqlConnection mysqlconnect = new MySqlConnection("Server=localhost;Database=stock_tracking_system;username=root;password='';");

    
        public bool DatabseConnectControl()
        {
            bool status = false;
            try
            {
                mysqlconnect.Open();
                status = (mysqlconnect.State != ConnectionState.Closed) ? true : false;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error! " + err.Message);
            }


            return status;

        }
        private void Form2_Load(object sender, EventArgs e)
        {


            if (DatabseConnectControl())
            {
                // Mysql adaptörümü oluşturup komut gönderdim
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM customers", mysqlconnect);

                // Yeni bir veri tablosu oluşturdum 
                DataTable dataTable = new DataTable();
                // Adaptörümü tablo ile doldurdum
                dataAdapter.Fill(dataTable);		//$Exception	{"Problem"}	System.Exception

                // Formda olan datagridview componentime veri tablomu ekledim
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                throw new Exception("Problem");
            }


        }

        protected void Page_Load(object sender, EventArgs e)

        {


        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }







        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

           


            /*{
                string aranan = textBox1.Text.Trim().ToUpper();
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                        {
                            if (cell.Value != null)
                            {
                                if (cell.Value.ToString().ToUpper() == aranan)
                                {
                                    cell.Style.BackColor = Color.DarkTurquoise;
                                    break;
                                }
                            }
                        }
                    }
                }
            }*/
        

        private void btnBack2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
          
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {

            
        }
      



        /*  private void hide()
          {

          }*/
    }
}


