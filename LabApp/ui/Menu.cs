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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Workers f1 = new Workers();
            f1.ShowDialog();
            this.Close();
        }

        private void organizationsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Organizations f2 = new Organizations();
            f2.ShowDialog();
            this.Close();
        }

        private void documentationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Documents f3 = new Documents();
            f3.ShowDialog();
            this.Close();
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tasks f4 = new Tasks();
            f4.ShowDialog();
            this.Close();
        }

        private void consoleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Queries f5 = new Queries();
            f5.ShowDialog();
            this.Close();
        }
    }
}
