using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StoreApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("Server = localhost; Database=stock_tracking_system;username=root;password='';");
        MySqlCommand command;

        private void Form4_Load(object sender, EventArgs e)
        {
            populateDGV4();
        }

public void populateDGV4()
{
    string selectQuery = "Select * FROM product";
    DataTable table = new DataTable();
    MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
    adapter.Fill(table);
    dataGridView1_product.DataSource = table;
}

private void button2_Click(object sender, EventArgs e) {
            
           
          string insertQuery = "INSERT INTO product(Barcode_number,Product_name,Number,Category,Company_name,Buying_price,Sale_price) " +
          "VALUES(  '" + textBoxBarcode4.Text + "'  ,  '" + textBoxProduct4.Text + "'  ,  '" + textBoxNumber4.Text + "',  '" + textBoxCategory4.Text + "',   '" + textBoxCompany4.Text + "'  , '" + textBoxBuy4.Text + "'  ,  '" + textBoxSale4.Text + "'  ) ";


           
            executeMyQuery(insertQuery);

            populateDGV4();


   
        }

        private void button3_Click(object sender, EventArgs e)
{

            string deleteQuery = "DELETE FROM product WHERE id=" + textBoxId4.Text;
            executeMyQuery(deleteQuery);
            populateDGV4();

   



        }

        /* public MySqlConnection mysqlconnect = new MySqlConnection("Server=localhost;Database=stock_tracking_system;username=root;password='';");

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

        }*/
        /*private void Form4_Load(object sender, EventArgs e)
        {

            
           if (DatabseConnectControl())
            {
                // Mysql adaptörümü oluşturup komut gönderdim
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM product", mysqlconnect);

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
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_product_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxId4.Text = dataGridView1_product.CurrentRow.Cells[0].Value.ToString();
            textBoxBarcode4.Text =  dataGridView1_product.CurrentRow.Cells[1].Value.ToString();
            textBoxProduct4.Text = dataGridView1_product.CurrentRow.Cells[2].Value.ToString();
            textBoxNumber4.Text = dataGridView1_product.CurrentRow.Cells[3].Value.ToString();
            textBoxCategory4.Text =   dataGridView1_product.CurrentRow.Cells[4].Value.ToString();
            textBoxCompany4.Text =  dataGridView1_product.CurrentRow.Cells[5].Value.ToString();
            textBoxBuy4.Text =   dataGridView1_product.CurrentRow.Cells[6].Value.ToString();
            textBoxSale4.Text =   dataGridView1_product.CurrentRow.Cells[7].Value.ToString();

        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {

            try
            {
                openConnection();

                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query executed");
                }
                else
                {
                    MessageBox.Show("Query not executed");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }


        }

        private void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void btnSearchit4_Click(object sender, EventArgs e) 
        {
            openConnection();
            MySqlDataReader mdr;
            string select = "SELECT * FROM product WHERE Id=" + Int32.Parse(textBoxId4.Text);
            command = new MySqlCommand(select, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {

                textBoxBarcode4.Text = mdr.GetString("Barcode_number");
                textBoxProduct4.Text = mdr.GetString("Product_name");
                textBoxNumber4.Text = mdr.GetString("Number");
                textBoxCategory4.Text = mdr.GetString("Category");
                textBoxCompany4.Text = mdr.GetString("Company_name");
                textBoxBuy4.Text = mdr.GetString("Buying_price");
                textBoxSale4.Text = mdr.GetString("Sale_price");
            }
       
            else
            {
                MessageBox.Show("User not found!");
            }
            closeConnection();
        }

        private void btnUpdate4_Click(object sender, EventArgs e)
        {
            string updateQuery= "UPDATE product SET Barcode_number='"+textBoxBarcode4.Text+
                "',Product_name='"+textBoxProduct4.Text+"',Number='"+textBoxNumber4.Text+"',Category='"+textBoxCategory4.Text+
                "',Company_name='"+textBoxCompany4.Text+"',Buying_price='"+textBoxBuy4.Text+"',Sale_price='"+textBoxSale4.Text+
                "' WHERE id = " + int.Parse(textBoxId4.Text);

            executeMyQuery(updateQuery);
            populateDGV4();
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
