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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm(Form1 par)
        {
            InitializeComponent();
            parent = par;
            fill();
        }
        Form1 parent;
        static MySqlConnection connection = new MySqlConnection("Server=207.154.220.247;UserId=popovka;Password=tqh3t4wxmsgqjq3k;Database=popovka_db");

        private void fill()
        {
            connection.Open();
            MySqlDataAdapter types = new MySqlDataAdapter("select * from popovka_db.user_type", connection);
            MySqlDataAdapter facilit = new MySqlDataAdapter("select * from popovka_db.Facility", connection);

            DataSet data_types = new DataSet();
            DataSet data_facili = new DataSet();

            types.Fill(data_types);
            facilit.Fill(data_facili);

            UserType.DataSource = data_types.Tables[0];
            UserType.DisplayMember = "name";
            data_facili.Tables[0].Rows.Add();
            Facility.DataSource = data_facili.Tables[0];
            Facility.DisplayMember = "Name";
            connection.Close();
        }

        private void invisibility()
        {
            PassportData.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            Facility.Visible = false;
        }

        private void visibility()
        {
            PassportData.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            Facility.Visible = true;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox current = sender as ComboBox;
            if (current.Text == "user") invisibility();
            else visibility();
        }

        private string whichtype()
        {
            MySqlCommand command = new MySqlCommand("select type from popovka_db.user_type where name='"+UserType.Text+"'", connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string type = reader[0].ToString();
            connection.Close();
            return type;
        }

        private bool logincheck()
        {
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select Login from popovka_db.user", connection);
            DataSet set = new DataSet();
            adapter.Fill(set);
            connection.Close();
            BindingSource bs = new BindingSource(set, set.Tables[0].TableName);
            if (bs.Find("Login", Login.Text) == -1) return true;
            else return false;
        }
        private string whichfacility()
        {
            MySqlCommand command = new MySqlCommand("select ID_facility from popovka_db.Facility where Name='" + Facility.Text + "'", connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string facil = reader[0].ToString();
            connection.Close();
            return facil;
        }

        private string user_id()
        {
            MySqlCommand command = new MySqlCommand("select ID_user from popovka_db.user where Login='" + Login.Text + "'", connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string id = reader.GetString(0);
            connection.Close();
            return id;
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            bool correct = false;
            if (logincheck())
            {
                try
                {
                    string com = "insert into popovka_db.user(login, password, type) values('" + Login.Text + "','"
                    + Password.Text + "','" + whichtype() + "')";
                    MySqlCommand command = new MySqlCommand(com, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    correct = true;
                }
                catch
                {
                    MessageBox.Show("Что-то не так с логином или паролем!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    connection.Close();
                    correct = false;
                }
            }
            else MessageBox.Show("Такой логин уже используется!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (correct)
            {
                try
                {
                    if (whichtype() == "2")
                    {
                        string usercom = "insert into popovka_db.client(FirstName, SecondName, LastName, Phone, ID_user) values('" + FirstName.Text + "','" +
                            SecondName.Text +"','" + LastName.Text + "','" + Telephon.Text + "','" + user_id() + "')";
                        MySqlCommand userCommand = new MySqlCommand(usercom, connection);
                        connection.Open();
                        userCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                    else
                    {
                        string usercom;

                        if (Facility.Text == "") usercom = "insert into popovka_db.employee(FirstName, SecondName, LastName,Phone, Passport_data, ID_user) values('" + FirstName.Text + "','" +
                          SecondName.Text + "','" + LastName.Text + "','" + Telephon.Text + "','" + PassportData.Text + "','" + user_id() + "')";
                        else usercom = "insert into popovka_db.employee(FirstName, SecondName, LastName, Phone, Passport_data, Facility, ID_user) values('" + FirstName.Text + "','" +
                          SecondName.Text + "','" + LastName.Text + "','" + Telephon.Text + "','" + PassportData.Text + "','" + whichfacility() + "','" + user_id() + "')";

                        MySqlCommand userCommand = new MySqlCommand(usercom, connection);
                        connection.Open();
                        userCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Поздравляю, вы зарегестрированы!");
                    parent.Visible = true;
                    this.Close();
                }

                catch
                {
                    MySqlCommand del_com = new MySqlCommand("delete from popovka_db.user where login ='" + Login.Text + "'", connection);
                    del_com.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Вы где-то совершили ошибку!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
