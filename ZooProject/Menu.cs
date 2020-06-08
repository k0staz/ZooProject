using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooProject
{
    public partial class Menu : Form
    {
        public Menu(int type, int id_rec, Form1 par)
        {
            InitializeComponent();
            parent = par;
            id = id_rec;
            user_type = type;
        }
        Form1 parent;
        int id;
        int user_type;

        private void label4_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void animal_click(object sender, EventArgs e)
        {
            animal win = new animal(this, user_type);
            win.Show();
            this.Visible = false;
        }

        private void map_Click(object sender, EventArgs e)
        {
            map win = new map(this);
            win.Show();
            this.Hide();
        }

        private void excurtion_Click(object sender, EventArgs e)
        {
            excursion win = new excursion(this, id, user_type);
            win.Show();
            this.Visible = false;
        }

        private void tickets_Click(object sender, EventArgs e)
        {
            Tickets win = new Tickets(this, id, user_type);
            win.Show();
            this.Hide();
        }

        private void left_MouseLeave(object sender, EventArgs e)
        {
            Label text = sender as Label;
            text.BackColor = Color.FromArgb(252, 200, 66);
        }

        private void left_MouseMove(object sender, MouseEventArgs e)
        {
            Label text = sender as Label;
            text.BackColor = Color.FromArgb(255, 124, 0);
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            Label text = sender as Label;
            text.BorderStyle = BorderStyle.None;
            text.BackColor = Color.FromArgb(252, 200, 66);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            Label text = sender as Label;
            text.BorderStyle = BorderStyle.Fixed3D;
            
        }

        private void BG2_MouseLeave(object sender, EventArgs e)
        {
            Label square = sender as Label;
            square.BackColor = Color.FromArgb(255, 183, 115);
        }

        private void BG2_MouseMove(object sender, MouseEventArgs e)
        {
            Label square = sender as Label;
            square.BackColor = Color.FromArgb(255, 157, 64);
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
