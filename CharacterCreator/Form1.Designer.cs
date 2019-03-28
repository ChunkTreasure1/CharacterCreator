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
            this.button2 = new System.Windows.Forms.Button();
            this.lblStrengthCount = new System.Windows.Forms.Label();
            this.lblAgilityCount = new System.Windows.Forms.Label();
            this.lblIntelligenceCount = new System.Windows.Forms.Label();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // 
            // btnStrengthMinus
            // 
            this.btnStrengthMinus.Location = new System.Drawing.Point(395, 38);
            this.btnStrengthMinus.Name = "btnStrengthMinus";
            this.btnStrengthMinus.Size = new System.Drawing.Size(22, 22);
            this.btnStrengthMinus.TabIndex = 7;
            this.btnStrengthMinus.Text = "<";
            this.btnStrengthMinus.UseVisualStyleBackColor = true;
            // 
            // btnAgilityMinus
            // 
            this.btnAgilityMinus.Location = new System.Drawing.Point(395, 64);
            this.btnAgilityMinus.Name = "btnAgilityMinus";
            this.btnAgilityMinus.Size = new System.Drawing.Size(22, 22);
            this.btnAgilityMinus.TabIndex = 9;
            this.btnAgilityMinus.Text = "<";
            this.btnAgilityMinus.UseVisualStyleBackColor = true;
            // 
            // btnAgilityPlus
            // 
            this.btnAgilityPlus.Location = new System.Drawing.Point(448, 64);
            this.btnAgilityPlus.Name = "btnAgilityPlus";
            this.btnAgilityPlus.Size = new System.Drawing.Size(22, 22);
            this.btnAgilityPlus.TabIndex = 8;
            this.btnAgilityPlus.Text = ">";
            this.btnAgilityPlus.UseVisualStyleBackColor = true;
            // 
            // btnIntelligenceMinus
            // 
            this.btnIntelligenceMinus.Location = new System.Drawing.Point(395, 90);
            this.btnIntelligenceMinus.Name = "btnIntelligenceMinus";
            this.btnIntelligenceMinus.Size = new System.Drawing.Size(22, 22);
            this.btnIntelligenceMinus.TabIndex = 11;
            this.btnIntelligenceMinus.Text = "<";
            this.btnIntelligenceMinus.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 10;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "10";
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(81, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 22);
            this.button4.TabIndex = 22;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(134, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 21;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(81, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 22);
            this.button6.TabIndex = 20;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(134, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(22, 22);
            this.button7.TabIndex = 19;
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Agility";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Strength";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.lblIntelligenceCount);
            this.Controls.Add(this.lblAgilityCount);
            this.Controls.Add(this.lblStrengthCount);
            this.Controls.Add(this.btnIntelligenceMinus);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblStrengthCount;
        private System.Windows.Forms.Label lblAgilityCount;
        private System.Windows.Forms.Label lblIntelligenceCount;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

