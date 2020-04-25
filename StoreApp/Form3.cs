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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        MySqlConnection connection = new MySqlConnection("Server = localhost; Database=stock_tracking_system;username=root;password='';");
        MySqlCommand command;
        private void Form3_Load(object sender, EventArgs e)
        {
            populateDGV();
            
        }

        public void populateDGV()
        {
            string selectQuery = "Select * FROM customers";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView_customers.DataSource = table;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string insertQuery = "INSERT INTO customers(Name,Surname,Identify_Number,Phone_Number,Adress,Mail) " +
                "VALUES( '"+txtName3.Text+"', '" + txtSurname3.Text + "', '" + txtId3.Text + "', '" + txtPhone3.Text + "', '" + txtAdress3.Text + "', '" + txtMail3.Text +"')";
            executeMyQuery(insertQuery);

            populateDGV();
        }

        private void dataGridView_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_customers_MouseClick(object sender, MouseEventArgs e)
        {
        
            textBoxId1.Text = dataGridView_customers.CurrentRow.Cells[0].Value.ToString();
            txtName3.Text = dataGridView_customers.CurrentRow.Cells[1].Value.ToString();
            txtSurname3.Text = dataGridView_customers.CurrentRow.Cells[2].Value.ToString();
            txtId3.Text = dataGridView_customers.CurrentRow.Cells[3].Value.ToString();
            txtPhone3.Text = dataGridView_customers.CurrentRow.Cells[4].Value.ToString();
            txtAdress3.Text = dataGridView_customers.CurrentRow.Cells[5].Value.ToString();
            txtMail3.Text = dataGridView_customers.CurrentRow.Cells[6].Value.ToString();

        }

        public void closeConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {

            try{
                openConnection();

                command = new MySqlCommand(query, connection);

                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query executed");
                }
                else
                {
                    MessageBox.Show("Query not executed");

                }
            }

            catch(Exception ex)
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
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void txtName3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM customers WHERE id="+ textBoxId1.Text;

            executeMyQuery(deleteQuery);

            populateDGV();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE customers SET Name='"+txtName3.Text+
                "',Surname='"+txtSurname3.Text+"',Identify_Number='"+ txtId3.Text+
                "',Phone_Number='"+txtPhone3.Text+"',Adress='"+txtAdress3.Text+
                "',Mail='"+txtMail3.Text+"' WHERE id =" + int.Parse(textBoxId1.Text);


            executeMyQuery(updateQuery);
            populateDGV();
        }

        private void button3_Click(object sender, EventArgs e)

        {
            openConnection();
            MySqlDataReader mdr;
            string select = "SELECT * FROM customers WHERE id="+Int32.Parse(textBoxId1.Text);
            command = new MySqlCommand(select,connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                txtName3.Text = mdr.GetString("Name");
                txtSurname3.Text = mdr.GetString("Surname");
                txtId3.Text = mdr.GetString("Identify_Number");
                txtPhone3.Text = mdr.GetString("Phone_Number");
                txtAdress3.Text = mdr.GetString("Adress");
                txtMail3.Text = mdr.GetString("Mail");
            }
            else
            {
                MessageBox.Show("User not found!");
            }
            closeConnection();   }

        private void textBoxId1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack3_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
