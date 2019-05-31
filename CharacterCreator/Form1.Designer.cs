namespace CharacterCreator
{
    partial class frmMain
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
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblAgility = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.btnStrengthPlus = new System.Windows.Forms.Button();
            this.btnStrengthMinus = new System.Windows.Forms.Button();
            this.btnAgilityMinus = new System.Windows.Forms.Button();
            this.btnAgilityPlus = new System.Windows.Forms.Button();
            this.btnIntelligenceMinus = new System.Windows.Forms.Button();
            this.btnIntelligencePlus = new System.Windows.Forms.Button();
            this.lblStrengthCount = new System.Windows.Forms.Label();
            this.lblAgilityCount = new System.Windows.Forms.Label();
            this.lblIntelligenceCount = new System.Windows.Forms.Label();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLastImage = new System.Windows.Forms.Button();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblRace = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.cbRandomName = new System.Windows.Forms.CheckBox();
            this.cbRandomGender = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(328, 40);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(47, 13);
            this.lblStrength.TabIndex = 3;
            this.lblStrength.Text = "Strength";
            this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgility
            // 
            this.lblAgility.AutoSize = true;
            this.lblAgility.Location = new System.Drawing.Point(328, 66);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(34, 13);
            this.lblAgility.TabIndex = 4;
            this.lblAgility.Text = "Agility";
            this.lblAgility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(328, 94);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(61, 13);
            this.lblIntelligence.TabIndex = 5;
            this.lblIntelligence.Text = "Intelligence";
            this.lblIntelligence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStrengthPlus
            // 
            this.btnStrengthPlus.Location = new System.Drawing.Point(448, 38);
            this.btnStrengthPlus.Name = "btnStrengthPlus";
            this.btnStrengthPlus.Size = new System.Drawing.Size(22, 22);
            this.btnStrengthPlus.TabIndex = 6;
            this.btnStrengthPlus.Text = ">";
            this.btnStrengthPlus.UseVisualStyleBackColor = true;
            this.btnStrengthPlus.Click += new System.EventHandler(this.BtnStrengthPlus_Click);
            // 
            // btnStrengthMinus
            // 
            this.btnStrengthMinus.Location = new System.Drawing.Point(402, 38);
            this.btnStrengthMinus.Name = "btnStrengthMinus";
            this.btnStrengthMinus.Size = new System.Drawing.Size(22, 22);
            this.btnStrengthMinus.TabIndex = 7;
            this.btnStrengthMinus.Text = "<";
            this.btnStrengthMinus.UseVisualStyleBackColor = true;
            this.btnStrengthMinus.Click += new System.EventHandler(this.BtnStrengthMinus_Click);
            // 
            // btnAgilityMinus
            // 
            this.btnAgilityMinus.Location = new System.Drawing.Point(402, 64);
            this.btnAgilityMinus.Name = "btnAgilityMinus";
            this.btnAgilityMinus.Size = new System.Drawing.Size(22, 22);
            this.btnAgilityMinus.TabIndex = 9;
            this.btnAgilityMinus.Text = "<";
            this.btnAgilityMinus.UseVisualStyleBackColor = true;
            this.btnAgilityMinus.Click += new System.EventHandler(this.BtnAgilityMinus_Click);
            // 
            // btnAgilityPlus
            // 
            this.btnAgilityPlus.Location = new System.Drawing.Point(448, 64);
            this.btnAgilityPlus.Name = "btnAgilityPlus";
            this.btnAgilityPlus.Size = new System.Drawing.Size(22, 22);
            this.btnAgilityPlus.TabIndex = 8;
            this.btnAgilityPlus.Text = ">";
            this.btnAgilityPlus.UseVisualStyleBackColor = true;
            this.btnAgilityPlus.Click += new System.EventHandler(this.BtnAgilityPlus_Click);
            // 
            // btnIntelligenceMinus
            // 
            this.btnIntelligenceMinus.Location = new System.Drawing.Point(402, 90);
            this.btnIntelligenceMinus.Name = "btnIntelligenceMinus";
            this.btnIntelligenceMinus.Size = new System.Drawing.Size(22, 22);
            this.btnIntelligenceMinus.TabIndex = 11;
            this.btnIntelligenceMinus.Text = "<";
            this.btnIntelligenceMinus.UseVisualStyleBackColor = true;
            this.btnIntelligenceMinus.Click += new System.EventHandler(this.BtnIntelligenceMinus_Click);
            // 
            // btnIntelligencePlus
            // 
            this.btnIntelligencePlus.Location = new System.Drawing.Point(448, 90);
            this.btnIntelligencePlus.Name = "btnIntelligencePlus";
            this.btnIntelligencePlus.Size = new System.Drawing.Size(22, 22);
            this.btnIntelligencePlus.TabIndex = 10;
            this.btnIntelligencePlus.Text = ">";
            this.btnIntelligencePlus.UseVisualStyleBackColor = true;
            this.btnIntelligencePlus.Click += new System.EventHandler(this.BtnIntelligencePlus_Click);
            // 
            // lblStrengthCount
            // 
            this.lblStrengthCount.AutoSize = true;
            this.lblStrengthCount.Location = new System.Drawing.Point(430, 42);
            this.lblStrengthCount.Name = "lblStrengthCount";
            this.lblStrengthCount.Size = new System.Drawing.Size(13, 13);
            this.lblStrengthCount.TabIndex = 12;
            this.lblStrengthCount.Text = "5";
            // 
            // lblAgilityCount
            // 
            this.lblAgilityCount.AutoSize = true;
            this.lblAgilityCount.Location = new System.Drawing.Point(430, 68);
            this.lblAgilityCount.Name = "lblAgilityCount";
            this.lblAgilityCount.Size = new System.Drawing.Size(13, 13);
            this.lblAgilityCount.TabIndex = 13;
            this.lblAgilityCount.Text = "5";
            // 
            // lblIntelligenceCount
            // 
            this.lblIntelligenceCount.AutoSize = true;
            this.lblIntelligenceCount.Location = new System.Drawing.Point(430, 94);
            this.lblIntelligenceCount.Name = "lblIntelligenceCount";
            this.lblIntelligenceCount.Size = new System.Drawing.Size(13, 13);
            this.lblIntelligenceCount.TabIndex = 14;
            this.lblIntelligenceCount.Text = "5";
            // 
            // pbCharacter
            // 
            this.pbCharacter.Location = new System.Drawing.Point(162, 38);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(160, 160);
            this.pbCharacter.TabIndex = 15;
            this.pbCharacter.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(14, 69);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 16;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sfd
            // 
            this.sfd.InitialDirectory = "C:\\";
            this.sfd.Title = "Save Character";
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.Sfd_FileOk);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(482, 24);
            this.menuStrip.TabIndex = 28;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // btnLastImage
            // 
            this.btnLastImage.Location = new System.Drawing.Point(132, 174);
            this.btnLastImage.Name = "btnLastImage";
            this.btnLastImage.Size = new System.Drawing.Size(24, 24);
            this.btnLastImage.TabIndex = 29;
            this.btnLastImage.Text = "<";
            this.btnLastImage.UseVisualStyleBackColor = true;
            this.btnLastImage.Click += new System.EventHandler(this.BtnLastImage_Click);
            // 
            // btnNextImage
            // 
            this.btnNextImage.Location = new System.Drawing.Point(328, 174);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(24, 24);
            this.btnNextImage.TabIndex = 30;
            this.btnNextImage.Text = ">";
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.BtnNextImage_Click);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(81, 64);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(75, 21);
            this.cbGender.TabIndex = 31;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.CbGender_SelectedIndexChanged);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(81, 38);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(75, 20);
            this.txtBoxName.TabIndex = 32;
            this.txtBoxName.TextChanged += new System.EventHandler(this.TxtBoxName_TextChanged);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(162, 204);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(160, 19);
            this.btnRandom.TabIndex = 33;
            this.btnRandom.Text = "Create Random Character";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(14, 98);
            this.lblRace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 34;
            this.lblRace.Text = "Race";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(341, 235);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(6, 6);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // cbRace
            // 
            this.cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwarf"});
            this.cbRace.Location = new System.Drawing.Point(81, 95);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(75, 21);
            this.cbRace.TabIndex = 36;
            this.cbRace.SelectedIndexChanged += new System.EventHandler(this.CbRace_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(14, 124);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 37;
            this.lblClass.Text = "Class";
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "Wizard",
            "Archer",
            "Warrior"});
            this.cbClass.Location = new System.Drawing.Point(82, 124);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(75, 21);
            this.cbClass.TabIndex = 38;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.CbClass_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(16, 204);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(56, 19);
            this.btnShow.TabIndex = 39;
            this.btnShow.Text = "Show Character";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbRandomName
            // 
            this.cbRandomName.AutoSize = true;
            this.cbRandomName.Location = new System.Drawing.Point(16, 149);
            this.cbRandomName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRandomName.Name = "cbRandomName";
            this.cbRandomName.Size = new System.Drawing.Size(95, 17);
            this.cbRandomName.TabIndex = 40;
            this.cbRandomName.Text = "Random name";
            this.cbRandomName.UseVisualStyleBackColor = true;
            // 
            // cbRandomGender
            // 
            this.cbRandomGender.AutoSize = true;
            this.cbRandomGender.Location = new System.Drawing.Point(16, 174);
            this.cbRandomGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRandomGender.Name = "cbRandomGender";
            this.cbRandomGender.Size = new System.Drawing.Size(102, 17);
            this.cbRandomGender.TabIndex = 41;
            this.cbRandomGender.Text = "Random gender";
            this.cbRandomGender.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 246);
            this.Controls.Add(this.cbRandomGender);
            this.Controls.Add(this.cbRandomName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cbRace);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.btnLastImage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.lblIntelligenceCount);
            this.Controls.Add(this.lblAgilityCount);
            this.Controls.Add(this.lblStrengthCount);
            this.Controls.Add(this.btnIntelligenceMinus);
            this.Controls.Add(this.btnIntelligencePlus);
            this.Controls.Add(this.btnAgilityMinus);
            this.Controls.Add(this.btnAgilityPlus);
            this.Controls.Add(this.btnStrengthMinus);
            this.Controls.Add(this.btnStrengthPlus);
            this.Controls.Add(this.lblIntelligence);
            this.Controls.Add(this.lblAgility);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Character Creator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Button btnStrengthPlus;
        private System.Windows.Forms.Button btnStrengthMinus;
        private System.Windows.Forms.Button btnAgilityMinus;
        private System.Windows.Forms.Button btnAgilityPlus;
        private System.Windows.Forms.Button btnIntelligenceMinus;
        private System.Windows.Forms.Button btnIntelligencePlus;
        private System.Windows.Forms.Label lblStrengthCount;
        private System.Windows.Forms.Label lblAgilityCount;
        private System.Windows.Forms.Label lblIntelligenceCount;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button btnLastImage;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox cbRandomName;
        private System.Windows.Forms.CheckBox cbRandomGender;
    }
}

