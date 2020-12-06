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

        public void startingTime(int[]st)
        {

        }
        //Solution Table
        public void solution(string[] processes, int[] at, int[] ct, int[] st, int n)
        {
            //Display Waiting Time: as Dividend

            //getStartTime();

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

            arrival1.Text = at.Select(x => x.ToString()).Aggregate((a, b) => a + "                      " + b);


            //Start Time in Computation Table

            int s = 0;

            if (s < n)
            {
                st1.Text = st[s].ToString();
                s++;
                st2.Text = st[s].ToString();
                s++;
                st3.Text = st[s].ToString();
                s++;
                st4.Text = st[s].ToString();
                s++;
                st5.Text = st[s].ToString();
            }

            arrival2.Text = at.Select(x => x.ToString()).Aggregate((a, b) => a + "                      " + b);

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
            job5.Text = n.ToString();
            job6.Text = n.ToString();

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

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBACK_Click_1(object sender, EventArgs e)
        {
            
        }

        private void solAWT_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click_2(object sender, EventArgs e)
        {

        }

        private void p4_TextChanged(object sender, EventArgs e)
        {

        }

        private void finalAWT_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_SF2_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void tat3_Click(object sender, EventArgs e)
        {

        }

        private void tot1_Click(object sender, EventArgs e)
        {

        }

        private void p5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void tw3_TextChanged(object sender, EventArgs e)
        {

        }

        private void arriveT_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ta5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void ta2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBACK_Click_2(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void finalATAT_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void arT4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_SF1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_SF2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void job3_Click_1(object sender, EventArgs e)
        {

        }

        private void pr5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click_1(object sender, EventArgs e)
        {

        }

        private void p3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tat04_Click_1(object sender, EventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void pr2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void arT2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void fAWT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ta4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void tat02_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void wt5_Click(object sender, EventArgs e)
        {

        }

        private void job1_Click(object sender, EventArgs e)
        {

        }

        private void fATAT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void at5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void ft5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void tot2_Click(object sender, EventArgs e)
        {

        }

        private void at2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void ft2_TextChanged(object sender, EventArgs e)
        {

        }

        private void process_Click(object sender, EventArgs e)
        {

        }

        private void tw4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void pr4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void proc_Click(object sender, EventArgs e)
        {

        }

        private void ta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tat03_Click(object sender, EventArgs e)
        {

        }

        private void tat01_Click(object sender, EventArgs e)
        {

        }

        private void wait1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void wait3_TextChanged(object sender, EventArgs e)
        {

        }

        private void wait2_TextChanged(object sender, EventArgs e)
        {

        }

        private void wait5_TextChanged(object sender, EventArgs e)
        {

        }

        private void wait4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void tw5_TextChanged(object sender, EventArgs e)
        {

        }

        private void arT1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ta3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void tw2_TextChanged(object sender, EventArgs e)
        {

        }

        private void arT5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void at3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void finish_Click(object sender, EventArgs e)
        {

        }

        private void wt4_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void solATAT_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void at4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void ft4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void at1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void turnaround_Click(object sender, EventArgs e)
        {

        }

        private void ft1_TextChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }

        private void atat3_TextChanged(object sender, EventArgs e)
        {

        }

        private void atat2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void arT3_TextChanged(object sender, EventArgs e)
        {

        }

        private void atat5_TextChanged(object sender, EventArgs e)
        {

        }

        private void atat4_TextChanged(object sender, EventArgs e)
        {

        }

        private void waiting_Click(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void p1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pr3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void job2_Click(object sender, EventArgs e)
        {

        }

        private void tw1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void p2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void wt3_Click_1(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void arrive_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void atat1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ft3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }
    }
}
