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
        public static int at, bt,nRow = 0,  count = 0, timer = 0, timeSt=0, secs = 0;
        public static int rbcount = 0, rbSelect = 0;
        public static string rbm;
        public static int[] btArr = new int[5];
        public static int[] atArr = new int[5];
        public static string[] pArr = new string[5];
        public static int[] bt1 = new int[5];
        public static int[] at1 = new int[5];
        public static string[] p1 = new string[5];
        public static int[] finalBT = new int[5];
        public static int[] finalAT = new int[5];
        public static string[] finalProcess = new string[5];
        public static int[] finalWT = new int[5];
        public static int[] finalTAT = new int[5];
        public static int[] finalCT = new int[5];


        public fcfsForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //Exit button
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

        public void selectRB()
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
           
            string msg = "", btmsg="", atmsg="";
            selectRB();
            if (!int.TryParse(inAT.Text, out at))
            {
                if(rbSingle.Checked)
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
                checkRows();
                if (rbSelect == 1)
                {
                   
                    string atText = Convert.ToString(dataGridView1.Rows[0].Cells[1].Value);
                    inAT.Text = atText.ToString();
                    inAT.Enabled = false;
                    
                    //row["ARRIVAL TIME (AT)"] = dataGridView1.Rows[1].Cells[1].Value;
                    row["ARRIVAL TIME (AT)"] = atText;
                }
                else if (rbSelect == 2)
                {
                    //checkRows();
                    if (nRow == 0)
                    {
                        if (rbSingle.Checked)
                        {
                            string atText2 = inAT.Text;
                            inAT.Text = atText2.ToString();
                            inAT.Enabled = false;
                            row["ARRIVAL TIME (AT)"] = atText2;
                        }                        
                    }
                    row["ARRIVAL TIME (AT)"] = inAT.Text;
                }
                row["PROCESS"] = inProcess.Text;
                row["BURST TIME (BT)"] = inBT.Text;
                grpQueue.Enabled = false;
                if (nRow == 1)
                {
                    if(rbMultiple.Checked == true)
                    {
                        grpQueue.Enabled = false;
                    }
                }

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
            checkRows();
            if (nRow == 0)
            {
                grpQueue.Enabled = true;
                rbSingle.Checked = false;
                rbMultiple.Checked = false;
                //nRow = 0;
                inAT.Enabled = true;
            }

            if (nRow > 0)
            {
                grpQueue.Enabled = false;
                if (rbSingle.Checked == true)
                {
                    rbSingle.Checked = true;
                    grpQueue.Enabled = false;
                    inAT.Enabled = false;
                }
                else if (rbMultiple.Checked == true)
                {
                    rbMultiple.Checked = true;
                    grpQueue.Enabled = false;
                }
               // inAT.Enabled = true;
            }
            if (nRow != 5)
            {
                btnSTART.Enabled = false;
            }
            else
            {
                btnSTART.Enabled = true;
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
            
            if (nRow > 0)
            {
                if (rbSingle.Checked == true)
                {
                    rbSingle.Checked = true;
                    grpQueue.Enabled = false;
                }
                else if (rbMultiple.Checked == true)
                {
                    rbMultiple.Checked = true;
                    grpQueue.Enabled = false;
                }
            }
            else if (nRow == 0)
            {
                if (rbSingle.Checked)
                {
                    rbSingle.Checked = true;
                    grpQueue.Enabled = false;
                }
                else if (rbMultiple.Checked)
                {
                    rbMultiple.Checked = true;
                    grpQueue.Enabled = false;
                }
            }
        }
        private void clearTxts()
        {
            
            selectRB();
            if (rbSelect == 2)
            {
                if (rbSingle.Checked == true)
                {
                    if (count == 1 || count == 2 || count == 3 || count == 4)
                    {
                        inProcess.Text = "";
                        inBT.Text = "";
                        inAT.Text = "";
                    }

                    else
                    {
                        inProcess.Text = "";
                        inBT.Text = "";
                    }
                    count = 0;
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
            count = 0;
            
        }
        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            inProcess.Clear();
            inAT.Clear();
            inBT.Clear();
            
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            transferValuesToArray();
            btnDELETE.Enabled = false;       
            int p  = pArr.Length;

            //sorting
            if (rbMultiple.Checked)
            {
                int size = atArr.Length;

                for (int i = 0 ; i < size - 1; i++)
                {
                    int min = i;

                    for (int j = i + 1; j < size; j++)
                    {
                        if (atArr[j] < atArr[min])
                        {
                            min = j;
                        }
                    }

                    int tempAT = atArr[min];
                    atArr[min] = atArr[i];
                    atArr[i] = tempAT;

                    int tempBT = btArr[min];
                    btArr[min] = btArr[i];
                    btArr[i] = tempBT;

                    string tempProcess = pArr[min];
                    pArr[min] = pArr[i];
                    pArr[i] = tempProcess;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                bt1[i] = btArr[i];
                at1[i] = atArr[i];
                p1[i] = pArr[i];
             }

            
            findAvgTime(p1, p, bt1, at1);
            callValTable();
        }
        
        //calculate avg WT and TAT
        public static void findAvgTime(string []process, int n, int []bt, int []at)
        {
            int[] wt = new int[n];
            int[] tat = new int[n];
            int[] ct = new int[n];

            findWT(process, n, bt, wt, at);
            findTAT(process, n, bt, wt, tat);

            int totalWT = 0;
            int totalTAT = 0;
            for (int i = 0; i < n; i++)
            {
                totalWT = totalWT + wt[i];
                totalTAT = totalTAT + tat[i];
                ct[i] = tat[i] + at[i];
            }

            for (int i = 0; i < 5; i++)
            {
                finalProcess[i] = process[i];
                finalAT[i] = at[i];
                finalBT[i] = bt[i];
                finalWT[i] = wt[i];
                finalTAT[i] = tat[i];
                finalCT[i] = ct[i];
            }
        }

        static void findWT(string[] process, int n, int[] bt, int[] wt, int[] at)
        {
            int[] service_time = new int[n];
            service_time[0] = bt[0] + at[0];
            wt[0] = at[0] - at[0];

            // calculating waiting time 
            for (int i = 1; i < n; i++)
            {
                // Add burst time of previous processes 
                service_time[i] = service_time[i-1] + bt[i ];
                
                // Find waiting time for current process = 
                // sum - at[i] 
                wt[i] = service_time[i-1] - at[i ];

                if (wt[i] < 0)
                    wt[i] = 0;
            }
        }
        static void findTAT(string[] process, int n, int[] bt,
                                    int[] wt, int[] tat)
        {
            // Calculating turnaround time by adding bt[i] + wt[i] 
            for (int i = 0; i < n; i++)
                tat[i] = bt[i] + wt[i];
        }

        public void transferValuesToArray()
        {
            string[] pArray = dataGridView1.Rows
               .Cast<DataGridViewRow>()
               .Where(r => !r.IsNewRow)
               .Select(r => (r.Cells[0].Value.ToString())).ToArray();

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

            for (int i = 0; i < 5; i++)
            {
                btArr[i] = btArray[i];
            }
        }

        // delayed display 
        public async void callValTable()
        {
            for (int i = 0; i<5; i++)
            {
                timeSt = i;
                secs = finalBT[i] * 1000;
                for (int j = 0; j < 1; j++)
                {
                    if (j == 0) await Task.Delay(secs);
                    TimerMethod();
                }
            }
         }

        private void TimerMethod()
        {
            if (secs == finalBT[timeSt] * 1000)
            {
                dataGridView1.Rows[timeSt].Cells[3].Value = finalWT[timeSt].ToString();
                dataGridView1.Rows[timeSt].Cells[4].Value = finalTAT[timeSt].ToString();
                dataGridView1.Rows[timeSt].Cells[5].Value = finalCT[timeSt].ToString();
                secs = 0;
            }
           
            
        }
        
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            SolutionForm obj = new SolutionForm();
            obj.Show();
            int n = pArr.Length;

            //pass value to compute() in SolutionForm.cs
            obj.compute(pArr,n,btArr,atArr);

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
                    inAT.Text = "";
                    nRow = 0;
                    rbSelect = 0;
                }
                else
                {
                    nRow -= 1;
                }     
            }
            
            
        }
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            delete();
            checkRows();
        }


    }
}
