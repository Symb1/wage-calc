using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.workHours.Text = "";
            this.workWageH.Text = "";
            this.result.Text = "";
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = Convert.ToDouble(this.workWageH.Text) * Convert.ToDouble(this.workHours.Text);
            result.Text = total.ToString();
        }
    }
}
