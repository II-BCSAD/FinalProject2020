using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFS
{
    public partial class SolutionForm : Form
    {
        public SolutionForm()
        {
            InitializeComponent();
        }

        public void compute(string[] processes, int n, int[] bt, int[] at)
        {
            /*
            // sample display of arrays, pwde idelete pati ung 3 labels na nasa SolutionForm.cs[Design]
            groupBox_SF1.Text = processes.Aggregate((a, b) => a + " " + b);
            label2.Text = bt.Select(x => x.ToString()).Aggregate((a, b) => a + " " + b);
            SF_CAWT.Text = at.Select(x => x.ToString()).Aggregate((a, b) => a + " " + b);
            */ 
            //pwede na yata idelete to -vane


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SolutionForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
