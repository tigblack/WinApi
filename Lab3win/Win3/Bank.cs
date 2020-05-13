using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Win3
{
    public partial class Bank : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-O2B3KN9; Initial Catalog=Bank; Integrated Security=True");

        public Bank()
        {
            InitializeComponent();
        }


        private void Bank_Load(object sender, EventArgs e)
        {
            con1.Open();
            load_data();
           

        }

        void clear_fun()
        {
            name_txt.Text = "";
            sur_txt.Text = "";
            sal_txt.Text = "";
            ex_txt.Text = "";
            con_int.Text = "";
           
        }
        void load_data()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client  ", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            name_txt.Enabled = false;

            int cri = dataGridView1.CurrentCell.RowIndex;
            name_txt.Text = dataGridView1.Rows[cri].Cells[0].Value.ToString();
            sur_txt.Text = dataGridView1.Rows[cri].Cells[1].Value.ToString();
            sal_txt.Text = dataGridView1.Rows[cri].Cells[2].Value.ToString();
            ex_txt.Text = dataGridView1.Rows[cri].Cells[3].Value.ToString();
            con_int.Text = dataGridView1.Rows[cri].Cells[4].Value.ToString();



        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Client(Name, Surname,  Salary, Expences, Contribution )values( '" + name_txt.Text + "', '" + sur_txt.Text + "', '" + sal_txt.Text + "', '" + ex_txt.Text + "', '" +con_int.Text + "'  )", con1);
            cmd.ExecuteNonQuery();
            load_data();
            clear_fun();
            MessageBox.Show("saved");
        }

        private void del_bnt_Click(object sender, EventArgs e)
        {
            SqlCommand del_cmd = new SqlCommand("DELETE FROM Client WHERE Name= '" + name_txt.Text + "'", con1);
            del_cmd.ExecuteNonQuery();
            load_data();
            clear_fun();
        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Client SET Name= '" + name_txt.Text + "', Surname= '" + sur_txt.Text + "', Salary= '" + sal_txt.Text + "', Expences= '" + ex_txt.Text + "',  Contribution=  '" + con_int.Text + "'   ", con1);
            cmd.ExecuteNonQuery();
            load_data();
            clear_fun();
            MessageBox.Show("update");
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            name_txt.Enabled = true;

            clear_fun();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE " + op_cmb.Text + " LIKE '%" + key_txt.Text + "%' ", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
        }

        private void Bank_Load_1(object sender, EventArgs e)
        {
            con1.Open();
            load_data();
        }
    }
}
