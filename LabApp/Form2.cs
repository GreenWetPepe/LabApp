using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            TableLV.View = View.Details;
            SQLDatabase.SetStatusHandler(OutDBState);
            SQLDatabase.SetQueryHandler(OutDBQuery);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = (idTB.Text == null) ? "NULL" : idTB.Text;
            string abbreviation = (abbreviationTB.Text == null) ? "NULL" : abbreviationTB.Text;
            string fullTitle = (fullTitleTB.Text == null) ? "NULL" : fullTitleTB.Text;
            string address = (addressTB.Text == null) ? "NULL" : addressTB.Text;
            string phone = (phoneTB.Text == null) ? "NULL" : phoneTB.Text;
            string bossFullName = (bossFullNameTB.Text == null) ? "NULL" : bossFullNameTB.Text;
            SQLDatabase.ExecuteCommand($"INSERT INTO organizations(id,abbreviation,full_title,address,phone,boss_full_name) VALUES ({id},'{abbreviation}','{fullTitle}','{address}','{phone}','{bossFullName}');");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SQLDatabase.ExecuteCommand("SELECT * FROM organizations;");
        }

        private void OutDBState(string message) => statusLabel.Text = message;

        private void OutDBQuery(MySqlDataReader reader)
        {
            TableLV.Columns.Clear();
            TableLV.Items.Clear();
            DataTable schemaTable = reader.GetSchemaTable();
            foreach (DataRow col in schemaTable.Rows)
            {
                TableLV.Columns.Add(col.Field<String>("ColumnName"));
                /*Console.WriteLine(col.Field<String>("ColumnName"));*/
            }
            while (reader.Read())
            {
                string[] row = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader.GetString(i);
                /*for (int i = 0; i < reader.FieldCount; i++) Console.WriteLine(row[i]);*/
                ListViewItem listViewItem = new ListViewItem(row);
                TableLV.Items.Add(listViewItem);
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.ShowDialog();
            this.Close();
        }
    }
}
