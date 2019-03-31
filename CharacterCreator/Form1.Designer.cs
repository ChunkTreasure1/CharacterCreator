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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.lblIntelligence.Location = new System.Drawing.Point(328, 92);
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
            this.btnStrengthMinus.Location = new System.Drawing.Point(395, 38);
            this.btnStrengthMinus.Name = "btnStrengthMinus";
            this.btnStrengthMinus.Size = new System.Drawing.Size(22, 22);
            this.btnStrengthMinus.TabIndex = 7;
            this.btnStrengthMinus.Text = "<";
            this.btnStrengthMinus.UseVisualStyleBackColor = true;
            this.btnStrengthMinus.Click += new System.EventHandler(this.BtnStrengthMinus_Click);
            // 
            // btnAgilityMinus
            // 
            this.btnAgilityMinus.Location = new System.Drawing.Point(395, 64);
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
            this.btnIntelligenceMinus.Location = new System.Drawing.Point(395, 90);
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
            this.lblStrengthCount.Location = new System.Drawing.Point(423, 43);
            this.lblStrengthCount.Name = "lblStrengthCount";
            this.lblStrengthCount.Size = new System.Drawing.Size(19, 13);
            this.lblStrengthCount.TabIndex = 12;
            this.lblStrengthCount.Text = "10";
            // 
            // lblAgilityCount
            // 
            this.lblAgilityCount.AutoSize = true;
            this.lblAgilityCount.Location = new System.Drawing.Point(423, 69);
            this.lblAgilityCount.Name = "lblAgilityCount";
            this.lblAgilityCount.Size = new System.Drawing.Size(19, 13);
            this.lblAgilityCount.TabIndex = 13;
            this.lblAgilityCount.Text = "10";
            // 
            // lblIntelligenceCount
            // 
            this.lblIntelligenceCount.AutoSize = true;
            this.lblIntelligenceCount.Location = new System.Drawing.Point(423, 95);
            this.lblIntelligenceCount.Name = "lblIntelligenceCount";
            this.lblIntelligenceCount.Size = new System.Drawing.Size(19, 13);
            this.lblIntelligenceCount.TabIndex = 14;
            this.lblIntelligenceCount.Text = "10";
            // 
            // pbCharacter
            // 
            this.pbCharacter.Location = new System.Drawing.Point(162, 38);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(160, 160);
            this.pbCharacter.TabIndex = 15;
            this.pbCharacter.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 24;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 23;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Intelligence";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // menuStrip
            // 
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 650);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.btnLastImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
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
    }
}

