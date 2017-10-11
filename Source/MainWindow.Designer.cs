namespace SpawnsetCreator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.EnemyList = new System.Windows.Forms.ListView();
            this.TimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnemyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delayColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelSpawnTime = new System.Windows.Forms.Label();
            this.RemoveEnemyButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.watToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.RemoveAllButton = new System.Windows.Forms.Button();
            this.spawnsetSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.shrinkRateLabel = new System.Windows.Forms.Label();
            this.shrinkStartRadiusLabel = new System.Windows.Forms.Label();
            this.shrinkFinalLabel = new System.Windows.Forms.Label();
            this.brightnessNumeric = new System.Windows.Forms.NumericUpDown();
            this.shrinkRateNumeric = new System.Windows.Forms.NumericUpDown();
            this.shrinkStartNumeric = new System.Windows.Forms.NumericUpDown();
            this.shrinkFinalNumeric = new System.Windows.Forms.NumericUpDown();
            this.spawnDelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.spawnsetStatsGroupbox = new System.Windows.Forms.GroupBox();
            this.numGemsTextbox = new System.Windows.Forms.TextBox();
            this.numSpawnsTextbox = new System.Windows.Forms.TextBox();
            this.numGemsLabel = new System.Windows.Forms.Label();
            this.numSpawnsLabel = new System.Windows.Forms.Label();
            this.spawnsGroupbox = new System.Windows.Forms.GroupBox();
            this.spider2SpawnButton = new System.Windows.Forms.Button();
            this.nothingSpawnButton = new System.Windows.Forms.Button();
            this.thornSpawnButton = new System.Windows.Forms.Button();
            this.leviathanSpawnButton = new System.Windows.Forms.Button();
            this.spider1SpawnButton = new System.Windows.Forms.Button();
            this.ghostpedeSpawnButton = new System.Windows.Forms.Button();
            this.gigapedeSpawnButton = new System.Windows.Forms.Button();
            this.centipedeSpawnButton = new System.Windows.Forms.Button();
            this.squid3SpawnButton = new System.Windows.Forms.Button();
            this.squid2SpawnButton = new System.Windows.Forms.Button();
            this.squid1SpawnButton = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNoteFromSojkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.spawnsetSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrinkRateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrinkStartNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrinkFinalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnDelayNumeric)).BeginInit();
            this.spawnsetStatsGroupbox.SuspendLayout();
            this.spawnsGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnemyList
            // 
            this.EnemyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnemyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeColumnHeader,
            this.EnemyColumnHeader,
            this.delayColumn});
            this.EnemyList.Location = new System.Drawing.Point(31, 142);
            this.EnemyList.Name = "EnemyList";
            this.EnemyList.Size = new System.Drawing.Size(298, 475);
            this.EnemyList.TabIndex = 1;
            this.EnemyList.UseCompatibleStateImageBehavior = false;
            this.EnemyList.View = System.Windows.Forms.View.Details;
            // 
            // TimeColumnHeader
            // 
            this.TimeColumnHeader.Text = "Time";
            this.TimeColumnHeader.Width = 76;
            // 
            // EnemyColumnHeader
            // 
            this.EnemyColumnHeader.Text = "Enemy";
            this.EnemyColumnHeader.Width = 140;
            // 
            // delayColumn
            // 
            this.delayColumn.Text = "Delay";
            this.delayColumn.Width = 77;
            // 
            // LabelSpawnTime
            // 
            this.LabelSpawnTime.AutoSize = true;
            this.LabelSpawnTime.Location = new System.Drawing.Point(27, 337);
            this.LabelSpawnTime.Name = "LabelSpawnTime";
            this.LabelSpawnTime.Size = new System.Drawing.Size(70, 13);
            this.LabelSpawnTime.TabIndex = 3;
            this.LabelSpawnTime.Text = "Spawn Delay";
            // 
            // RemoveEnemyButton
            // 
            this.RemoveEnemyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveEnemyButton.Location = new System.Drawing.Point(31, 639);
            this.RemoveEnemyButton.Name = "RemoveEnemyButton";
            this.RemoveEnemyButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveEnemyButton.TabIndex = 6;
            this.RemoveEnemyButton.Text = "Remove Spawn";
            this.RemoveEnemyButton.UseVisualStyleBackColor = true;
            this.RemoveEnemyButton.Click += new System.EventHandler(this.RemoveEnemyButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // watToolStripMenuItem
            // 
            this.watToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.exportFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.watToolStripMenuItem.Name = "watToolStripMenuItem";
            this.watToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.watToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadFileToolStripMenuItem.Text = "Load file";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportFileToolStripMenuItem.Text = "Save File";
            this.exportFileToolStripMenuItem.Click += new System.EventHandler(this.exportFileToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // RemoveAllButton
            // 
            this.RemoveAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveAllButton.Location = new System.Drawing.Point(254, 639);
            this.RemoveAllButton.Name = "RemoveAllButton";
            this.RemoveAllButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveAllButton.TabIndex = 8;
            this.RemoveAllButton.Text = "Remove All";
            this.RemoveAllButton.UseVisualStyleBackColor = true;
            this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
            // 
            // spawnsetSettingsGroupBox
            // 
            this.spawnsetSettingsGroupBox.Controls.Add(this.brightnessLabel);
            this.spawnsetSettingsGroupBox.Controls.Add(this.shrinkRateLabel);
            this.spawnsetSettingsGroupBox.Controls.Add(this.shrinkStartRadiusLabel);
            this.spawnsetSettingsGroupBox.Controls.Add(this.shrinkFinalLabel);
            this.spawnsetSettingsGroupBox.Controls.Add(this.brightnessNumeric);
            this.spawnsetSettingsGroupBox.Controls.Add(this.shrinkRateNumeric);
            this.spawnsetSettingsGroupBox.Controls.Add(this.shrinkStartNumeric);
            this.spawnsetSettingsGroupBox.Controls.Add(this.shrinkFinalNumeric);
            this.spawnsetSettingsGroupBox.Location = new System.Drawing.Point(382, 444);
            this.spawnsetSettingsGroupBox.Name = "spawnsetSettingsGroupBox";
            this.spawnsetSettingsGroupBox.Size = new System.Drawing.Size(274, 173);
            this.spawnsetSettingsGroupBox.TabIndex = 9;
            this.spawnsetSettingsGroupBox.TabStop = false;
            this.spawnsetSettingsGroupBox.Text = "Arena Settings";
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(57, 142);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(56, 13);
            this.brightnessLabel.TabIndex = 7;
            this.brightnessLabel.Text = "Brightness";
            // 
            // shrinkRateLabel
            // 
            this.shrinkRateLabel.AutoSize = true;
            this.shrinkRateLabel.Location = new System.Drawing.Point(50, 107);
            this.shrinkRateLabel.Name = "shrinkRateLabel";
            this.shrinkRateLabel.Size = new System.Drawing.Size(63, 13);
            this.shrinkRateLabel.TabIndex = 6;
            this.shrinkRateLabel.Text = "Shrink Rate";
            // 
            // shrinkStartRadiusLabel
            // 
            this.shrinkStartRadiusLabel.AutoSize = true;
            this.shrinkStartRadiusLabel.Location = new System.Drawing.Point(15, 70);
            this.shrinkStartRadiusLabel.Name = "shrinkStartRadiusLabel";
            this.shrinkStartRadiusLabel.Size = new System.Drawing.Size(98, 13);
            this.shrinkStartRadiusLabel.TabIndex = 5;
            this.shrinkStartRadiusLabel.Text = "Shrink Start Radius";
            // 
            // shrinkFinalLabel
            // 
            this.shrinkFinalLabel.AutoSize = true;
            this.shrinkFinalLabel.Location = new System.Drawing.Point(15, 34);
            this.shrinkFinalLabel.Name = "shrinkFinalLabel";
            this.shrinkFinalLabel.Size = new System.Drawing.Size(98, 13);
            this.shrinkFinalLabel.TabIndex = 4;
            this.shrinkFinalLabel.Text = "Shrink Final Radius";
            // 
            // brightnessNumeric
            // 
            this.brightnessNumeric.DecimalPlaces = 4;
            this.brightnessNumeric.Location = new System.Drawing.Point(119, 140);
            this.brightnessNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.brightnessNumeric.Name = "brightnessNumeric";
            this.brightnessNumeric.Size = new System.Drawing.Size(120, 20);
            this.brightnessNumeric.TabIndex = 3;
            this.brightnessNumeric.Tag = "";
            this.brightnessNumeric.ValueChanged += new System.EventHandler(this.brightnessNumeric_ValueChanged);
            // 
            // shrinkRateNumeric
            // 
            this.shrinkRateNumeric.DecimalPlaces = 4;
            this.shrinkRateNumeric.Location = new System.Drawing.Point(119, 105);
            this.shrinkRateNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shrinkRateNumeric.Name = "shrinkRateNumeric";
            this.shrinkRateNumeric.Size = new System.Drawing.Size(120, 20);
            this.shrinkRateNumeric.TabIndex = 2;
            this.shrinkRateNumeric.ValueChanged += new System.EventHandler(this.shrinkRateNumeric_ValueChanged);
            // 
            // shrinkStartNumeric
            // 
            this.shrinkStartNumeric.DecimalPlaces = 4;
            this.shrinkStartNumeric.Location = new System.Drawing.Point(119, 68);
            this.shrinkStartNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shrinkStartNumeric.Name = "shrinkStartNumeric";
            this.shrinkStartNumeric.Size = new System.Drawing.Size(120, 20);
            this.shrinkStartNumeric.TabIndex = 1;
            this.shrinkStartNumeric.ValueChanged += new System.EventHandler(this.shrinkStartNumeric_ValueChanged);
            // 
            // shrinkFinalNumeric
            // 
            this.shrinkFinalNumeric.DecimalPlaces = 4;
            this.shrinkFinalNumeric.Location = new System.Drawing.Point(119, 32);
            this.shrinkFinalNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shrinkFinalNumeric.Name = "shrinkFinalNumeric";
            this.shrinkFinalNumeric.Size = new System.Drawing.Size(120, 20);
            this.shrinkFinalNumeric.TabIndex = 0;
            this.shrinkFinalNumeric.ValueChanged += new System.EventHandler(this.shrinkFinalNumeric_ValueChanged);
            // 
            // spawnDelayNumeric
            // 
            this.spawnDelayNumeric.DecimalPlaces = 4;
            this.spawnDelayNumeric.Location = new System.Drawing.Point(119, 335);
            this.spawnDelayNumeric.Name = "spawnDelayNumeric";
            this.spawnDelayNumeric.Size = new System.Drawing.Size(120, 20);
            this.spawnDelayNumeric.TabIndex = 10;
            // 
            // spawnsetStatsGroupbox
            // 
            this.spawnsetStatsGroupbox.Controls.Add(this.numGemsTextbox);
            this.spawnsetStatsGroupbox.Controls.Add(this.numSpawnsTextbox);
            this.spawnsetStatsGroupbox.Controls.Add(this.numGemsLabel);
            this.spawnsetStatsGroupbox.Controls.Add(this.numSpawnsLabel);
            this.spawnsetStatsGroupbox.Location = new System.Drawing.Point(31, 37);
            this.spawnsetStatsGroupbox.Name = "spawnsetStatsGroupbox";
            this.spawnsetStatsGroupbox.Size = new System.Drawing.Size(298, 98);
            this.spawnsetStatsGroupbox.TabIndex = 11;
            this.spawnsetStatsGroupbox.TabStop = false;
            this.spawnsetStatsGroupbox.Text = "Spawnset Stats";
            // 
            // numGemsTextbox
            // 
            this.numGemsTextbox.Location = new System.Drawing.Point(139, 67);
            this.numGemsTextbox.Name = "numGemsTextbox";
            this.numGemsTextbox.Size = new System.Drawing.Size(100, 20);
            this.numGemsTextbox.TabIndex = 3;
            // 
            // numSpawnsTextbox
            // 
            this.numSpawnsTextbox.Location = new System.Drawing.Point(139, 32);
            this.numSpawnsTextbox.Name = "numSpawnsTextbox";
            this.numSpawnsTextbox.Size = new System.Drawing.Size(100, 20);
            this.numSpawnsTextbox.TabIndex = 2;
            // 
            // numGemsLabel
            // 
            this.numGemsLabel.AutoSize = true;
            this.numGemsLabel.Location = new System.Drawing.Point(61, 67);
            this.numGemsLabel.Name = "numGemsLabel";
            this.numGemsLabel.Size = new System.Drawing.Size(64, 13);
            this.numGemsLabel.TabIndex = 1;
            this.numGemsLabel.Text = "Total Gems:";
            // 
            // numSpawnsLabel
            // 
            this.numSpawnsLabel.AutoSize = true;
            this.numSpawnsLabel.Location = new System.Drawing.Point(50, 35);
            this.numSpawnsLabel.Name = "numSpawnsLabel";
            this.numSpawnsLabel.Size = new System.Drawing.Size(75, 13);
            this.numSpawnsLabel.TabIndex = 0;
            this.numSpawnsLabel.Text = "Total Spawns:";
            // 
            // spawnsGroupbox
            // 
            this.spawnsGroupbox.Controls.Add(this.spider2SpawnButton);
            this.spawnsGroupbox.Controls.Add(this.nothingSpawnButton);
            this.spawnsGroupbox.Controls.Add(this.spawnDelayNumeric);
            this.spawnsGroupbox.Controls.Add(this.thornSpawnButton);
            this.spawnsGroupbox.Controls.Add(this.leviathanSpawnButton);
            this.spawnsGroupbox.Controls.Add(this.spider1SpawnButton);
            this.spawnsGroupbox.Controls.Add(this.ghostpedeSpawnButton);
            this.spawnsGroupbox.Controls.Add(this.LabelSpawnTime);
            this.spawnsGroupbox.Controls.Add(this.gigapedeSpawnButton);
            this.spawnsGroupbox.Controls.Add(this.centipedeSpawnButton);
            this.spawnsGroupbox.Controls.Add(this.squid3SpawnButton);
            this.spawnsGroupbox.Controls.Add(this.squid2SpawnButton);
            this.spawnsGroupbox.Controls.Add(this.squid1SpawnButton);
            this.spawnsGroupbox.Location = new System.Drawing.Point(382, 37);
            this.spawnsGroupbox.Name = "spawnsGroupbox";
            this.spawnsGroupbox.Size = new System.Drawing.Size(387, 375);
            this.spawnsGroupbox.TabIndex = 12;
            this.spawnsGroupbox.TabStop = false;
            this.spawnsGroupbox.Text = "Enemies";
            // 
            // spider2SpawnButton
            // 
            this.spider2SpawnButton.Location = new System.Drawing.Point(140, 180);
            this.spider2SpawnButton.Name = "spider2SpawnButton";
            this.spider2SpawnButton.Size = new System.Drawing.Size(82, 50);
            this.spider2SpawnButton.TabIndex = 2;
            this.spider2SpawnButton.Text = "SPIDER II";
            this.spider2SpawnButton.UseVisualStyleBackColor = true;
            this.spider2SpawnButton.Click += new System.EventHandler(this.spider2SpawnButton_Click);
            // 
            // nothingSpawnButton
            // 
            this.nothingSpawnButton.Location = new System.Drawing.Point(250, 255);
            this.nothingSpawnButton.Name = "nothingSpawnButton";
            this.nothingSpawnButton.Size = new System.Drawing.Size(82, 50);
            this.nothingSpawnButton.TabIndex = 2;
            this.nothingSpawnButton.Text = "NOTHING";
            this.nothingSpawnButton.UseVisualStyleBackColor = true;
            this.nothingSpawnButton.Click += new System.EventHandler(this.nothingSpawnButton_Click);
            // 
            // thornSpawnButton
            // 
            this.thornSpawnButton.Location = new System.Drawing.Point(140, 255);
            this.thornSpawnButton.Name = "thornSpawnButton";
            this.thornSpawnButton.Size = new System.Drawing.Size(82, 50);
            this.thornSpawnButton.TabIndex = 2;
            this.thornSpawnButton.Text = "THORN";
            this.thornSpawnButton.UseVisualStyleBackColor = true;
            this.thornSpawnButton.Click += new System.EventHandler(this.thornSpawnButton_Click);
            // 
            // leviathanSpawnButton
            // 
            this.leviathanSpawnButton.Location = new System.Drawing.Point(30, 255);
            this.leviathanSpawnButton.Name = "leviathanSpawnButton";
            this.leviathanSpawnButton.Size = new System.Drawing.Size(82, 50);
            this.leviathanSpawnButton.TabIndex = 2;
            this.leviathanSpawnButton.Text = "LEVIATHAN";
            this.leviathanSpawnButton.UseVisualStyleBackColor = true;
            this.leviathanSpawnButton.Click += new System.EventHandler(this.leviathanSpawnButton_Click);
            // 
            // spider1SpawnButton
            // 
            this.spider1SpawnButton.Location = new System.Drawing.Point(30, 180);
            this.spider1SpawnButton.Name = "spider1SpawnButton";
            this.spider1SpawnButton.Size = new System.Drawing.Size(82, 50);
            this.spider1SpawnButton.TabIndex = 2;
            this.spider1SpawnButton.Text = "SPIDER I";
            this.spider1SpawnButton.UseVisualStyleBackColor = true;
            this.spider1SpawnButton.Click += new System.EventHandler(this.spider1SpawnButton_Click);
            // 
            // ghostpedeSpawnButton
            // 
            this.ghostpedeSpawnButton.Location = new System.Drawing.Point(250, 105);
            this.ghostpedeSpawnButton.Name = "ghostpedeSpawnButton";
            this.ghostpedeSpawnButton.Size = new System.Drawing.Size(82, 50);
            this.ghostpedeSpawnButton.TabIndex = 2;
            this.ghostpedeSpawnButton.Text = "GHOSTPEDE";
            this.ghostpedeSpawnButton.UseVisualStyleBackColor = true;
            this.ghostpedeSpawnButton.Click += new System.EventHandler(this.ghostpedeSpawnButton_Click);
            // 
            // gigapedeSpawnButton
            // 
            this.gigapedeSpawnButton.Location = new System.Drawing.Point(140, 105);
            this.gigapedeSpawnButton.Name = "gigapedeSpawnButton";
            this.gigapedeSpawnButton.Size = new System.Drawing.Size(82, 50);
            this.gigapedeSpawnButton.TabIndex = 2;
            this.gigapedeSpawnButton.Text = "GIGAPEDE";
            this.gigapedeSpawnButton.UseVisualStyleBackColor = true;
            this.gigapedeSpawnButton.Click += new System.EventHandler(this.gigapedeSpawnButton_Click);
            // 
            // centipedeSpawnButton
            // 
            this.centipedeSpawnButton.Location = new System.Drawing.Point(30, 105);
            this.centipedeSpawnButton.Name = "centipedeSpawnButton";
            this.centipedeSpawnButton.Size = new System.Drawing.Size(82, 50);
            this.centipedeSpawnButton.TabIndex = 2;
            this.centipedeSpawnButton.Text = "CENTIPEDE";
            this.centipedeSpawnButton.UseVisualStyleBackColor = true;
            this.centipedeSpawnButton.Click += new System.EventHandler(this.centipedeSpawnButton_Click);
            // 
            // squid3SpawnButton
            // 
            this.squid3SpawnButton.Location = new System.Drawing.Point(250, 30);
            this.squid3SpawnButton.Name = "squid3SpawnButton";
            this.squid3SpawnButton.Size = new System.Drawing.Size(82, 50);
            this.squid3SpawnButton.TabIndex = 2;
            this.squid3SpawnButton.Text = "SQUID III";
            this.squid3SpawnButton.UseVisualStyleBackColor = true;
            this.squid3SpawnButton.Click += new System.EventHandler(this.squid3SpawnButton_Click);
            // 
            // squid2SpawnButton
            // 
            this.squid2SpawnButton.Location = new System.Drawing.Point(140, 30);
            this.squid2SpawnButton.Name = "squid2SpawnButton";
            this.squid2SpawnButton.Size = new System.Drawing.Size(82, 50);
            this.squid2SpawnButton.TabIndex = 1;
            this.squid2SpawnButton.Text = "SQUID II";
            this.squid2SpawnButton.UseVisualStyleBackColor = true;
            this.squid2SpawnButton.Click += new System.EventHandler(this.squid2SpawnButton_Click);
            // 
            // squid1SpawnButton
            // 
            this.squid1SpawnButton.Location = new System.Drawing.Point(30, 30);
            this.squid1SpawnButton.Name = "squid1SpawnButton";
            this.squid1SpawnButton.Size = new System.Drawing.Size(82, 50);
            this.squid1SpawnButton.TabIndex = 0;
            this.squid1SpawnButton.Text = "SQUID I";
            this.squid1SpawnButton.UseVisualStyleBackColor = true;
            this.squid1SpawnButton.Click += new System.EventHandler(this.squid1SpawnButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNoteFromSojkToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aNoteFromSojkToolStripMenuItem
            // 
            this.aNoteFromSojkToolStripMenuItem.Name = "aNoteFromSojkToolStripMenuItem";
            this.aNoteFromSojkToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aNoteFromSojkToolStripMenuItem.Text = "A note from Sojk";
            this.aNoteFromSojkToolStripMenuItem.Click += new System.EventHandler(this.aNoteFromSojkToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(815, 693);
            this.Controls.Add(this.spawnsGroupbox);
            this.Controls.Add(this.spawnsetStatsGroupbox);
            this.Controls.Add(this.spawnsetSettingsGroupBox);
            this.Controls.Add(this.RemoveAllButton);
            this.Controls.Add(this.RemoveEnemyButton);
            this.Controls.Add(this.EnemyList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Spawnset Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.spawnsetSettingsGroupBox.ResumeLayout(false);
            this.spawnsetSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrinkRateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrinkStartNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrinkFinalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnDelayNumeric)).EndInit();
            this.spawnsetStatsGroupbox.ResumeLayout(false);
            this.spawnsetStatsGroupbox.PerformLayout();
            this.spawnsGroupbox.ResumeLayout(false);
            this.spawnsGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView EnemyList;
        private System.Windows.Forms.Label LabelSpawnTime;
        private System.Windows.Forms.ColumnHeader TimeColumnHeader;
        private System.Windows.Forms.ColumnHeader EnemyColumnHeader;
        private System.Windows.Forms.Button RemoveEnemyButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem watToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.ColumnHeader delayColumn;
        private System.Windows.Forms.Button RemoveAllButton;
        private System.Windows.Forms.GroupBox spawnsetSettingsGroupBox;
        private System.Windows.Forms.NumericUpDown spawnDelayNumeric;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label shrinkRateLabel;
        private System.Windows.Forms.Label shrinkStartRadiusLabel;
        private System.Windows.Forms.Label shrinkFinalLabel;
        private System.Windows.Forms.NumericUpDown brightnessNumeric;
        private System.Windows.Forms.NumericUpDown shrinkRateNumeric;
        private System.Windows.Forms.NumericUpDown shrinkStartNumeric;
        private System.Windows.Forms.NumericUpDown shrinkFinalNumeric;
        private System.Windows.Forms.GroupBox spawnsetStatsGroupbox;
        private System.Windows.Forms.TextBox numGemsTextbox;
        private System.Windows.Forms.TextBox numSpawnsTextbox;
        private System.Windows.Forms.Label numGemsLabel;
        private System.Windows.Forms.Label numSpawnsLabel;
        private System.Windows.Forms.GroupBox spawnsGroupbox;
        private System.Windows.Forms.Button squid3SpawnButton;
        private System.Windows.Forms.Button squid2SpawnButton;
        private System.Windows.Forms.Button squid1SpawnButton;
        private System.Windows.Forms.Button spider2SpawnButton;
        private System.Windows.Forms.Button leviathanSpawnButton;
        private System.Windows.Forms.Button spider1SpawnButton;
        private System.Windows.Forms.Button ghostpedeSpawnButton;
        private System.Windows.Forms.Button gigapedeSpawnButton;
        private System.Windows.Forms.Button centipedeSpawnButton;
        private System.Windows.Forms.Button nothingSpawnButton;
        private System.Windows.Forms.Button thornSpawnButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNoteFromSojkToolStripMenuItem;
    }
}