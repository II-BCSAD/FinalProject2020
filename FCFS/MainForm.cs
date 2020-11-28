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
        public static int rbcount = 0, rbSelect = 0;
        public static string rbm;
        public static int[] btArr = new int[5];
        public static int[] atArr = new int[5];
        public static string[] pArr = new string[5];

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
        private void checkRB()
        {          
            if (rbSingle.Checked == false && rbMultiple.Checked == false)
            {
                rbm = "• No selection for Queueing.\n";
                rbcount = 2;
            }
            else if(rbSingle.Checked == true || rbMultiple.Checked == true)
            {
                rbm = ""
;               rbcount = 0;
            }
        }

        private void selectRB()
        {
            if (nRow > 0)
            {
                if (rbSingle.Checked == true)
                {
                    rbSelect = 1;
                }
            }
            else
            {
                if (rbSingle.Checked == true)
                {
                    rbSelect = 2;
                }
            }
            if (rbMultiple.Checked == true)
            {
                rbSelect = 2;
            }
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            DataTable ss = new DataTable();
            ss.Columns.Add("PROCESS");
            ss.Columns.Add("ARRIVAL TIME (AT)");
            ss.Columns.Add("BURST TIME (BT)");
            ss.Columns.Add("WAITING TIME");
            ss.Columns.Add("TURN-AROUND TIME");
            ss.Columns.Add("COMPLETION TIME");


            DataRow row = ss.NewRow();

            //input validation
            int count = 0;
            string msg = "", btmsg="", atmsg="";
            selectRB();
            if (!int.TryParse(inAT.Text, out at))
            {
                if(rbSingle.Checked == true)
                {
                    if (nRow > 1)
                    {
                        count = 0;
                    }
                }
                else
                {
                    count = 1;
                    atmsg = "• Invalid input for Arrival Time field\n";
                }
                count = 1;
                atmsg = "• Invalid input for Arrival Time field\n";
                if (String.IsNullOrEmpty(inAT.Text))
                {
                    atmsg = "• The Arrival Time field is required.\n";
                }
            }
            if (!int.TryParse(inBT.Text, out bt))
            {
                    count = 2;
                    btmsg = "• Invalid input for Burst Time field.\n";
                if (String.IsNullOrEmpty(inBT.Text))
                {
                    btmsg = "• The Burst Time field is required.\n";
                }
            }
            if (String.IsNullOrEmpty(inProcess.Text))
            {
                count = 3;
                msg = "• The Process field is required.\n";
            }
            if (rbcount == 2)
            {
                if (!String.IsNullOrEmpty(inProcess.Text) && !String.IsNullOrEmpty(inAT.Text) && !String.IsNullOrEmpty(inBT.Text))
                {
                    count = 4;
                }
            }
            
            if (count == 2)
            {
                checkRB();
                MessageBox.Show("There were problem/s with the following field/s:\n" + rbm + msg + atmsg + btmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearTxts();
                row.Delete();
            }
            else if (count == 1)
            {
                checkRB();
                MessageBox.Show("There were problem/s with the following field/s:\n" + rbm + msg + atmsg + btmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearTxts();
                row.Delete();
            }
            else if (count == 3)
            {
                checkRB();
                MessageBox.Show("There were problem/s with the following field/s:\n" + rbm + msg + atmsg + btmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearTxts();
                row.Delete();
            }
            else if (count == 4)
            {
                checkRB();
                MessageBox.Show("There were problem/s with the following field/s:\n" + rbm + msg + atmsg + btmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearTxts();
                row.Delete();
            }
            else {
                selectRB();
                if (rbSelect == 1)
                {
                   
                    string atText = Convert.ToString(dataGridView1.Rows[0].Cells[1].Value);
                    inAT.Text = atText.ToString();
                    inAT.Enabled = false;
                    
                    //row["ARRIVAL TIME (AT)"] = dataGridView1.Rows[1].Cells[1].Value;
                    row["ARRIVAL TIME (AT)"] = inAT.Text;
                }
                else if (rbSelect == 2)
                {
                    row["ARRIVAL TIME (AT)"] = inAT.Text;
                }
                row["PROCESS"] = inProcess.Text;
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
                checkRows();

            }

            if (nRow == 0)
            {
                grpQueue.Enabled = true;
                rbSingle.Checked = false;
                rbMultiple.Checked = false;
                nRow = 0;
                inAT.Enabled = true;
                
            }
                 
        }
        
        private void checkRows()
        {
            if (nRow == 5)
            {
                inputPanel.Enabled = false;
            }
            else if (nRow < 5)
            {
                inputPanel.Enabled = true;
            }
        }
        private void clearTxts()
        {
            
            selectRB();
            if (rbSelect == 2) 
            {
                if (rbSingle.Checked == true)
                {
                    inProcess.Text = "";
                    inBT.Text = "";
                    inAT.Enabled = false;
                }

                else
                {
                    inProcess.Text = "";
                    inAT.Text = "";
                    inBT.Text = "";
                }
                
            }
            else if (rbSelect == 1)
            {
                inProcess.Text = "";
                inBT.Text = "";
            }
            
            
        }
        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            inProcess.Clear();
            inAT.Clear();
            inBT.Clear();
            
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            string[] pArray = dataGridView1.Rows
               .Cast<DataGridViewRow>()
               .Where(r => !r.IsNewRow)
               .Select(r =>(r.Cells[0].Value.ToString())).ToArray();

            for (int i = 0; i < 5; i++)
            {
                pArr[i] = pArray[i];
            }
            int[] atArray = dataGridView1.Rows
               .Cast<DataGridViewRow>()
               .Where(r => !r.IsNewRow)
               .Select(r => Convert.ToInt32(r.Cells[1].Value.ToString())).ToArray();

            for (int i = 0; i < 5; i++)
            {
                atArr[i] = atArray[i];
            }
            int[] btArray = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => Convert.ToInt32(r.Cells[2].Value.ToString())).ToArray();
            
            for (int i = 0; i <5; i++)
            {
                btArr[i] = btArray[i];
            }

            btnDELETE.Enabled = false;
           // label3.Text = pArr.Select(x => x.ToString()).Aggregate((a, b) => a + ", " + b);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            
            SolutionForm obj = new SolutionForm();
            obj.Show();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                    inAT.Enabled = true;
                    nRow = 0;
                }
                nRow -= 1;
            }
            
            
        }
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            delete();
            checkRows();
        }


    }
}
