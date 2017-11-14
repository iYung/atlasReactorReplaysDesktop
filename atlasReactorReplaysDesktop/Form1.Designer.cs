namespace atlasReactorReplaysDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uploadButton = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.replayList = new System.Windows.Forms.ListBox();
            this.replaysLabel = new System.Windows.Forms.Label();
            this.mapInfo = new System.Windows.Forms.TextBox();
            this.mapLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.team1Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(10, 70);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Search";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // filePath
            // 
            this.filePath.AutoEllipsis = true;
            this.filePath.Location = new System.Drawing.Point(91, 75);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(654, 18);
            this.filePath.TabIndex = 1;
            this.filePath.Text = "Select your replays folder";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(50, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(55, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(231, 44);
            this.title.TabIndex = 3;
            this.title.Text = "R REPLAYS";
            // 
            // replayList
            // 
            this.replayList.FormattingEnabled = true;
            this.replayList.Location = new System.Drawing.Point(10, 125);
            this.replayList.Name = "replayList";
            this.replayList.Size = new System.Drawing.Size(473, 290);
            this.replayList.TabIndex = 4;
            this.replayList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // replaysLabel
            // 
            this.replaysLabel.AutoSize = true;
            this.replaysLabel.Location = new System.Drawing.Point(9, 106);
            this.replaysLabel.Name = "replaysLabel";
            this.replaysLabel.Size = new System.Drawing.Size(45, 13);
            this.replaysLabel.TabIndex = 5;
            this.replaysLabel.Text = "Replays";
            // 
            // mapInfo
            // 
            this.mapInfo.Location = new System.Drawing.Point(489, 125);
            this.mapInfo.Name = "mapInfo";
            this.mapInfo.ReadOnly = true;
            this.mapInfo.Size = new System.Drawing.Size(256, 20);
            this.mapInfo.TabIndex = 7;
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Location = new System.Drawing.Point(486, 106);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(31, 13);
            this.mapLabel.TabIndex = 8;
            this.mapLabel.Text = "Map:";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(670, 392);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 9;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Location = new System.Drawing.Point(486, 148);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(46, 13);
            this.team1Label.TabIndex = 10;
            this.team1Label.Text = "Team 1:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(595, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(595, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(489, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(595, 216);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(150, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(489, 216);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(595, 242);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(150, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(489, 242);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(595, 359);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(150, 20);
            this.textBox9.TabIndex = 27;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(489, 359);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 26;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(595, 333);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(150, 20);
            this.textBox11.TabIndex = 25;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(489, 333);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 24;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(595, 307);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(150, 20);
            this.textBox13.TabIndex = 23;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(489, 307);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 22;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(595, 281);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(150, 20);
            this.textBox15.TabIndex = 21;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(489, 281);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Team 2:";
            // 
            // patchLabel
            // 
            this.patchLabel.AutoSize = true;
            this.patchLabel.Location = new System.Drawing.Point(674, 9);
            this.patchLabel.Name = "patchLabel";
            this.patchLabel.Size = new System.Drawing.Size(71, 13);
            this.patchLabel.TabIndex = 28;
            this.patchLabel.Text = "Current patch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 427);
            this.Controls.Add(this.patchLabel);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.team1Label);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.mapLabel);
            this.Controls.Add(this.mapInfo);
            this.Controls.Add(this.replaysLabel);
            this.Controls.Add(this.replayList);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.title);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.uploadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Atlas Reactor Replays";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox replayList;
        private System.Windows.Forms.Label replaysLabel;
        private System.Windows.Forms.TextBox mapInfo;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label team1Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patchLabel;
    }
}

