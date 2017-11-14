using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace atlasReactorReplaysDesktop
{
    public partial class Form1 : Form
    {

        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
            this.label1.Text = Properties.Settings.Default.path;
            populateReplays(this.label1.Text, this.listBox1);
            this.button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.label1.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.path = this.label1.Text;
                Properties.Settings.Default.Save();
            }
        }

        public static void populateReplays(string targetDirectory, ListBox list)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries.Reverse())
            {
                if (fileName.IndexOf(".arr") > 0)
                {
                    list.Items.Add(fileName.Replace(targetDirectory + "\\", ""));
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string replayText = System.IO.File.ReadAllText(@Properties.Settings.Default.path + "\\" + listBox1.SelectedItem.ToString());
            MessageBox.Show(replayText);
            */
            using (StreamReader sr = new StreamReader(Properties.Settings.Default.path + "\\" + listBox1.SelectedItem.ToString()))
            {
                // Read the stream to a string, and write the string to the console.
                String replayText = sr.ReadToEnd();
                dynamic JSON = JsonConvert.DeserializeObject(replayText);
                dynamic JSONgameConfig = JsonConvert.DeserializeObject((String)JSON.m_gameInfo_Serialized);
                this.textBox1.Text = JSONgameConfig.GameConfig.Map;
                //enable play button
                this.button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string replay = listBox1.SelectedItem.ToString();
            IntPtr calculatorHandle = FindWindow("UnityWndClass", "Atlas Reactor");
            if (calculatorHandle != (IntPtr) 0)
            {
                SetForegroundWindow(calculatorHandle);
                InputSimulator.SimulateKeyDown(VirtualKeyCode.RETURN);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.RETURN);
                System.Threading.Thread.Sleep(100);
                InputSimulator.SimulateTextEntry("/playreplay " + replay);
                InputSimulator.SimulateKeyDown(VirtualKeyCode.RETURN);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.RETURN);
            } else
            {
                MessageBox.Show("Please launch Atlas Reactor!");
            }
        }
    }
}
