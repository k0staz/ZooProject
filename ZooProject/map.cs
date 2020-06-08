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
    public partial class map : Form
    {
        public map(Menu par)
        {
            InitializeComponent();
            parent = par;
            earth.Parent = pictureBox1;
            
            air.Parent = pictureBox1;
            ocean.Parent = pictureBox1;
            cross.Parent = pictureBox1;
            pictureBox1.MouseMove += null;
            pictureBox1.MouseLeave += null;
            collect_info();
        }
        Menu parent;
        static MySqlConnection connection = new MySqlConnection("Server=207.154.220.247;UserId=popovka;Password=tqh3t4wxmsgqjq3k;Database=popovka_db");

        string earth_text;
        string ocean_text;
        string cross_text;
        string air_text;

        Label current = null;

        private void collect_info()
        {
            earth_text = "Корпус содержит огромное количество животных, проживающих на суше." + Environment.NewLine +
                "На данный момент в корпусе находится " + get_info("Amount", "Earth World") + " животных" + Environment.NewLine +
                "В корпусе так же имеется:" + Environment.NewLine +
                "Водоем: " + logic_int("Pool", "Earth World") + Environment.NewLine +
                "Подогрев: " + logic_int("Heating", "Earth World");
            ocean_text = "Этот корпус посвящен океану и его обитателям, которые поразят вас своим разнообразием." + Environment.NewLine +
                "На данный момент в корпусе находится " + get_info("Amount", "Ocean World") + " животных" + Environment.NewLine +
                "В корпусе так же имеется:" + Environment.NewLine +
                "Водоем: " + logic_int("Pool", "Ocean World") + Environment.NewLine +
                "Подогрев: " + logic_int("Heating", "Ocean World");
            air_text = "Здесь вы найдете разные виды птиц. К некоторым из которых можно прикоснуться." + Environment.NewLine +
                "На данный момент в корпусе находится " + get_info("Amount", "Sky World") + " животных" + Environment.NewLine +
                "В корпусе так же имеется:" + Environment.NewLine +
                "Водоем: " + logic_int("Pool", "Sky World") + Environment.NewLine +
                "Подогрев: " + logic_int("Heating", "Sky World");
            cross_text = "Животные разных видов и из разных мест обитания собраные здесь." + Environment.NewLine +
                " Лучший вариант для тех, кто хочет посмотреть все и сразу." + Environment.NewLine +
                "На данный момент в корпусе находится " + get_info("Amount", "Sky World") + " животных" + Environment.NewLine +
                "В корпусе так же имеется:" + Environment.NewLine +
                "Водоем: " + logic_int("Pool", "Sky World") + Environment.NewLine +
                "Подогрев: " + logic_int("Heating", "Sky World");

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private string get_info(string which, string name)
        {
            string com = "select " + which + " from popovka_db.Facility where Name='" + name + "'";
            MySqlCommand command = new MySqlCommand(com, connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();
            string answer = reader[0].ToString();
            connection.Close();
            return answer;
        }

        private string logic_int(string prop, string world)
        {
            if (Boolean.Parse(get_info(prop, world))) return "Да";
            else return "Нет";
        }

        private void generall_MouseLeave(object sender, EventArgs e)
        {
            current.Dispose();
            current = null;
        }

        private void generall_MouseMove(object sender, MouseEventArgs e)
        {
            if (current == null)
            {
                Label info = new Label();
                Label obj = sender as Label;
                if(obj.Name == "earth")
                {
                    info.Text = earth_text;
                }
                else if (obj.Name == "cross")
                {
                    info.Text = cross_text;
                }
                else if(obj.Name == "ocean")
                {
                    info.Text = ocean_text;
                }
                else
                {
                    info.Text = air_text;
                }

                info.Parent = pictureBox1;
                info.AutoSize = true;
                info.BackColor = Color.FromArgb(220, 35, 91, 121);
                info.ForeColor = Color.FromArgb(255, 193, 115);
                info.Font = new Font("Tahoma", 11);
                info.Location = e.Location;
                info.BringToFront();
                info.Show();
                current = info;
            }
        }

        private void map_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
