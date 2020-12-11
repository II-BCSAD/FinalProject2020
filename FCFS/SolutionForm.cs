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
        //Solution Table
        public void solution(string[] processes, int[] at, int[] ct, int[] st, int n)
        {
            //Display Waiting Time: as Dividend

            //getStartTime();

            int i = 0;

            if (i < n)
            {
                if (n == 3)
                {
                    wt1.Text = st[i].ToString(); i++;
                    wt2.Text = st[i].ToString();
                    i++;
                    wt3.Text = st[i].ToString();
                }

                else if (n == 4)
                {
                    wt1.Text = st[i].ToString(); i++;
                    wt2.Text = st[i].ToString();
                    i++;
                    wt3.Text = st[i].ToString();
                    i++;
                    wt4.Text = st[i].ToString();
                }
                else if (n == 5)
                {
                    wt1.Text = st[i].ToString(); i++;
                    wt2.Text = st[i].ToString();
                    i++;
                    wt3.Text = st[i].ToString();
                    i++;
                    wt4.Text = st[i].ToString();
                    i++;
                    wt5.Text = st[i].ToString();
                }
                else { }
            }

            arrival1.Text = at.Select(x => x.ToString()).Aggregate((a, b) => a + "                            " + b);

            //Start Time in Computation Table

            int s = 0;

            if (s < n)
            {
                if (n == 3)
                {
                    st1.Text = st[s].ToString();
                    s++;
                    st2.Text = st[s].ToString();
                    s++;
                    st3.Text = st[s].ToString();
                }
                else if (n == 4)
                {
                    st1.Text = st[s].ToString();
                    s++;
                    st2.Text = st[s].ToString();
                    s++;
                    st3.Text = st[s].ToString();
                    s++;
                    st4.Text = st[s].ToString();
                }
                else if (n == 5)
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
                else { }
            }

            arrival2.Text = at.Select(x => x.ToString()).Aggregate((a, b) => a + "                            " + b);

            int t = 0;

            if (t < n)
            {
                if (n == 3)
                {
                    tat01.Text = ct[t].ToString();
                    t++;
                    tat02.Text = ct[t].ToString();
                    t++;
                    tat03.Text = ct[t].ToString();
                }
                else if (n == 4)
                {
                    tat01.Text = ct[t].ToString();
                    t++;
                    tat02.Text = ct[t].ToString();
                    t++;
                    tat03.Text = ct[t].ToString();
                    t++;
                    tat04.Text = ct[t].ToString();
                }
                else if (n == 5)
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
                else { }
            }

            //Completion Time in Computation Table

            int f = 0;

            if (f < n)
            {
                if (n == 3)
                {
                    ft1.Text = ct[f].ToString();
                    f++;
                    ft2.Text = ct[f].ToString();
                    f++;
                    ft3.Text = ct[f].ToString();
                }

                else if (n == 4)
                {
                    ft1.Text = ct[f].ToString();
                    f++;
                    ft2.Text = ct[f].ToString();
                    f++;
                    ft3.Text = ct[f].ToString();
                    f++;
                    ft4.Text = ct[f].ToString();
                }

                else if (n == 5)
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
                else { }
            }

            //Display of Arrival Time in Computation Table

            int ar = 0;

            if (ar < n)
            {
               if (n == 3)
                {
                    at1.Text = at[ar].ToString();
                    ar++;
                    at2.Text = at[ar].ToString();
                    ar++;
                    at3.Text = at[ar].ToString();
                }

                else if (n == 4)
                {
                    at1.Text = at[ar].ToString();
                    ar++;
                    at2.Text = at[ar].ToString();
                    ar++;
                    at3.Text = at[ar].ToString();
                    ar++;
                    at4.Text = at[ar].ToString();
                }

                else if (n == 5)
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
                else { }
            }

            int arT = 0;

            if (arT < n)
            {
                if (n == 3)
                {
                    arT1.Text = at[arT].ToString();
                    arT++;
                    arT2.Text = at[arT].ToString();
                    arT++;
                    arT3.Text = at[arT].ToString();
                }

                else if (n == 4)
                {
                    arT1.Text = at[arT].ToString();
                    arT++;
                    arT2.Text = at[arT].ToString();
                    arT++;
                    arT3.Text = at[arT].ToString();
                    arT++;
                    arT4.Text = at[arT].ToString();
                }

                else if (n == 5)
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
                else { }
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
                if (n == 3)
                {
                    pr1.Text = process[pr].ToString();
                    pr++;
                    pr2.Text = process[pr].ToString();
                    pr++;
                    pr3.Text = process[pr].ToString();
                }

                else if (n == 4)
                {
                    pr1.Text = process[pr].ToString();
                    pr++;
                    pr2.Text = process[pr].ToString();
                    pr++;
                    pr3.Text = process[pr].ToString();
                    pr++;
                    pr4.Text = process[pr].ToString();
                }

                else if (n == 5)
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
                else { }
            }

            int p = 0;

            if (p < n)
            {
               if (n == 3)
                {
                    p1.Text = process[p].ToString();
                    p++;
                    p2.Text = process[p].ToString();
                    p++;
                    p3.Text = process[p].ToString();
                }

                else if (n == 4)
                {
                    p1.Text = process[p].ToString();
                    p++;
                    p2.Text = process[p].ToString();
                    p++;
                    p3.Text = process[p].ToString();
                    p++;
                    p4.Text = process[p].ToString();
                }

                else if (n == 5)
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
                else { }
            }

            //Display of Waiting Time

            int w = 0;

            if (w < n)
            {
                if (n == 3)
                {
                    wait1.Text = wt[w].ToString();
                    w++;
                    wait2.Text = wt[w].ToString();
                    w++;
                    wait3.Text = wt[w].ToString();
                }

                else if (n == 4)
                {
                    wait1.Text = wt[w].ToString();
                    w++;
                    wait2.Text = wt[w].ToString();
                    w++;
                    wait3.Text = wt[w].ToString();
                    w++;
                    wait4.Text = wt[w].ToString();
                }

                else if (n == 5)
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
                else { }
            }

            //Display of Turn-Around Time

            int ta = 0;

            if (ta < n)
            {
                if (n == 3)
                {
                    ta1.Text = tat[ta].ToString();
                    ta++;
                    ta2.Text = tat[ta].ToString();
                    ta++;
                    ta3.Text = tat[ta].ToString();
                }

                else if (n == 4)
                {
                    ta1.Text = tat[ta].ToString();
                    ta++;
                    ta2.Text = tat[ta].ToString();
                    ta++;
                    ta3.Text = tat[ta].ToString();
                    ta++;
                    ta4.Text = tat[ta].ToString();
                }

                else if (n == 5)
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
                else { }
            }

            //Display of Average Waiting Time

            int aWT = 0;

            if (aWT < n)
            {
                if (n == 3)
                {
                    tw1.Text = wt[aWT].ToString();
                    aWT++;
                    tw2.Text = wt[aWT].ToString();
                    aWT++;
                    tw3.Text = wt[aWT].ToString();
                }

                else if (n == 4)
                {
                    tw1.Text = wt[aWT].ToString();
                    aWT++;
                    tw2.Text = wt[aWT].ToString();
                    aWT++;
                    tw3.Text = wt[aWT].ToString();
                    aWT++;
                    tw4.Text = wt[aWT].ToString();
                }

                else if (n == 5)
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
                else { }
            }

            //Display of Average Turn-Around Time

            int aTAT = 0;

            if (aTAT < n)
            {
                if (n == 3)
                {
                    atat1.Text = tat[aTAT].ToString();
                    aTAT++;
                    atat2.Text = tat[aTAT].ToString();
                    aTAT++;
                    atat3.Text = tat[aTAT].ToString();
                }

                else if (n == 4)
                {
                    atat1.Text = tat[aTAT].ToString();
                    aTAT++;
                    atat2.Text = tat[aTAT].ToString();
                    aTAT++;
                    atat3.Text = tat[aTAT].ToString();
                    aTAT++;
                    atat4.Text = tat[aTAT].ToString();
                }

                else if (n == 5)
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
        }

            // Display AWT & ATAT
            public void final(double fWT, double fTAT, int n)
            {
                finalAWT.Text = fWT.ToString() + " ms";
                fAWT.Text = fWT.ToString() + " ms";

                finalATAT.Text = fTAT.ToString() + " ms";
                fATAT.Text = fTAT.ToString() + " ms";

                double AWT = fWT * n;
                double ATAT = fTAT * n;

                tot1.Text = AWT.ToString();
                tot2.Text = ATAT.ToString();
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btnBACK_Click_2(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}
