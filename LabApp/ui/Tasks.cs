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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
            TableLV.View = View.Details;
            SQLDatabase.SetStatusHandler(OutDBState);
            SQLDatabase.SetQueryHandler(OutDBQuery);
        }

        private void task11Button_Click(object sender, EventArgs e)
        {
            SQLDatabase.ExecuteCommand("CALL Task11");
        }
        private void task16Button_Click(object sender, EventArgs e)
        {
            SQLDatabase.ExecuteCommand($"CALL Task16('{dateTB.Text}')");
        }
        private void task26Button_Click(object sender, EventArgs e)
        {
            SQLDatabase.ExecuteCommand($"CALL Task41('{numTB.Text}');");
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
