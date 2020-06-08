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
    public partial class animal_create : Form
    {
        public animal_create(animal par)
        {
            InitializeComponent();
            parent = par;
            Food_label.Text = Food.Value.ToString();
            fill_facility();
        }
        animal parent;
        static MySqlConnection connection = new MySqlConnection("Server=207.154.220.247;UserId=popovka;Password=tqh3t4wxmsgqjq3k;Database=popovka_db");

        private void fill_facility()
        {
            connection.Open();
            MySqlDataAdapter facilit = new MySqlDataAdapter("select * from popovka_db.Facility", connection);

            DataSet data_facili = new DataSet();

            facilit.Fill(data_facili);

            Facility.DataSource = data_facili.Tables[0];
            Facility.DisplayMember = "Name";
            connection.Close();

            DataRow all = data_facili.Tables[0].NewRow();
            all["Name"] = "Choose";
            data_facili.Tables[0].Rows.Add(all);
            Facility.SelectedIndex = data_facili.Tables[0].Rows.Count - 1;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void Food_ValueChanged(object sender, EventArgs e)
        {
            Food_label.Text = Food.Value.ToString();
        }

        private int whichfacility()
        {
            MySqlCommand command = new MySqlCommand("select ID_facility from popovka_db.Facility where Name='" + Facility.Text + "'", connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int facil = Int32.Parse(reader[0].ToString());
            connection.Close();
            return facil;
        }

        private void update_facili()
        {
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from popovka_db.animal left join Facility on(animal.Facility = Facility.ID_facility) where Facility.Name = '"+Facility.Text+"'", connection);
            DataSet set = new DataSet();
            adapter.Fill(set);

            MySqlCommand command = new MySqlCommand("update popovka_db.Facility set Amount=" + set.Tables[0].Rows.Count+" where Name='"+Facility.Text+"'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                string insert_str = "insert into animal(Species, Family, Food_per_day, Location, Facility) " +
                "values('" + Species.Text + "', '" + Family.Text + "'," + Food_label.Text + ", '" + Location.Text + "'," + whichfacility() + ")";
                MySqlCommand insert = new MySqlCommand(insert_str, connection);
                connection.Open();
                insert.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Животное добавлено!");
                parent.fill_grid();
                update_facili();
            }
            catch
            {
                connection.Close();
                MessageBox.Show("Что-то пошло не так" + Environment.NewLine+ "Скорее всего вы где-то ошиблись", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void animal_create_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
