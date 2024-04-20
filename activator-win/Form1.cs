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

namespace activator_win
{
    public partial class activator : Form
    {
        public activator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdCommands = "/c slmgr /upk && slmgr.vbs /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX && slmgr /skms kms.digiboy.ir && slmgr /ato";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", cmdCommands)
                {
                    Verb = "runas",  // This specifies that the process should run with elevated permissions
                    UseShellExecute = true,
                    CreateNoWindow = false, // This can be set to true if you want to hide the command prompt window
                    WindowStyle = ProcessWindowStyle.Normal
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdCommands = "/c slmgr /upk && slmgr.vbs /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 && slmgr /skms kms.digiboy.ir && slmgr /ato";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", cmdCommands)
                {
                    Verb = "runas",  // This specifies that the process should run with elevated permissions
                    UseShellExecute = true,
                    CreateNoWindow = false, // This can be set to true if you want to hide the command prompt window
                    WindowStyle = ProcessWindowStyle.Normal
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdCommands = "/c slmgr /upk && slmgr.vbs /ipk 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH && slmgr /skms kms.digiboy.ir && slmgr /ato";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", cmdCommands)
                {
                    Verb = "runas",  // This specifies that the process should run with elevated permissions
                    UseShellExecute = true,
                    CreateNoWindow = false, // This can be set to true if you want to hide the command prompt window
                    WindowStyle = ProcessWindowStyle.Normal
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cmdCommands = "/c slmgr /upk && slmgr.vbs /ipk ND4DX-39KJY-FYWQ9-X6XKT-VCFCF && slmgr /skms kms.digiboy.ir && slmgr /ato";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", cmdCommands)
                {
                    Verb = "runas",  // This specifies that the process should run with elevated permissions
                    UseShellExecute = true,
                    CreateNoWindow = false, // This can be set to true if you want to hide the command prompt window
                    WindowStyle = ProcessWindowStyle.Normal
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
