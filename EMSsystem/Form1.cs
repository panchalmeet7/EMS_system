using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace EMSsystem

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // instead of using connection in every function we just call it in top

        // SqlConnection con = new SqlConnection("Data Source=DESKTOP-EVP7VR3;Initial Catalog=EMSdatabase;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmployeeRecord();
        }

        private void GetEmployeeRecord()
        {


         // establishing connection with database 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EVP7VR3;Initial Catalog=EMSdatabase;Integrated Security=True");


            // writing the "select all" sql command and passing the connection object 
            SqlCommand cmd = new SqlCommand("select * from EmployeeTb", con);

            // creating a data table 
            DataTable dt = new DataTable();

            // opening a connection
            con.Open();

            // it will read the all the data that comes 
            SqlDataReader sdr = cmd.ExecuteReader();

            // load the data
            dt.Load(sdr);

            con.Close();

            // pass the data table with data source
            EmployeedataGridView.DataSource = dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (IsValid())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-EVP7VR3;Initial Catalog=EMSdatabase;Integrated Security=True");

                // writing command to insert data into the table
                SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeTb Values(@name, @technology, @address, @mobilenumber) ", con);
                cmd.CommandType = CommandType.Text;

                // name value will come from text box 
                cmd.Parameters.AddWithValue("@name",txtemployeename.Text);
                cmd.Parameters.AddWithValue("@technology", txtemployeetech.Text);
                cmd.Parameters.AddWithValue("@address", txtemployeeaddress.Text);
                cmd.Parameters.AddWithValue("@mobilenumber", textemployeemonumber.Text);

                con.Open();
                // cmd.ExecuteNonQuery();
                con.Close();

                // show the popup 
                MessageBox.Show("Registeration successful!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEmployeeRecord();
            }

            

        }
        private bool IsValid()
        { 
                if (txtemployeename.Text == String.Empty)
                {
                    // pop up box showing the below msg 
                    MessageBox.Show("Name should not be empty!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            return true;

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}