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
    public partial class excursion : Form
    {
        public excursion(Menu par, int id, int type)
        {
            InitializeComponent();
            parent = par;
            user_id = id;
            fill_facil(type);
            
        }
        Menu parent;
        static MySqlConnection connection = new MySqlConnection("Server=207.154.220.247;UserId=popovka;Password=tqh3t4wxmsgqjq3k;Database=popovka_db");
        int user_id;

        private void fill_facil(int type)
        {
            connection.Open();
            MySqlDataAdapter facilit = new MySqlDataAdapter("select Name from popovka_db.Facility", connection);

            DataSet data_facili = new DataSet();

            facilit.Fill(data_facili);
            connection.Close(); 

            DataRow all = data_facili.Tables[0].NewRow();
            all["Name"] = "Choose";
            data_facili.Tables[0].Rows.Add(all);

            Facility.DataSource = data_facili.Tables[0];
            Facility.DisplayMember = "Name";
            Facility.SelectedIndex = data_facili.Tables[0].Rows.Count - 1;

            if(type == 1) Registration.Hide();
        }
        
        private void fill_empl()
        {
            MySqlDataAdapter empl = new MySqlDataAdapter("select employee.LastName as 'Name', Facility.Name as 'Facility' from employee " +
                "right join excursion on (employee.ID_employee = excursion.Employee) " +
                "left join Facility on (employee.Facility = Facility.ID_facility) where Facility.Name='" + Facility.Text + "'", connection);
            connection.Open();
            

            DataSet data_empl = new DataSet();

            empl.Fill(data_empl);
            connection.Close();

            Employee.DataSource = data_empl.Tables[0];
            Employee.DisplayMember = "Name";
        }

        private void fill_date()
        {
            MySqlDataAdapter date = new MySqlDataAdapter("select excursion.Date, employee.LastName as 'Employee', Facility.Name as 'Facility' from excursion  " +
                "left join employee on (excursion.Employee = employee.ID_employee) " +
                "left join Facility on (excursion.Facility = Facility.ID_facility) " +
                "where Facility.Name ='" + Facility.Text + "'" +
                "and (employee.LastName + employee.SecondName + employee.FirstName)='" + Employee.Text + "'", connection);
            connection.Open();

            DataSet data_date = new DataSet();

            date.Fill(data_date);
            connection.Close();

            exc_date.DataSource = data_date.Tables[0];
            exc_date.DisplayMember = "Date";
        }

        private void Facility_SelectedValueChanged(object sender, EventArgs e)
        {
            fill_empl();
            fill_date();
        }

        private void Employee_SelectedValueChanged(object sender, EventArgs e)
        {
            fill_date();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Parse(exc_date.Text);
                string id_com = "select ID_excursion from popovka_db.excursion " +
                    "left join popovka_db.Facility on (excursion.Facility = Facility.ID_facility) " +
                    "left join popovka_db.employee on(excursion.Employee = employee.ID_employee)" +
                    "where Facility.Name = '"+Facility.Text+ "' and employee.LastName = '" + Employee.Text+"' and excursion.Date = '"+ date.ToString("yyyy-MM-dd") + "'";
                connection.Open();
                MySqlCommand id = new MySqlCommand(id_com, connection);
                MySqlDataReader reader = id.ExecuteReader();

                string com = "";

                while (reader.Read())
                {
                    com = "update popovka_db.client set Excursion ='" + reader.GetValue(0) + "'" +
                    "where ID_user =" + user_id;
                }
                
                MySqlCommand command = new MySqlCommand(com, connection);
                reader.Close();

                DialogResult result = MessageBox.Show("Вы уверены что хотите записаться на экскурсию в " + Facility.Text + "?", "Подтверждение", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string check_text = "select Excursion from popovka_db.client where ID_user=" + user_id;
                    MySqlCommand command_check = new MySqlCommand(check_text, connection);
                    MySqlDataReader check_read = command_check.ExecuteReader();
                    DialogResult result_check = DialogResult.Yes;
                    while (check_read.Read()) result_check = MessageBox.Show("Вы уже записаны на эксурсию, перезаписать?", "Подтверждение", MessageBoxButtons.YesNo);
                    check_read.Close();
                    if (result_check == DialogResult.Yes) command.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Вы успешно записались на экскурсию!");
            }
            catch
            {
                MessageBox.Show("Неудача."+Environment.NewLine+"Может быть вы не все выбрали?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                connection.Close();
            }
        }

        private void excursion_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
