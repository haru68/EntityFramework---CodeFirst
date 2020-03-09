using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.ParseExact(StartDate.Text, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);
            DateTime endDate = DateTime.ParseExact(EndDate.Text, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);

            DialogResult result = MessageBox.Show("yes or np", "caption", MessageBoxButtons.OKCancel);
            SavingAccountCalculator.CalculateTotalSaved(startDate, endDate);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
