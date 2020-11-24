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
    public partial class fcfsForm : Form
    {
        public fcfsForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            DataTable ss = new DataTable();
            ss.Columns.Add("PROCESS");
            ss.Columns.Add("ARRIVAL TIME (AT)");
            ss.Columns.Add("BURST TIME (BT)");
            ss.Columns.Add("WAITING TIME (WT)");
            ss.Columns.Add("TURN-AROUND TIME");
            ss.Columns.Add("COMPLETION TIME");

            DataRow row = ss.NewRow();
            row["PROCESS"] = inProcess.Text;
            row["ARRIVAL TIME (AT)"] = inAT.Text;
            row["BURST TIME (BT)"] = inBT.Text;

            ss.Rows.Add(row);
            foreach (DataRow Drow in ss.Rows)
            {
                int num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = Drow["PROCESS"].ToString();
                dataGridView1.Rows[num].Cells[1].Value = Drow["ARRIVAL TIME (AT)"].ToString();
                dataGridView1.Rows[num].Cells[2].Value = Drow["BURST TIME (BT)"].ToString();
            }
        }
    }
}
