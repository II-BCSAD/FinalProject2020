namespace FCFS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_process = new System.Windows.Forms.Label();
            this.lb_AT = new System.Windows.Forms.Label();
            this.lbBT = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.col_Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_process
            // 
            this.lb_process.AutoSize = true;
            this.lb_process.Location = new System.Drawing.Point(23, 33);
            this.lb_process.Name = "lb_process";
            this.lb_process.Size = new System.Drawing.Size(66, 19);
            this.lb_process.TabIndex = 0;
            this.lb_process.Text = "PROCESS";
            // 
            // lb_AT
            // 
            this.lb_AT.AutoSize = true;
            this.lb_AT.Location = new System.Drawing.Point(245, 33);
            this.lb_AT.Name = "lb_AT";
            this.lb_AT.Size = new System.Drawing.Size(97, 19);
            this.lb_AT.TabIndex = 0;
            this.lb_AT.Text = "ARRIVAL TIME";
            // 
            // lbBT
            // 
            this.lbBT.AutoSize = true;
            this.lbBT.Location = new System.Drawing.Point(509, 33);
            this.lbBT.Name = "lbBT";
            this.lbBT.Size = new System.Drawing.Size(84, 19);
            this.lbBT.TabIndex = 0;
            this.lbBT.Text = "BURST TIME";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbBT);
            this.groupBox1.Controls.Add(this.lb_AT);
            this.groupBox1.Controls.Add(this.lb_process);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(814, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(599, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(348, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(13, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 256);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TABLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Process,
            this.col_AT,
            this.col_BT,
            this.col_WT,
            this.col_TAT,
            this.col_CT});
            this.dataGridView1.Location = new System.Drawing.Point(16, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(819, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // col_Process
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_Process.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_Process.HeaderText = "PROCESS";
            this.col_Process.MinimumWidth = 6;
            this.col_Process.Name = "col_Process";
            this.col_Process.ReadOnly = true;
            this.col_Process.Width = 125;
            // 
            // col_AT
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_AT.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_AT.HeaderText = "ARRIVAL TIME (AT)";
            this.col_AT.MinimumWidth = 6;
            this.col_AT.Name = "col_AT";
            this.col_AT.ReadOnly = true;
            this.col_AT.Width = 125;
            // 
            // col_BT
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_BT.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_BT.HeaderText = "BURST TIME (BT)";
            this.col_BT.MinimumWidth = 6;
            this.col_BT.Name = "col_BT";
            this.col_BT.ReadOnly = true;
            this.col_BT.Width = 125;
            // 
            // col_WT
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_WT.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_WT.HeaderText = "WAITING TIME";
            this.col_WT.MinimumWidth = 6;
            this.col_WT.Name = "col_WT";
            this.col_WT.ReadOnly = true;
            this.col_WT.Width = 125;
            // 
            // col_TAT
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_TAT.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_TAT.HeaderText = "TURN-AROUND TIME";
            this.col_TAT.MinimumWidth = 6;
            this.col_TAT.Name = "col_TAT";
            this.col_TAT.ReadOnly = true;
            this.col_TAT.Width = 125;
            // 
            // col_CT
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_CT.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_CT.HeaderText = "COMPLETION TIME";
            this.col_CT.MinimumWidth = 6;
            this.col_CT.Name = "col_CT";
            this.col_CT.ReadOnly = true;
            this.col_CT.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "First Come First Serve";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_process;
        private System.Windows.Forms.Label lb_AT;
        private System.Windows.Forms.Label lbBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CT;
    }
}

