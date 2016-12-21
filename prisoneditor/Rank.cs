using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDataEditor
{
    public partial class Rank : Form
    {
        string openFile = "";
        public Rank()
        {
            InitializeComponent();
        }

        private void Rank_Load(object sender, EventArgs e)
        {

        }
        private void RankEditor()
        {
            Controls.Clear();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prison 2 Data Editor";
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(18, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 1);
            this.panel1.TabIndex = 1;
            this.button1.Location = new System.Drawing.Point(18, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cl&ose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += button1_Click;
            this.button2.Location = new System.Drawing.Point(124, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Save file";
            this.button2.Click += Button2_Click;
            this.button2.UseVisualStyleBackColor = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(230, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "(C) 2016 DMP9 Labs";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID:";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(100, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rank name:";
            this.textBox1.Location = new System.Drawing.Point(175, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "null";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(18, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Price:";
            this.textBox2.Location = new System.Drawing.Point(60, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "0.00";
            this.textBox3.Location = new System.Drawing.Point(175, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "null";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(100, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Rank prefix:";
            this.numericUpDown1.Location = new System.Drawing.Point(45, 102);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Minimum = 0;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
        }
        private void MineEditor()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bidl = new System.Windows.Forms.Label();
            this.bid = new System.Windows.Forms.NumericUpDown();
            this.bd = new System.Windows.Forms.NumericUpDown();
            this.bdl = new System.Windows.Forms.Label();
            this.bc = new System.Windows.Forms.TextBox();
            this.bcl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prison 2 Data Editor";
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(18, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 1);
            this.panel1.TabIndex = 1;
            this.button1.Location = new System.Drawing.Point(18, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cl&ose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += button1_Click;
            this.button2.Location = new System.Drawing.Point(124, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Save file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(230, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "(C) 2016 DMP9 Labs";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 184);
            this.tabControl1.TabIndex = 5;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(312, 158);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage2.Controls.Add(this.bc);
            this.tabPage2.Controls.Add(this.bcl);
            this.tabPage2.Controls.Add(this.bd);
            this.tabPage2.Controls.Add(this.bdl);
            this.tabPage2.Controls.Add(this.bid);
            this.tabPage2.Controls.Add(this.bidl);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(312, 158);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Blocks";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            this.textBox1.Location = new System.Drawing.Point(54, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox2.Location = new System.Drawing.Point(206, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(158, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "World:";
            this.x1.Location = new System.Drawing.Point(29, 19);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(58, 20);
            this.x1.TabIndex = 8;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.y1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.x1);
            this.groupBox1.Location = new System.Drawing.Point(9, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 47);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First position";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "X:";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(92, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y:";
            this.y1.Location = new System.Drawing.Point(115, 19);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(58, 20);
            this.y1.TabIndex = 10;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(179, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Z:";
            this.numericUpDown1.Location = new System.Drawing.Point(202, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 12;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Location = new System.Drawing.Point(9, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 47);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Second position";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(179, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Z:";
            this.numericUpDown2.Location = new System.Drawing.Point(202, 19);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown2.TabIndex = 12;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(92, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Y:";
            this.numericUpDown3.Location = new System.Drawing.Point(115, 19);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown3.TabIndex = 10;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "X:";
            this.numericUpDown4.Location = new System.Drawing.Point(29, 19);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown4.TabIndex = 8;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(104, 152);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += TreeView1_AfterSelect;
            this.button3.Location = new System.Drawing.Point(113, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add block";
            this.button3.Click += Button3_Click;
            this.button3.UseVisualStyleBackColor = true;
            this.button4.Location = new System.Drawing.Point(184, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Del block";
            this.button4.Click += Button4_Click;
            this.button4.UseVisualStyleBackColor = true;
            this.bidl.AutoSize = true;
            this.bidl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bidl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bidl.Location = new System.Drawing.Point(115, 32);
            this.bidl.Name = "bidl";
            this.bidl.Size = new System.Drawing.Size(53, 15);
            this.bidl.TabIndex = 6;
            this.bidl.Text = "Block ID:";
            this.bid.ValueChanged += Bid_ValueChanged;
            this.bd.ValueChanged += Bd_ValueChanged;
            this.bid.Location = new System.Drawing.Point(174, 32);
            this.bid.Maximum = new decimal(new int[] {
            635,
            0,
            0,
            0});
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(63, 20);
            this.bid.TabIndex = 7;
            this.bd.Location = new System.Drawing.Point(174, 60);
            this.bd.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(63, 20);
            this.bd.TabIndex = 9;
            this.bdl.AutoSize = true;
            this.bdl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bdl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bdl.Location = new System.Drawing.Point(115, 61);
            this.bdl.Name = "bdl";
            this.bdl.Size = new System.Drawing.Size(34, 15);
            this.bdl.TabIndex = 8;
            this.bdl.Text = "Data:";
            this.bc.TextChanged += Bc_ValueChanged;
            this.bc.Location = new System.Drawing.Point(174, 88);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(63, 20);
            this.bc.TabIndex = 11;
            this.bcl.AutoSize = true;
            this.bcl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bcl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bcl.Location = new System.Drawing.Point(115, 89);
            this.bcl.Name = "bcl";
            this.bcl.Size = new System.Drawing.Size(50, 15);
            this.bcl.TabIndex = 10;
            this.bcl.Text = "Chance:";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(357, 278);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Prison 2 Data Editor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.x1.Minimum = -2147483648;
            this.y1.Minimum = -2147483648;
            this.numericUpDown4.Minimum = -2147483648;
            this.numericUpDown3.Minimum = -2147483648;
            this.numericUpDown2.Minimum = -2147483648;
            this.numericUpDown1.Minimum = -2147483648;
            this.x1.Maximum = 2147483648;
            this.y1.Maximum = 2147483648;
            this.numericUpDown4.Maximum = 2147483648;
            this.numericUpDown3.Maximum = 2147483648;
            this.numericUpDown2.Maximum = 2147483648;
            this.numericUpDown1.Maximum = 2147483648;
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Del block
            BlockDeselected();
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Add block
            TreeNode node = new TreeNode();
            node.Name = "1:0,0.5";
            node.Text = "1:0";
            int i = treeView1.Nodes.Count;
            treeView1.Nodes.Add(node);
            treeView1.SelectedNode = treeView1.Nodes[i];
            BlockSelected();
        }

        private void Bc_ValueChanged(object sender, EventArgs e)
        {
            double b;
            if (!double.TryParse(bc.Text,out b))
            {
                MessageBox.Show(this, "Chance is not a valid double!\nExample of a valid double: 1.00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bc.Text = "0.00";
                return;
            }
            treeView1.SelectedNode.Name = bid.Value.ToString() + ":" + bd.Value.ToString() + "," + b;
        }

        private void Bd_ValueChanged(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Name = bid.Value.ToString() + ":" + bd.Value.ToString() + "," + Convert.ToDouble(bc.Text);
            treeView1.SelectedNode.Text = bid.Value.ToString() + ":" + bd.Value.ToString();
        }

        private void Bid_ValueChanged(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Name = bid.Value.ToString() + ":" + bd.Value.ToString() + "," + Convert.ToDouble(bc.Text);
            treeView1.SelectedNode.Text = bid.Value.ToString() + ":" + bd.Value.ToString();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) { BlockSelected(); return; }
            BlockSelected();
            string bid = e.Node.Name.Split(',')[0].Split(':')[0];
            string bd = e.Node.Name.Split(',')[0].Split(':')[1];
            string bc = e.Node.Name.Split(',')[1];
            this.bc.Text = bc;
            this.bid.Value = int.Parse(bid);
            this.bd.Value = int.Parse(bd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string output = "";
            output += "Name=" + textBox1.Text + Environment.NewLine;
            output += "WorldName=" + textBox2.Text + Environment.NewLine;
            output += "MinX=" + x1.Value + Environment.NewLine;
            output += "MinY=" + y1.Value + Environment.NewLine;
            output += "MinZ=" + numericUpDown1.Value + Environment.NewLine;
            output += "MaxX=" + numericUpDown4.Value + Environment.NewLine;
            output += "MaxY=" + numericUpDown3.Value + Environment.NewLine;
            output += "MaxZ=" + numericUpDown2.Value;
            foreach (TreeNode n in treeView1.Nodes)
            {
                output += Environment.NewLine+"Block=" + n.Name;
            }
            new Save(FileType.Mine, openFile, output).ShowDialog();
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.NumericUpDown x1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox bc;
        private System.Windows.Forms.Label bcl;
        private System.Windows.Forms.NumericUpDown bd;
        private System.Windows.Forms.Label bdl;
        private System.Windows.Forms.NumericUpDown bid;
        private System.Windows.Forms.Label bidl;

        private void Button2_Click(object sender, EventArgs e)
        {
            string output = "";
            output += "Id="+numericUpDown1.Value + Environment.NewLine;
            output += "Name=" + textBox1.Text + Environment.NewLine;
            double price = 0;
            bool pv = double.TryParse(textBox2.Text,out price);
            if (!pv) { MessageBox.Show(this,"Price is not a valid double!\nExample of a valid double: 1.00","Error saving",MessageBoxButtons.OK,MessageBoxIcon.Error); return; }
            output += "Price=" + price.ToString() + Environment.NewLine;
            output += "Prefix=" + textBox3.Text;
            new Save(FileType.Rank, openFile, output).ShowDialog();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Open Rank file")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open rank file...";
                ofd.Filter = "Prison Rank|*.rank";
                if (ofd.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                openFile = ofd.FileName;
                Process p = new Process();
                p.StartInfo.FileName = "java.exe";
                p.StartInfo.Arguments = "-jar prisonread.jar --read-rank \"" + ofd.FileName + "\"";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.RedirectStandardOutput = true;
                p.OutputDataReceived += rank_output;
                p.Start();
                p.BeginOutputReadLine();
            }
            else
            {
                if (MessageBox.Show(this,"All unsaved changes will be lost.","Are you sure?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    openFile = "";
                    go = true;
                    Controls.Clear();
                    InitializeComponent();
                    return;
                }
            }
        }
        bool go = true;
        private void rank_output(object sender, DataReceivedEventArgs e)
        {
            if (!go) { return; }
            go = false;
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            if (e.Data.Substring(0, 1) != "0")
            {
                if (e.Data.Substring(0, 1) == "1") { MessageBox.Show("The file no longer exists", "Error opening rank",MessageBoxButtons.OK,MessageBoxIcon.Error); }
                else if (e.Data.Substring(0, 1) == "2") { MessageBox.Show("A file IO exception occurred. If you can't fix this issue yourself, open a ticket on github. https://github.com/dmp9-mc/prisoneditor/issues", "Error opening rank", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (e.Data.Substring(0, 1) == "3") { MessageBox.Show("Not a valid rank file. If you are confident it came from the Prison plugin, your PrisonEditor installation is corrupt, please install it again.", "Error opening rank", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                return;
            }
            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            string file = iso.GetString(Convert.FromBase64String(e.Data.Substring(1)));
            Invoke(new Action(() => { RankEditor(); }));
            foreach (string s in file.Split(Environment.NewLine.ToCharArray(),StringSplitOptions.RemoveEmptyEntries))
            {
                string key = s.Split('=')[0];
                string value = s.Split('=')[1];
                if (key == "Id")
                {
                    Invoke(new Action(() => { numericUpDown1.Value = decimal.Parse(value); }));
                }
                else if (key == "Name")
                {
                    Invoke(new Action(() => { textBox1.Text = value; }));
                }
                else if (key == "Price")
                {
                    Invoke(new Action(() => { textBox2.Text = value; }));
                }
                else if (key == "Prefix")
                {
                    Invoke(new Action(() =>
                    {
                        textBox3.Text = value;
                    }));
                }
                else { MessageBox.Show(this,"Invalid key/value pair (Are you sure it's a rank file?)","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Select output";
            sfd.Filter = "Prison Rank|*.rank";
            if (sfd.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            openFile = sfd.FileName;
            RankEditor();
        }
        List<string> blocks;
        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open mine file...";
            ofd.Filter = "Prison Mine|*.mine";
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            openFile = ofd.FileName;
            Process p = new Process();
            p.StartInfo.FileName = "java.exe";
            p.StartInfo.Arguments = "-jar prisonread.jar --read-mine \"" + ofd.FileName + "\"";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.RedirectStandardOutput = true;
            p.OutputDataReceived += mine_output;
            p.Start();
            p.BeginOutputReadLine();
        }
        private void BlockDeselected()
        {
            bidl.Text = "Select a block or create one using\nthe buttons above";
            bid.Visible = false;
            bdl.Visible = false;
            bd.Visible = false;
            bcl.Visible = false;
            bc.Visible = false;
        }
        private void BlockSelected()
        {
            bidl.Text = "Block ID:";
            bid.Visible = true;
            bdl.Visible = true;
            bd.Visible = true;
            bcl.Visible = true;
            bc.Visible = true;
        }
        private void mine_output(object sender, DataReceivedEventArgs e)
        {
            if (!go) { return; }
            go = false;
            this.blocks = new System.Collections.Generic.List<string>();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            if (e.Data.Substring(0, 1) != "0")
            {
                if (e.Data.Substring(0, 1) == "1") { MessageBox.Show("The file no longer exists", "Error opening mine", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (e.Data.Substring(0, 1) == "2") { MessageBox.Show("A file IO exception occurred. If you can't fix this issue yourself, open a ticket on github. https://github.com/dmp9-mc/prisoneditor/issues", "Error opening mine", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (e.Data.Substring(0, 1) == "3") { MessageBox.Show("Not a valid rank file. If you are confident it came from the Prison plugin, your PrisonEditor installation is corrupt, please install it again.", "Error opening mine", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                return;
            }
            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            string file = iso.GetString(Convert.FromBase64String(e.Data.Substring(1)));
            Invoke(new Action(() => { Controls.Clear(); MineEditor(); }));
            foreach (string s in file.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                string key = s.Split('=')[0];
                string value = s.Split('=')[1];
                if (key == "Name")
                {
                    Invoke(new Action(() => { textBox1.Text = value; }));
                }
                else if (key == "WorldName")
                {
                    Invoke(new Action(() => { textBox2.Text = value; }));
                }
                else if (key == "MinX") { Invoke(new Action(() => { x1.Value = int.Parse(value); })); }
                else if (key == "MinY") { Invoke(new Action(() => { y1.Value = int.Parse(value); })); }
                else if (key == "MinZ") { Invoke(new Action(() => { numericUpDown1.Value = int.Parse(value); })); }
                else if (key == "MaxX") { Invoke(new Action(() => { numericUpDown4.Value = int.Parse(value); })); }
                else if (key == "MaxY") { Invoke(new Action(() => { numericUpDown3.Value = int.Parse(value); })); }
                else if (key == "MaxZ") { Invoke(new Action(() => { numericUpDown2.Value = int.Parse(value); })); }
                else if (key == "Block") { Invoke(new Action(() => { blocks.Add(value); })); }
                else { MessageBox.Show(this, "Invalid key/value pair (Are you sure it's a mine file?)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            foreach (string s in blocks)
            {
                TreeNode editorNode = new TreeNode();
                editorNode.Name = s;
                editorNode.Text = s.Split(',')[0];
                treeView1.Nodes.Add(editorNode);
            }
            Invoke(new Action(() => { BlockDeselected(); }));
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Select output";
            sfd.Filter = "Prison Mine|*.mine";
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            openFile = sfd.FileName;
            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            string file = iso.GetString(Convert.FromBase64String("TmFtZT1NeU5ld01pbmUNCldvcmxkTmFtZT13b3JsZA0KTWluWD0wDQpNaW5ZPTYwDQpNaW5aPTANCk1heFg9MjANCk1heFk9ODANCk1heFo9MjANCkJsb2NrPTE6MCwxLjA="));
            Invoke(new Action(() => { Controls.Clear(); MineEditor(); }));
            blocks = new List<string>();
            foreach (string s in file.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                string key = s.Split('=')[0];
                string value = s.Split('=')[1];
                if (key == "Name")
                {
                    Invoke(new Action(() => { textBox1.Text = value; }));
                }
                else if (key == "WorldName")
                {
                    Invoke(new Action(() => { textBox2.Text = value; }));
                }
                else if (key == "MinX") { Invoke(new Action(() => { x1.Value = int.Parse(value); })); }
                else if (key == "MinY") { Invoke(new Action(() => { y1.Value = int.Parse(value); })); }
                else if (key == "MinZ") { Invoke(new Action(() => { numericUpDown1.Value = int.Parse(value); })); }
                else if (key == "MaxX") { Invoke(new Action(() => { numericUpDown4.Value = int.Parse(value); })); }
                else if (key == "MaxY") { Invoke(new Action(() => { numericUpDown3.Value = int.Parse(value); })); }
                else if (key == "MaxZ") { Invoke(new Action(() => { numericUpDown2.Value = int.Parse(value); })); }
                else if (key == "Block") { Invoke(new Action(() => { blocks.Add(value); })); }
                else { MessageBox.Show(this, "Invalid key/value pair (Are you sure it's a mine file?)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            foreach (string s in blocks)
            {
                TreeNode editorNode = new TreeNode();
                editorNode.Name = s;
                editorNode.Text = s.Split(',')[0];
                treeView1.Nodes.Add(editorNode);
            }
            Invoke(new Action(() => { BlockDeselected(); }));
            Controls.Clear();
            MineEditor();
        }
    }
}