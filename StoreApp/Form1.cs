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
    public partial class Form1 : Form
    {
      // Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        Form4 frm4 = new Form4();
        Form5 frm5 = new Form5();
        Form6 frm6 = new Form6();

        Thread th;

       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void opennewform(object obj)
        {
            //throw new NotImplementedException();
            Application.Run(new Form3());
            
        }

        private void hide()
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

        private void Form1_Load(object sender, EventArgs e)
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
                dataGridView.DataSource = dataTable;
            }
            else
            {
                throw new Exception("Problem");
            }


        }

      
     
        
            private void button5_Click(object sender, EventArgs e)
        
            {
                this.Close();
                th = new Thread(opennewform9);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }

            private void opennewform9(object obj)
            {
                //throw new NotImplementedException();
                Application.Run(new Form9());

            }

            private void button7_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void opennewform4(object obj)
        {
            //throw new NotImplementedException();
            Application.Run(new Form4());

        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
