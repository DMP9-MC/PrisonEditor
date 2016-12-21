using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDataEditor
{
    public enum FileType
    {
        Rank,
        Mine
    }
    public partial class Save : Form
    {
        FileType type;
        string output;
        string data;
        public Save(FileType type, string output, string data)
        {
            this.type = type;
            this.output = output;
            this.data = data;
            InitializeComponent();
        }

        private void Save_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(data));
            progressBar1.Increment(50);
            label2.Text = "Converting to Serializable" + type.ToString() + "...";
            Process p = new Process();
            p.StartInfo.FileName = "java.exe";
            p.StartInfo.Arguments = "-jar prisonread.jar --write-" + type.ToString().ToLower() + " \"" + output + "\" " + encoded;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.RedirectStandardOutput = true;
            p.OutputDataReceived += poutput;
            p.Start();
            p.BeginOutputReadLine();
        }
        bool go = true;
        private void poutput(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data)) { return; }
            if (!go) { return; }
            go = false;
            if (e.Data.Substring(0, 1) == "0")
            {
                Invoke(new Action(() =>
                {
                    progressBar1.Increment(50);
                    MessageBox.Show(this, "Saved", "PrisonEditor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.Yes;
                    Close();
                }));
            }
            else if (e.Data.Substring(0, 1) == "1")
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show(this, "The file, or part of the path to the file, couldn't be found.", "PrisonEditor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.No;
                    Close();
                }));
            }
            else if (e.Data.Substring(0, 1) == "2")
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("A file IO exception occurred. If you can't fix this issue yourself, open a ticket on github. https://github.com/dmp9-mc/prisoneditor/issues", "Error opening rank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.No;
                    Close();
                }));
            }
        }
    }
}
