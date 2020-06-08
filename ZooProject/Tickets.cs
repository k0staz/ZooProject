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
    public partial class Tickets : Form
    {
        public Tickets(Menu par, int id, int type)
        {
            InitializeComponent();
            parent = par;
            user_id = id;
            FinalSumm.Text = "0";
            if (type == 2) Export_button.Hide();
        }
        Menu parent;
        int user_id;
        static MySqlConnection connection = new MySqlConnection("Server=207.154.220.247;UserId=popovka;Password=tqh3t4wxmsgqjq3k;Database=popovka_db");

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void checkEarth_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            if (box.Checked) EarthLabel.Show();
            else EarthLabel.Hide();
            value_count();
        }

        private void checkOcean_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            if (box.Checked) OceanLabel.Show();
            else OceanLabel.Hide();
            value_count();
        }

        private void checkSky_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            if (box.Checked) SkyLabel.Show();
            else SkyLabel.Hide();
            value_count();
        }

        private void checkWorld_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            if (box.Checked) CrossLabel.Show();
            else CrossLabel.Hide();
            value_count();
        }

        private void value_count()
        {
            double summ = 0;
            if (checkEarth.Checked) summ += 150;
            if (checkOcean.Checked) summ += 150;
            if (checkSky.Checked) summ += 150;
            if (checkWorld.Checked) summ += 200;

            double mature = summ * int.Parse(numericMature.Value.ToString());
            double children = summ * 0.5 * int.Parse(numericChildren.Value.ToString());

            FinalSumm.Text = (mature + children).ToString();
        }
        private void Value_changed(object sender, EventArgs e)
        {
            value_count();
        }

        private void FinalSumm_Click(object sender, EventArgs e)
        {

        }

        private int transform(bool stat)
        {
            if (stat) return 1;
            else return 0;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateTimePicker1.Value, DateTime.Now);
            if (Int32.Parse(FinalSumm.Text) != 0 && DateTime.Compare(dateTimePicker1.Value, DateTime.Now) > 0)
            {
                string comm = "insert into popovka_db.ticket(user_id, Date, Cost, Earth, Sky, Ocean, Crossed) values('" +
                user_id + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + FinalSumm.Text + "','" + transform(checkEarth.Checked) + "','" +
                transform(checkSky.Checked) + "','" + transform(checkOcean.Checked) + "','" + transform(checkWorld.Checked) + "')";
                MySqlCommand command = new MySqlCommand(comm, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Покупка совершена.");
            }
            else if(DateTime.Compare(dateTimePicker1.Value, DateTime.Now) < 0) MessageBox.Show("Дата должна быть установлена не раньше сегодняшнего дня!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else MessageBox.Show("Вы еще ничего не выбрали!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Tickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {

        }

        private void Export_button_Click(object sender, EventArgs e)
        {
            ExportForm win = new ExportForm(this);
            this.Hide();
            win.Show();
        }
    }
}
