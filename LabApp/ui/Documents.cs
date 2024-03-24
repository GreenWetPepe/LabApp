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
    public partial class Documents : Form
    {
        public Documents()
        {
            InitializeComponent();
            TableLV.View = View.Details;
            SQLDatabase.SetStatusHandler(OutDBState);
            SQLDatabase.SetQueryHandler(OutDBQuery);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dCode = (dCodeTB.Text == null) ? "NULL" : dCodeTB.Text;
            string id = (idTB.Text == null) ? "NULL" : idTB.Text;
            string registrationDate = (registrationDateTB.Text == null) ? "NULL" : registrationDateTB.Text;
            string summary = (summaryTB.Text == null) ? "NULL" : summaryTB.Text;
            string type = (typeTB.Text == null) ? "NULL" : typeTB.Text;
            string organizationId = (organizationIdTB.Text == null) ? "NULL" : organizationIdTB.Text;
            string employeeId = (employeeIdTB.Text == null) ? "NULL" : employeeIdTB.Text;
            SQLDatabase.ExecuteCommand($"INSERT INTO documentation(d_code,id,registration_date,summary,type,organization_id,employee_id) VALUES ({dCode},{id},'{registrationDate}','{summary}','{type}',{organizationId},{employeeId});");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLDatabase.ExecuteCommand("SELECT * FROM documentation;");
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
            Menu m = new Menu();
            m.ShowDialog();
            this.Close();
        }
    }
}
