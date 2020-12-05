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
        public static int[] getSt = new int[5];
        public static int[] getTAT = new int[5];
        public static bool drag = false;
        public static Point start_point = new Point(0, 0);
        public SolutionForm()
        {
            InitializeComponent();
            //getStartTime();
        }
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }
        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }
        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        
        //Solution Table
        public void solution(string[] processes, int[] at, int[] ct, int n)
        {
            //Display Waiting Time: as Dividend

            //getStartTime();

            for(int j = 0; j < 5; j++)
            {
                getTAT[j] = ct[j] - at[j];
            }

            for (int k = 0; k < 5; k++)
            {
                if (k == 0)
                {
                    getSt[k] = at[0];
                }
                else if (k > 0 && k < 5)
                {
                    getSt[k] = getTAT[k] + at[k];
                }
            }

            int i = 0;

            if (i < n)
            {
                wt1.Text = at[i].ToString();
                wt2.Text = ct[i].ToString();
                i++;
                wt3.Text = ct[i].ToString();
                i++;
                wt4.Text = ct[i].ToString();
                i++;
                wt5.Text = ct[i].ToString();
            }

            //arrival1.Text = at.Select(x => x.ToString()).Aggregate((a, b) => a + "                      " + b);


            //Start Time in Computation Table

            int s = 0;

            if (s < n)
            {
                st1.Text = at[s].ToString();
                st2.Text = ct[s].ToString();
                s++;
                st3.Text = ct[s].ToString();
                s++;
                st4.Text = ct[s].ToString();
                s++;
                st5.Text = ct[s].ToString();
            }

            //arrival2.Text = at.Select(x => x.ToString()).Aggregate((a, b) => a + "                      " + b);

            int t = 0;

            if (t < n)
            {
                tat01.Text = ct[t].ToString();
                t++;
                tat02.Text = ct[t].ToString();
                t++;
                tat03.Text = ct[t].ToString();
                t++;
                tat04.Text = ct[t].ToString();
                t++;
                tat05.Text = ct[t].ToString();
            }

            //Completion Time in Computation Table

            int f = 0;

            if (f < n)
            {
                ft1.Text = ct[f].ToString();
                f++;
                ft2.Text = ct[f].ToString();
                f++;
                ft3.Text = ct[f].ToString();
                f++;
                ft4.Text = ct[f].ToString();
                f++;
                ft5.Text = ct[f].ToString();
            }

            //Display of Arrival Time in Computation Table

            int ar = 0;

            if (ar < n)
            {
                at1.Text = at[ar].ToString();
                ar++;
                at2.Text = at[ar].ToString();
                ar++;
                at3.Text = at[ar].ToString();
                ar++;
                at4.Text = at[ar].ToString();
                ar++;
                at5.Text = at[ar].ToString();
            }

            int arT = 0;

            if (arT < n)
            {
                arT1.Text = at[arT].ToString();
                arT++;
                arT2.Text = at[arT].ToString();
                arT++;
                arT3.Text = at[arT].ToString();
                arT++;
                arT4.Text = at[arT].ToString();
                arT++;
                arT5.Text = at[arT].ToString();
            }

            // No# of Jobs/Processes: as a Divisor

            job1.Text = n.ToString();
            job2.Text = n.ToString();
            job3.Text = n.ToString();
            job4.Text = n.ToString();
            //job5.Text = n.ToString();
            //job6.Text = n.ToString();

        }
        //Computation Table
        public void compute(string[] process, int[] wt, int[] tat, int n)
        {
            // Display of Processes

            int pr = 0;

            if (pr < n)
            {
                pr1.Text = process[pr].ToString();
                pr++;
                pr2.Text = process[pr].ToString();
                pr++;
                pr3.Text = process[pr].ToString();
                pr++;
                pr4.Text = process[pr].ToString();
                pr++;
                pr5.Text = process[pr].ToString();
            }

            int p = 0;

            if (p < n)
            {
                p1.Text = process[p].ToString();
                p++;
                p2.Text = process[p].ToString();
                p++;
                p3.Text = process[p].ToString();
                p++;
                p4.Text = process[p].ToString();
                p++;
                p5.Text = process[p].ToString();
            }

            //Display of Waiting Time

            int w = 0;

            if (w < n)
            {
                wait1.Text = wt[w].ToString();
                w++;
                wait2.Text = wt[w].ToString();
                w++;
                wait3.Text = wt[w].ToString();
                w++;
                wait4.Text = wt[w].ToString();
                w++;
                wait5.Text = wt[w].ToString();
            }

            //Display of Turn-Around Time

            int ta = 0;

            if (ta < n)
            {
                ta1.Text = tat[ta].ToString();
                ta++;
                ta2.Text = tat[ta].ToString();
                ta++;
                ta3.Text = tat[ta].ToString();
                ta++;
                ta4.Text = tat[ta].ToString();
                ta++;
                ta5.Text = tat[ta].ToString();
            }

            //Display of Average Waiting Time

            int aWT = 0;

            if (aWT < n)
            {
                tw1.Text = wt[aWT].ToString();
                aWT++;
                tw2.Text = wt[aWT].ToString();
                aWT++;
                tw3.Text = wt[aWT].ToString();
                aWT++;
                tw4.Text = wt[aWT].ToString();
                aWT++;
                tw5.Text = wt[aWT].ToString();
            }

            //Display of Average Turn-Around Time

            int aTAT = 0;

            if (aTAT < n)
            {
                atat1.Text = tat[aTAT].ToString();
                aTAT++;
                atat2.Text = tat[aTAT].ToString();
                aTAT++;
                atat3.Text = tat[aTAT].ToString();
                aTAT++;
                atat4.Text = tat[aTAT].ToString();
                aTAT++;
                atat5.Text = tat[aTAT].ToString();
            }
        }

        // Display AWT & ATAT
        public void final(double fWT, double fTAT, int n)
        {
            finalAWT.Text = fWT.ToString();
            fAWT.Text = fWT.ToString();

            finalATAT.Text = fTAT.ToString();
            fATAT.Text = fTAT.ToString();

            double AWT = fWT * n;
            double ATAT = fTAT * n;

            tot1.Text = AWT.ToString();
            tot2.Text = ATAT.ToString();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void wt1_Click(object sender, EventArgs e)
        {

        }

        private void wt2_Click(object sender, EventArgs e)
        {

        }

        private void tat05_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void solAWT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void arrival_Click(object sender, EventArgs e)
        {

        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void wt3_Click(object sender, EventArgs e)
        {

        }

        private void arrival2_Click(object sender, EventArgs e)
        {

        }

        private void solATAT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click_1(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label94_Click(object sender, EventArgs e)
        {

        }

        private void label112_Click(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void label114_Click(object sender, EventArgs e)
        {

        }

        private void label119_Click(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void job3_Click(object sender, EventArgs e)
        {

        }

        private void tat04_Click(object sender, EventArgs e)
        {

        }

        private void label117_Click(object sender, EventArgs e)
        {

        }

        private void label118_Click(object sender, EventArgs e)
        {

        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label107_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void label95_Click(object sender, EventArgs e)
        {

        }

        private void label97_Click(object sender, EventArgs e)
        {

        }
    }
}
