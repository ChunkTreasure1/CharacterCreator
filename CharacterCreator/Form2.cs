using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator.Global;

namespace CharacterCreator
{
    public partial class frmShow : Form
    {
        public frmShow()
        {
            InitializeComponent();
        }

        public void SetName(string name) { lblNameText.Text = name; }
        public void SetGender(Global.Gender gender)
        {
            if (gender == Global.Gender.Male)
            {
                lblGenderText.Text = "Male";
            }
            else if (gender == Global.Gender.Female)
            {
                lblGenderText.Text = "Female";
            }
        }
        public void SetRace(Global.Race race)
        {
            if (race == Race.Human)
            {
                lblRaceText.Text = "Human";
            }
            else if (race == Race.Elf)
            {
                lblRaceText.Text = "Elf";
            }
            else if (race == Race.Dwarf)
            {
                lblRaceText.Text = "Dwarf";
            }
        }
        public void SetClass(Class classT)
        {
            if (classT == Class.Archer)
            {
                lblClassText.Text = "Archer";
            }
            else if (classT == Class.Warrior)
            {
                lblClassText.Text = "Warrior";
            }
            else if (classT == Class.Wizard)
            {
                lblClassText.Text = "Wizard";
            }
        }
        public void SetStrength(int strength) { lblStrengthCount.Text = strength.ToString(); }
        public void SetAgility(int agility) { lblAgilityCount.Text = agility.ToString(); }
        public void SetIntelligence(int intelligence) { lblIntelligenceCount.Text = intelligence.ToString(); }
        public void SetImage(Image image) { pbCharacter.Image = image; }

        private void LblStrength_Click(object sender, EventArgs e)
        {

        }

        private void FrmShow_Load(object sender, EventArgs e)
        {

        }

        private void PbCharacter_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
