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
    public partial class Main_form : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-O2B3KN9; Initial Catalog=Bank; Integrated Security=True");

        public Main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void Enter_bnt_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlDataAdapter command = new SqlDataAdapter("SELECT count (*) FROM [dbo].[enter] WHERE admin = '" + Login.Text + "' AND [password] = '" + pass_word.Text + "'", con1);
            command.Fill(table);
            //if (table.Rows[0][0].ToString() == "1")
            if (table.Rows.Count > 0)
            {
                if (Login.Text == "user")
                {
                    this.Hide();
                    Bank mainFrom = new Bank();
                    mainFrom.Show();
                }
               
            }
            else
                MessageBox.Show("Логин или пароль введён неправильно.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
