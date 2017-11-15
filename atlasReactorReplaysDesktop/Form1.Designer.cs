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
            this.char0 = new System.Windows.Forms.TextBox();
            this.name0 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.char1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.char2 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.char3 = new System.Windows.Forms.TextBox();
            this.name7 = new System.Windows.Forms.TextBox();
            this.char7 = new System.Windows.Forms.TextBox();
            this.name6 = new System.Windows.Forms.TextBox();
            this.char6 = new System.Windows.Forms.TextBox();
            this.name5 = new System.Windows.Forms.TextBox();
            this.char5 = new System.Windows.Forms.TextBox();
            this.name4 = new System.Windows.Forms.TextBox();
            this.char4 = new System.Windows.Forms.TextBox();
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
            // char0
            // 
            this.char0.Location = new System.Drawing.Point(489, 164);
            this.char0.Name = "char0";
            this.char0.ReadOnly = true;
            this.char0.Size = new System.Drawing.Size(100, 20);
            this.char0.TabIndex = 11;
            // 
            // name0
            // 
            this.name0.Location = new System.Drawing.Point(595, 164);
            this.name0.Name = "name0";
            this.name0.ReadOnly = true;
            this.name0.Size = new System.Drawing.Size(150, 20);
            this.name0.TabIndex = 12;
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(595, 190);
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            this.name1.Size = new System.Drawing.Size(150, 20);
            this.name1.TabIndex = 14;
            // 
            // char1
            // 
            this.char1.Location = new System.Drawing.Point(489, 190);
            this.char1.Name = "char1";
            this.char1.ReadOnly = true;
            this.char1.Size = new System.Drawing.Size(100, 20);
            this.char1.TabIndex = 13;
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(595, 216);
            this.name2.Name = "name2";
            this.name2.ReadOnly = true;
            this.name2.Size = new System.Drawing.Size(150, 20);
            this.name2.TabIndex = 16;
            // 
            // char2
            // 
            this.char2.Location = new System.Drawing.Point(489, 216);
            this.char2.Name = "char2";
            this.char2.ReadOnly = true;
            this.char2.Size = new System.Drawing.Size(100, 20);
            this.char2.TabIndex = 15;
            // 
            // name3
            // 
            this.name3.Location = new System.Drawing.Point(595, 242);
            this.name3.Name = "name3";
            this.name3.ReadOnly = true;
            this.name3.Size = new System.Drawing.Size(150, 20);
            this.name3.TabIndex = 18;
            // 
            // char3
            // 
            this.char3.Location = new System.Drawing.Point(489, 242);
            this.char3.Name = "char3";
            this.char3.ReadOnly = true;
            this.char3.Size = new System.Drawing.Size(100, 20);
            this.char3.TabIndex = 17;
            // 
            // name7
            // 
            this.name7.Location = new System.Drawing.Point(595, 359);
            this.name7.Name = "name7";
            this.name7.ReadOnly = true;
            this.name7.Size = new System.Drawing.Size(150, 20);
            this.name7.TabIndex = 27;
            // 
            // char7
            // 
            this.char7.Location = new System.Drawing.Point(489, 359);
            this.char7.Name = "char7";
            this.char7.ReadOnly = true;
            this.char7.Size = new System.Drawing.Size(100, 20);
            this.char7.TabIndex = 26;
            // 
            // name6
            // 
            this.name6.Location = new System.Drawing.Point(595, 333);
            this.name6.Name = "name6";
            this.name6.ReadOnly = true;
            this.name6.Size = new System.Drawing.Size(150, 20);
            this.name6.TabIndex = 25;
            // 
            // char6
            // 
            this.char6.Location = new System.Drawing.Point(489, 333);
            this.char6.Name = "char6";
            this.char6.ReadOnly = true;
            this.char6.Size = new System.Drawing.Size(100, 20);
            this.char6.TabIndex = 24;
            // 
            // name5
            // 
            this.name5.Location = new System.Drawing.Point(595, 307);
            this.name5.Name = "name5";
            this.name5.ReadOnly = true;
            this.name5.Size = new System.Drawing.Size(150, 20);
            this.name5.TabIndex = 23;
            // 
            // char5
            // 
            this.char5.Location = new System.Drawing.Point(489, 307);
            this.char5.Name = "char5";
            this.char5.ReadOnly = true;
            this.char5.Size = new System.Drawing.Size(100, 20);
            this.char5.TabIndex = 22;
            // 
            // name4
            // 
            this.name4.Location = new System.Drawing.Point(595, 281);
            this.name4.Name = "name4";
            this.name4.ReadOnly = true;
            this.name4.Size = new System.Drawing.Size(150, 20);
            this.name4.TabIndex = 21;
            // 
            // char4
            // 
            this.char4.Location = new System.Drawing.Point(489, 281);
            this.char4.Name = "char4";
            this.char4.ReadOnly = true;
            this.char4.Size = new System.Drawing.Size(100, 20);
            this.char4.TabIndex = 20;
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
            this.patchLabel.Location = new System.Drawing.Point(608, 9);
            this.patchLabel.Name = "patchLabel";
            this.patchLabel.Size = new System.Drawing.Size(137, 13);
            this.patchLabel.TabIndex = 28;
            this.patchLabel.Text = "Up to date with: 11/7/2017";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 427);
            this.Controls.Add(this.patchLabel);
            this.Controls.Add(this.name7);
            this.Controls.Add(this.char7);
            this.Controls.Add(this.name6);
            this.Controls.Add(this.char6);
            this.Controls.Add(this.name5);
            this.Controls.Add(this.char5);
            this.Controls.Add(this.name4);
            this.Controls.Add(this.char4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.char3);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.char2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.char1);
            this.Controls.Add(this.name0);
            this.Controls.Add(this.char0);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.TextBox char0;
        private System.Windows.Forms.TextBox name0;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox char1;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox char2;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.TextBox char3;
        private System.Windows.Forms.TextBox name7;
        private System.Windows.Forms.TextBox char7;
        private System.Windows.Forms.TextBox name6;
        private System.Windows.Forms.TextBox char6;
        private System.Windows.Forms.TextBox name5;
        private System.Windows.Forms.TextBox char5;
        private System.Windows.Forms.TextBox name4;
        private System.Windows.Forms.TextBox char4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patchLabel;
    }
}

