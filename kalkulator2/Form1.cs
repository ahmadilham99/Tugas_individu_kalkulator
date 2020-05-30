using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator2
{
    public partial class Form1 : Form
    {
        public bool ishasilClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void operandClick(object sender, EventArgs e)
        {
            if (ishasilClicked == true)
            {
                layar.Text = "";
                ishasilClicked = false;
            }
            Button operand = (Button)sender;
            layar.Text = layar.Text + operand.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            if (ishasilClicked == true)
            {
                layar.Text = "";
                ishasilClicked = false;
            }
            Button operators = (Button)sender;
            layar.Text = layar.Text + operators.Text;
        }

        private void deleteBtn(object sender, EventArgs e)
        {
            String hasil = layar.Text;
            if (hasil.Length > 0)
                layar.Text = hasil.Substring(0, hasil.Length - 1);
            else
                layar.Text = "0";
        }

        private void hasilBtn(object sender, EventArgs e)
        {
            ishasilClicked = true;
            DataTable table = new DataTable();
            string ekspresi = layar.Text;
            double hasil = Convert.ToDouble(table.Compute(ekspresi, string.Empty));
            layar.Text = (hasil).ToString();
        }

        private void persenClick(object sender, EventArgs e)
        {
          
        }

        private void clearBtn(object sender, EventArgs e)
        {
            ishasilClicked = true;
            layar.Text = "0";
        }
    }
}
