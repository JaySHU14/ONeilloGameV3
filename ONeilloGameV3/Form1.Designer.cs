namespace ONeilloGameV3
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.statusLabel1 = new System.Windows.Forms.Label();
            this.informationPanelMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameTab = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameTab = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player2CounterBox = new System.Windows.Forms.PictureBox();
            this.player1CounterBox = new System.Windows.Forms.PictureBox();
            this.player2PictureBox = new System.Windows.Forms.PictureBox();
            this.player1PictureBox = new System.Windows.Forms.PictureBox();
            this.infoPanel.SuspendLayout();
            this.informationPanelMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2CounterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1CounterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.infoPanel.Controls.Add(this.player2CounterBox);
            this.infoPanel.Controls.Add(this.player1CounterBox);
            this.infoPanel.Controls.Add(this.player2PictureBox);
            this.infoPanel.Controls.Add(this.player1PictureBox);
            this.infoPanel.Controls.Add(this.player2ScoreLabel);
            this.infoPanel.Controls.Add(this.player1ScoreLabel);
            this.infoPanel.Controls.Add(this.player2TextBox);
            this.infoPanel.Controls.Add(this.player1TextBox);
            this.infoPanel.Controls.Add(this.statusLabel1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(0, 463);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(404, 98);
            this.infoPanel.TabIndex = 0;
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.Location = new System.Drawing.Point(262, 42);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(21, 13);
            this.player2ScoreLabel.TabIndex = 4;
            this.player2ScoreLabel.Text = "x 2";
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.Location = new System.Drawing.Point(69, 42);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(21, 13);
            this.player1ScoreLabel.TabIndex = 3;
            this.player1ScoreLabel.Text = "x 2";
            // 
            // player2TextBox
            // 
            this.player2TextBox.Location = new System.Drawing.Point(277, 57);
            this.player2TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(110, 20);
            this.player2TextBox.TabIndex = 2;
            this.player2TextBox.Text = "Player #2";
            // 
            // player1TextBox
            // 
            this.player1TextBox.Location = new System.Drawing.Point(86, 57);
            this.player1TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(110, 20);
            this.player1TextBox.TabIndex = 1;
            this.player1TextBox.Text = "Player #1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.AutoSize = true;
            this.statusLabel1.Location = new System.Drawing.Point(107, 11);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(106, 13);
            this.statusLabel1.TabIndex = 0;
            this.statusLabel1.Text = "Current Player: Black";
            // 
            // informationPanelMenuStrip
            // 
            this.informationPanelMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.informationPanelMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.informationPanelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.informationPanelMenuStrip.Name = "informationPanelMenuStrip";
            this.informationPanelMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.informationPanelMenuStrip.Size = new System.Drawing.Size(404, 24);
            this.informationPanelMenuStrip.TabIndex = 1;
            this.informationPanelMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameTab,
            this.saveGameTab});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Game";
            // 
            // newGameTab
            // 
            this.newGameTab.Name = "newGameTab";
            this.newGameTab.Size = new System.Drawing.Size(132, 22);
            this.newGameTab.Text = "New Game";
            this.newGameTab.Click += new System.EventHandler(this.newGameTab_Click);
            // 
            // saveGameTab
            // 
            this.saveGameTab.Name = "saveGameTab";
            this.saveGameTab.Size = new System.Drawing.Size(132, 22);
            this.saveGameTab.Text = "Save Game";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationPanelToolStripMenuItem,
            this.speakToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // informationPanelToolStripMenuItem
            // 
            this.informationPanelToolStripMenuItem.Checked = true;
            this.informationPanelToolStripMenuItem.CheckOnClick = true;
            this.informationPanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.informationPanelToolStripMenuItem.Name = "informationPanelToolStripMenuItem";
            this.informationPanelToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.informationPanelToolStripMenuItem.Text = "Information Panel";
            // 
            // speakToolStripMenuItem
            // 
            this.speakToolStripMenuItem.Name = "speakToolStripMenuItem";
            this.speakToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.speakToolStripMenuItem.Text = "Speak";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // player2CounterBox
            // 
            this.player2CounterBox.BackgroundImage = global::ONeilloGameV3.Properties.Resources.white_on_square;
            this.player2CounterBox.InitialImage = global::ONeilloGameV3.Properties.Resources.white_counter;
            this.player2CounterBox.Location = new System.Drawing.Point(201, 17);
            this.player2CounterBox.Name = "player2CounterBox";
            this.player2CounterBox.Size = new System.Drawing.Size(60, 60);
            this.player2CounterBox.TabIndex = 8;
            this.player2CounterBox.TabStop = false;
            // 
            // player1CounterBox
            // 
            this.player1CounterBox.BackgroundImage = global::ONeilloGameV3.Properties.Resources.black_on_square;
            this.player1CounterBox.InitialImage = global::ONeilloGameV3.Properties.Resources.black_counter;
            this.player1CounterBox.Location = new System.Drawing.Point(6, 17);
            this.player1CounterBox.Name = "player1CounterBox";
            this.player1CounterBox.Size = new System.Drawing.Size(60, 60);
            this.player1CounterBox.TabIndex = 7;
            this.player1CounterBox.TabStop = false;
            // 
            // player2PictureBox
            // 
            this.player2PictureBox.BackgroundImage = global::ONeilloGameV3.Properties.Resources.playerturn;
            this.player2PictureBox.Location = new System.Drawing.Point(286, 4);
            this.player2PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.player2PictureBox.Name = "player2PictureBox";
            this.player2PictureBox.Size = new System.Drawing.Size(101, 53);
            this.player2PictureBox.TabIndex = 6;
            this.player2PictureBox.TabStop = false;
            this.player2PictureBox.Visible = false;
            // 
            // player1PictureBox
            // 
            this.player1PictureBox.BackgroundImage = global::ONeilloGameV3.Properties.Resources.playerturn;
            this.player1PictureBox.Location = new System.Drawing.Point(95, 2);
            this.player1PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.player1PictureBox.Name = "player1PictureBox";
            this.player1PictureBox.Size = new System.Drawing.Size(101, 55);
            this.player1PictureBox.TabIndex = 5;
            this.player1PictureBox.TabStop = false;
            this.player1PictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 561);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.informationPanelMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.informationPanelMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ONeillo V3";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.informationPanelMenuStrip.ResumeLayout(false);
            this.informationPanelMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2CounterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1CounterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label statusLabel1;
        private System.Windows.Forms.MenuStrip informationPanelMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGameTab;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameTab;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakToolStripMenuItem;
        private System.Windows.Forms.TextBox player2TextBox;
        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.PictureBox player1PictureBox;
        private System.Windows.Forms.PictureBox player2PictureBox;
        private System.Windows.Forms.PictureBox player2CounterBox;
        private System.Windows.Forms.PictureBox player1CounterBox;
    }
}

