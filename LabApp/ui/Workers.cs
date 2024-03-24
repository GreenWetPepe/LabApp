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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
            TableLV.View = View.Details;
            SQLDatabase.SetStatusHandler(OutDBState);
            SQLDatabase.SetQueryHandler(OutDBQuery);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = (idTB.Text == null) ? "NULL": idTB.Text;
            string lastName = (lastNameTB.Text == null) ? "NULL" : lastNameTB.Text;
            string firstName = (firstNameTB.Text == null) ? "NULL" : firstNameTB.Text;
            string patronymics = (patronymicsTB.Text == null) ? "NULL" : patronymicsTB.Text;
            string jobTitle = (jobTitleTB.Text == null) ? "NULL" : jobTitleTB.Text;
            string employmentDate = (employmentDateTB.Text == null) ? "NULL" : employmentDateTB.Text;
            SQLDatabase.ExecuteCommand($"INSERT INTO employees(id,last_name,first_name,patronymic,job_title,employment_date) VALUES ({id},'{lastName}','{firstName}','{patronymics}','{jobTitle}','{employmentDate}');");
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

        private void button2_Click(object sender, EventArgs e)
        {
            SQLDatabase.ExecuteCommand("SELECT * FROM employees;");
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.ShowDialog();
            this.Close();
        }
    }
}
