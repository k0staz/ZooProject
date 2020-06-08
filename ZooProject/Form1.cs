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

namespace ZooProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static MySqlConnection connection = new MySqlConnection("Server=207.154.220.247;UserId=popovka;Password=tqh3t4wxmsgqjq3k;Database=popovka_db");

        private DataSet get_data()
        {
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from popovka_db.user", connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text != "" && PassBox.Text != "")
            {
                DataSet data = get_data();
                DataTable table = data.Tables[0];
                bool logged = false;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (LoginBox.Text == table.Rows[i][1].ToString() && PassBox.Text == table.Rows[i][2].ToString())
                    {
                        Menu win = new Menu(int.Parse(table.Rows[i][3].ToString()), int.Parse(table.Rows[i][0].ToString()), this);
                        win.Show();
                        this.Visible = false;
                        logged = true;
                    }
                }
                if(logged is false) MessageBox.Show("Данные не совпадают!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Данные не введены!","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm win = new RegistrationForm(this);
            win.Show();
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu win = new Menu(2, 1, this);
            win.Show();
            this.Visible = false;
        }
    }
}
