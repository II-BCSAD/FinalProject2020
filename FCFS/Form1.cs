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
        public static int at, bt,nRow = 0;
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

            //input validation
            int count = 0;
            if(!int.TryParse(inAT.Text, out at))
            {
                count = 1;              
            }
            if (!int.TryParse(inBT.Text, out bt))
            {
                if (count == 0)
                {
                    count = 3;
                }
                else { count += 1; }
            }
            if (count == 2)
            {
                MessageBox.Show("Invalid Input for Arrival Time and Burst Time. Please Try Again", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearTxts();
                row.Delete();
            }
            else if (count == 1)
            {
                MessageBox.Show("Invalid Input for Arrival Time. Please Try Again", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearTxts();
                row.Delete();
            }
            else if (count == 3)
            {
                MessageBox.Show("Invalid Input for Burst Time. Please Try Again", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearTxts();
                row.Delete();
            }
            else {
                row["PROCESS"] = inProcess.Text;
                row["ARRIVAL TIME (AT)"] = inAT.Text;
                row["BURST TIME (BT)"] = inBT.Text;
                grpQueue.Enabled = false;

                ss.Rows.Add(row);
                foreach (DataRow Drow in ss.Rows)
                {
                    int num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = Drow["PROCESS"].ToString();
                    dataGridView1.Rows[num].Cells[1].Value = Drow["ARRIVAL TIME (AT)"].ToString();
                    dataGridView1.Rows[num].Cells[2].Value = Drow["BURST TIME (BT)"].ToString();
                }
                clearTxts();
                nRow += 1;
            }

            if (nRow == 0)
            {
                grpQueue.Enabled = true;
                rbSingle.Checked = false;
                rbMultiple.Checked = false;
                nRow = 0;
            }
                 
        }
        private void clearTxts()
        {
            inProcess.Text = "";
            inAT.Text = "";
            inBT.Text = "";
            
        }
        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            inProcess.Clear();
            inAT.Clear();
            inBT.Clear();
            
        }

        private void delete()
        {
            if(MessageBox.Show("Are you sure you want to delete this row?", "DELETE",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(index);
                if (dataGridView1.Rows.Count == 1)
                {
                    grpQueue.Enabled = true;
                    rbSingle.Checked = false;
                    rbMultiple.Checked = false;
                    nRow = 0;
                }
            }
            
            
        }
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            delete();
            
        }

    }
}
