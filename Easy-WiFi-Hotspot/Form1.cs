using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_WiFi_Hotspot
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ssid = textSSID.Text;
            string password = textPassword.Text;

            string output = RunAndGetOutput("netsh", "wlan set hostednetwork mode=allow ssid=" + ssid + " key=" + password);

            Console.Write(output);

            if (output.Contains("The hosted network mode has been set to allow") &&
            output.Contains("The SSID of the hosted network has been successfully changed") &&
            output.Contains("The user key passphrase of the hosted network has been successfully changed"))
            {
                string output1 = RunAndGetOutput("netsh", "wlan start hostednetwork");

                if (output1.Contains("The hosted network started."))
                {
                    MessageBox.Show("Hotspot started", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Failed to start Hotspot.\nCheck if WLAN is turned on.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Failed to start Hotspot. Configuration error.", "Error", MessageBoxButtons.OK);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string output = RunAndGetOutput("netsh", "wlan stop hostednetwork");

            if (output.Contains("The hosted network stopped."))
            {
                MessageBox.Show("Hotspot stopped", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Failed to stop Hotspot.\nCheck if WLAN is turned on.", "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = RunAndGetOutput("netsh", "wlan show drivers");

            if (output.Contains("Hosted network supported  : Yes"))
                MessageBox.Show("Supported: Yes", "Success", MessageBoxButtons.OK);
            else
                MessageBox.Show("Supported: No", "Error", MessageBoxButtons.OK);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private string RunAndGetOutput(string command, string arguments)
        {
            Process process = new Process();
            process.StartInfo.FileName = command;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            StreamReader reader = process.StandardOutput;
            string output = reader.ReadToEnd();

            process.WaitForExit();
            process.Close();

            return output;
        }
    }
}
