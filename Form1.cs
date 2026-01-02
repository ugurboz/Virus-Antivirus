using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus_Antivirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckSimulatorFolder();
        }

        private const string VirusExtension = ".infected";
        private string simulatorPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "VirusTest");

        private void CheckSimulatorFolder()
        {
            if (!Directory.Exists(simulatorPath))
            {
                Directory.CreateDirectory(simulatorPath);
            }
        }

        private void btnCreateVirus_Click(object sender, EventArgs e)
        {
            try
            {
                CheckSimulatorFolder();
                string fileName = $"virus_{DateTime.Now.Ticks}{VirusExtension}";
                string fullPath = Path.Combine(simulatorPath, fileName);
                File.WriteAllText(fullPath, "HEAD_CRASH_DUMP_MALWARE_SIGNATURE");

                lblVirusStatus.Text = $"> Created: {fileName}";
                lblVirusStatus.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating virus: {ex.Message}");
            }
        }

        private void btnCreateRandom_Click(object sender, EventArgs e)
        {
            try
            {
                CheckSimulatorFolder();
                Random rnd = new Random();
                int count = rnd.Next(3, 10);

                for (int i = 0; i < count; i++)
                {
                    string fileName = $"worm_{Guid.NewGuid().ToString().Substring(0, 8)}{VirusExtension}";
                    string fullPath = Path.Combine(simulatorPath, fileName);
                    File.WriteAllText(fullPath, "POLYMORPHIC_CODE_BLOCK");
                }

                lblVirusStatus.Text = $"> Generated {count} malware threats.";
                lblVirusStatus.ForeColor = Color.OrangeRed;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating swarm: {ex.Message}");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtScanPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string path = txtScanPath.Text;
            if (string.IsNullOrWhiteSpace(path) || !Directory.Exists(path))
            {
                MessageBox.Show("Please select a valid directory to scan.");
                return;
            }

            lstInfected.Items.Clear();
            btnDelete.Enabled = false;
            lblScanStatus.Text = "Status: Scanning...";
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;

            Task.Run(() =>
            {
                try
                {
                    var files = Directory.GetFiles(path, $"*{VirusExtension}", SearchOption.AllDirectories);

                    Invoke(new Action(() =>
                    {
                        progressBar1.Style = ProgressBarStyle.Blocks;
                        progressBar1.Maximum = files.Length > 0 ? files.Length : 100;
                        progressBar1.Value = files.Length > 0 ? files.Length : 100;

                        if (files.Length > 0)
                        {
                            foreach (var file in files)
                            {
                                lstInfected.Items.Add(file);
                            }
                            lblScanStatus.Text = $"Status: Found {files.Length} threats!";
                            lblScanStatus.ForeColor = Color.Red;
                            btnDelete.Enabled = true;
                        }
                        else
                        {
                            lblScanStatus.Text = "Status: System Clean.";
                            lblScanStatus.ForeColor = Color.Green;
                        }
                    }));
                }
                catch (UnauthorizedAccessException)
                {
                    Invoke(new Action(() => lblScanStatus.Text = "Status: Access Denied to some folders."));
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() => MessageBox.Show($"Scan Error: {ex.Message}")));
                }
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstInfected.Items.Count == 0) return;

            int deletedCount = 0;
            foreach (var item in lstInfected.Items)
            {
                try
                {
                    string filePath = item.ToString();
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        deletedCount++;
                    }
                }
                catch { } // Skip if fails
            }

            lstInfected.Items.Clear();
            lblScanStatus.Text = $"Status: Neutralized {deletedCount} threats.";
            lblScanStatus.ForeColor = Color.Green;
            btnDelete.Enabled = false;
            progressBar1.Value = 0;
        }
    }
}
