namespace CharacterCreator
{
    partial class frmShow
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
            this.lblClass = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.lblIntelligenceCount = new System.Windows.Forms.Label();
            this.lblAgilityCount = new System.Windows.Forms.Label();
            this.lblStrengthCount = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblAgility = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblGenderText = new System.Windows.Forms.Label();
            this.lblRaceText = new System.Windows.Forms.Label();
            this.lblClassText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(12, 97);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 64;
            this.lblClass.Text = "Class:";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(12, 72);
            this.lblRace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(36, 13);
            this.lblRace.TabIndex = 61;
            this.lblRace.Text = "Race:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 43);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 53;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCharacter
            // 
            this.pbCharacter.Location = new System.Drawing.Point(143, 12);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(160, 160);
            this.pbCharacter.TabIndex = 52;
            this.pbCharacter.TabStop = false;
            this.pbCharacter.Click += new System.EventHandler(this.PbCharacter_Click);
            // 
            // lblIntelligenceCount
            // 
            this.lblIntelligenceCount.AutoSize = true;
            this.lblIntelligenceCount.Location = new System.Drawing.Point(370, 65);
            this.lblIntelligenceCount.Name = "lblIntelligenceCount";
            this.lblIntelligenceCount.Size = new System.Drawing.Size(19, 13);
            this.lblIntelligenceCount.TabIndex = 51;
            this.lblIntelligenceCount.Text = "10";
            // 
            // lblAgilityCount
            // 
            this.lblAgilityCount.AutoSize = true;
            this.lblAgilityCount.Location = new System.Drawing.Point(370, 39);
            this.lblAgilityCount.Name = "lblAgilityCount";
            this.lblAgilityCount.Size = new System.Drawing.Size(19, 13);
            this.lblAgilityCount.TabIndex = 50;
            this.lblAgilityCount.Text = "10";
            // 
            // lblStrengthCount
            // 
            this.lblStrengthCount.AutoSize = true;
            this.lblStrengthCount.Location = new System.Drawing.Point(370, 13);
            this.lblStrengthCount.Name = "lblStrengthCount";
            this.lblStrengthCount.Size = new System.Drawing.Size(19, 13);
            this.lblStrengthCount.TabIndex = 49;
            this.lblStrengthCount.Text = "10";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(309, 65);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(64, 13);
            this.lblIntelligence.TabIndex = 42;
            this.lblIntelligence.Text = "Intelligence:";
            this.lblIntelligence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgility
            // 
            this.lblAgility.AutoSize = true;
            this.lblAgility.Location = new System.Drawing.Point(309, 39);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(37, 13);
            this.lblAgility.TabIndex = 41;
            this.lblAgility.Text = "Agility:";
            this.lblAgility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(309, 13);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(50, 13);
            this.lblStrength.TabIndex = 40;
            this.lblStrength.Text = "Strength:";
            this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStrength.Click += new System.EventHandler(this.LblStrength_Click);
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Location = new System.Drawing.Point(50, 12);
            this.lblNameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(35, 13);
            this.lblNameText.TabIndex = 65;
            this.lblNameText.Text = "Name";
            // 
            // lblGenderText
            // 
            this.lblGenderText.AutoSize = true;
            this.lblGenderText.Location = new System.Drawing.Point(54, 43);
            this.lblGenderText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenderText.Name = "lblGenderText";
            this.lblGenderText.Size = new System.Drawing.Size(42, 13);
            this.lblGenderText.TabIndex = 66;
            this.lblGenderText.Text = "Gender";
            // 
            // lblRaceText
            // 
            this.lblRaceText.AutoSize = true;
            this.lblRaceText.Location = new System.Drawing.Point(50, 72);
            this.lblRaceText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaceText.Name = "lblRaceText";
            this.lblRaceText.Size = new System.Drawing.Size(33, 13);
            this.lblRaceText.TabIndex = 67;
            this.lblRaceText.Text = "Race";
            // 
            // lblClassText
            // 
            this.lblClassText.AutoSize = true;
            this.lblClassText.Location = new System.Drawing.Point(50, 97);
            this.lblClassText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassText.Name = "lblClassText";
            this.lblClassText.Size = new System.Drawing.Size(32, 13);
            this.lblClassText.TabIndex = 68;
            this.lblClassText.Text = "Class";
            // 
            // frmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 184);
            this.Controls.Add(this.lblClassText);
            this.Controls.Add(this.lblRaceText);
            this.Controls.Add(this.lblGenderText);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.lblIntelligenceCount);
            this.Controls.Add(this.lblAgilityCount);
            this.Controls.Add(this.lblStrengthCount);
            this.Controls.Add(this.lblIntelligence);
            this.Controls.Add(this.lblAgility);
            this.Controls.Add(this.lblStrength);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmShow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.Label lblIntelligenceCount;
        private System.Windows.Forms.Label lblAgilityCount;
        private System.Windows.Forms.Label lblStrengthCount;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblGenderText;
        private System.Windows.Forms.Label lblRaceText;
        private System.Windows.Forms.Label lblClassText;
    }
}