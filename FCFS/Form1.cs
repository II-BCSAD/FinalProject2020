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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;

            if (panel1.Width >= 483)
            {
                fcfsForm frm = new fcfsForm();
                timer1.Stop();
                this.Hide();
                frm.Show();
            }

        }
        public void exit()
        {
            this.Dispose();
            this.Close();
            Environment.Exit(1);
            //System.Windows.Forms.Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
