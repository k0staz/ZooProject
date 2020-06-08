using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft;
using MySql.Data.MySqlClient;

namespace ZooProject
{
    public partial class ExportForm : Form
    {
        public ExportForm(Tickets par)
        {
            InitializeComponent();
            parent = par;
            load_data();
        }
        Tickets parent;

        private void load_data()
        {
            MySqlConnection connection = new MySqlConnection("Server=207.154.220.247;UserId=popovka;Password=tqh3t4wxmsgqjq3k;Database=popovka_db");
            connection.Open();
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from popovka_db.ticket", connection);
            DataSet set = new DataSet();
            ad.Fill(set);
            BindingSource bs = new BindingSource(set, set.Tables[0].TableName);
            dataGridView1.DataSource = bs;
            connection.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void ExportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }   

        private void Export_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    
    }
}
