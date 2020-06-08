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
    public partial class animal : Form
    {
        public animal(Menu par, int type)
        {
            InitializeComponent();
            parent = par;
            fill_grid();
            if (type == 2) Add_animal.Hide();
        }
        Menu parent;
        static MySqlConnection connection = new MySqlConnection("Server=207.154.220.247;UserId=popovka;Password=tqh3t4wxmsgqjq3k;Database=popovka_db");

        public void fill_grid()
        {
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select Species, Family, Location, Facility.Name as 'Facility' " +
                "from popovka_db.animal left join Facility on (animal.Facility = Facility.ID_facility)", connection);
            MySqlDataAdapter facilit = new MySqlDataAdapter("select * from popovka_db.Facility", connection);

            DataSet data_facili = new DataSet();
            DataSet data = new DataSet();

            adapter.Fill(data);
            facilit.Fill(data_facili);

            DataRow all = data_facili.Tables[0].NewRow();
            all["Name"] = "All";
            data_facili.Tables[0].Rows.Add(all);

            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            Facility.DataSource = data_facili.Tables[0];
            Facility.DisplayMember = "Name";
            Facility.SelectedIndex = data_facili.Tables[0].Rows.Count - 1;

            dataGridView1.DataSource = bs;
            connection.Close();
        }


        private void Search_Click(object sender, EventArgs e)
        {
            BindingSource bs = dataGridView1.DataSource as BindingSource;
            int position = bs.Find("Species", textBox1.Text);
            if (position > 0) bs.Position = position;
            else MessageBox.Show("У нас нет такого животного(");
        }

        private void Facility_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter;
            if (Facility.Text != "All")
            {
                connection.Open();
                adapter = new MySqlDataAdapter("select Species, Family, Location, Facility.Name as 'Facility' " +
                    "from popovka_db.animal right join Facility on (animal.Facility = Facility.ID_facility)" +
                    "where Facility.Name ='" + Facility.Text + "'", connection);
            }
            else
            {
                adapter = new MySqlDataAdapter("select Species, Family, Location, Facility.Name as 'Facility' " +
                "from popovka_db.animal right join Facility on (animal.Facility = Facility.ID_facility)", connection);
            }
            DataSet data = new DataSet();

            adapter.Fill(data);
            BindingSource bs = new BindingSource(data, data.Tables[0].TableName);
            dataGridView1.DataSource = bs;
            connection.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void add_click(object sender, EventArgs e)
        {
            animal_create win = new animal_create(this);
            this.Hide();
            win.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = dataGridView1.DataSource as BindingSource;
            bs.Position = bs.Find("Species", textBox1.Text);
        }

        private void animal_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
