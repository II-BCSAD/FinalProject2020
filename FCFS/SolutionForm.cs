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
            // sample display of arrays, pwde idelete pati ung 3 labels na nasa SolutionForm.cs[Design]
            label1.Text = processes.Aggregate((a, b) => a + " " + b);
            label2.Text = bt.Select(x => x.ToString()).Aggregate((a, b) => a + " " + b);
            label3.Text = at.Select(x => x.ToString()).Aggregate((a, b) => a + " " + b);

            


        }
    }
}
