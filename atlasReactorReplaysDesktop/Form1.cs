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
        private TextBox[] nameArray, charArray;
        private string[] charNames = new string[] { "", "Asana", "Zuki", "Aurora", "Gremolitions", "Helio", "Rask", "PuP", "Lockwood", "Nix", "Garrison", "Quark", "Kaigin", "Celeste", "Grey", "Oz", "", "Rampart", "Titus", "Elle", "Dr. Finn", "Juno", "Blackburn", "Orion", "Su-Ren", "", "Phaedra", "Brynn", "Khita", "", "", "Tol-Ren", "", "Meridian", "Nev3", "Isadora", "", "Magnus"};
        
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
            this.filePath.Text = Properties.Settings.Default.path;
            populateReplays(this.filePath.Text, this.replayList);
            this.playButton.Enabled = false;
            nameArray = new TextBox[] {this.name0, this.name1, this.name2, this.name3, this.name4, this.name5, this.name6, this.name7 };
            charArray = new TextBox[] { this.char0, this.char1, this.char2, this.char3, this.char4, this.char5, this.char6, this.char7 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.path = this.filePath.Text;
                Properties.Settings.Default.Save();
                populateReplays(this.filePath.Text, this.replayList);
            }
        }

        public static void populateReplays(string targetDirectory, ListBox list)
        {
            list.Items.Clear();
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
            using (StreamReader sr = new StreamReader(Properties.Settings.Default.path + "\\" + replayList.SelectedItem.ToString()))
            {
                // Read the stream to a string, and write the string to the console.
                String replayText = sr.ReadToEnd();
                dynamic JSON = JsonConvert.DeserializeObject(replayText);
                dynamic JSONgameInfo = JsonConvert.DeserializeObject((String)JSON.m_gameInfo_Serialized);
                dynamic JSONteamInfo = JsonConvert.DeserializeObject((String)JSON.m_teamInfo_Serialized);
                this.mapInfo.Text = JSONgameInfo.GameConfig.Map;
                int team1Index = 0;
                int team2Index = 4;
                foreach (dynamic player in JSONteamInfo.TeamPlayerInfo)
                {
                    if (player.Handle != ""){
                        if (player.TeamId == 1)
                        {
                            this.nameArray[team1Index].Text = player.Handle;
                            if (player.CharacterInfo.CharacterType <= this.charNames.Length - 1)
                            {
                                this.charArray[team1Index].Text = this.charNames[player.CharacterInfo.CharacterType];
                            } else
                            {
                                this.charArray[team1Index].Text = "N/A";
                            }
                            team1Index++;
                        } else
                        {
                            this.nameArray[team2Index].Text = player.Handle;
                            if (player.CharacterInfo.CharacterType <= this.charNames.Length - 1)
                            {
                                this.charArray[team2Index].Text = this.charNames[player.CharacterInfo.CharacterType];
                            }
                            else
                            {
                                this.charArray[team2Index].Text = "N/A";
                            }
                            team2Index++;
                        }
                    }
                }
                Console.WriteLine(this.charNames.Length);
                //enable play button
                this.playButton.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string replay = replayList.SelectedItem.ToString();
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
