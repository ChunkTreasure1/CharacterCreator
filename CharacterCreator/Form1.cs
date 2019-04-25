using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using CharacterCreator.Global;

namespace CharacterCreator
{
    public partial class frmMain : Form
    {

        private string[] m_MaleNames;
        private string[] m_FemaleNames;

        private int m_CurrentImageIndex = 0;
        private Random random = new Random();

        public frmMain()
        {
            InitializeComponent();
            Globals.LoadImages();
            LoadNames();

            cbRandomGender.Checked = true;
            cbRandomName.Checked = true;
            cbGender.SelectedIndex = 2;
            CreateRandomCharacter();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Browse Character Files",
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "chf",
                Filter = "Character Files (*.chf)|*.chf|All Files (*.*)|*.*"
            };

            ofd.ShowDialog();

            StreamReader sr = File.OpenText(ofd.FileName);

            Globals.Name = sr.ReadLine();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.DefaultExt = "chf";
            sfd.Filter = "Character Files (*.chf)|*.chf|All Files (*.*)|*.*";
            sfd.ShowDialog();

            StreamWriter sw = File.CreateText(sfd.FileName);

            sw.WriteLine(Globals.Name);
            sw.WriteLine(Globals.GenderToString());
            sw.WriteLine(Globals.RaceToString());

            sw.WriteLine(Globals.ClassToString());
            sw.WriteLine(Globals.Strength);
            sw.WriteLine(Globals.Intelligence);

            sw.WriteLine(Globals.Agility);
            sw.WriteLine(Globals.GetImagePath());

            sw.Close();
        }

        private void BtnStrengthMinus_Click(object sender, EventArgs e)
        {
            if (Globals.Strength > 0)
            {
                Globals.Strength--;
                lblStrengthCount.Text = Globals.Strength.ToString();
            }
        }

        private void BtnStrengthPlus_Click(object sender, EventArgs e)
        {
            if (Globals.Strength < 20)
            {
                Globals.Strength++;
                lblStrengthCount.Text = Globals.Strength.ToString();
            }
        }

        private void BtnAgilityMinus_Click(object sender, EventArgs e)
        {
            if (Globals.Agility > 0)
            {
                Globals.Agility--;
                lblAgilityCount.Text = Globals.Agility.ToString();
            }
        }

        private void BtnAgilityPlus_Click(object sender, EventArgs e)
        {
            if (Globals.Agility < 20)
            {
                Globals.Agility++;
                lblAgilityCount.Text = Globals.Agility.ToString();
            }
        }

        private void BtnIntelligenceMinus_Click(object sender, EventArgs e)
        {
            if (Globals.Intelligence > 0)
            {
                Globals.Intelligence--;
                lblIntelligenceCount.Text = Globals.Intelligence.ToString();
            }
        }

        private void BtnIntelligencePlus_Click(object sender, EventArgs e)
        {
            if (Globals.Intelligence < 20)
            {
                Globals.Intelligence++;
                lblIntelligenceCount.Text = Globals.Intelligence.ToString();
            }
        }

        private void LoadNames()
        {
            m_MaleNames = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\Names/male-first-names.txt", System.Text.Encoding.GetEncoding(1252));
            m_FemaleNames = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\Names/female-first-names.txt", System.Text.Encoding.GetEncoding(1252));
        }

        //Selects the gender of the charaxter
        private void CbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedIndex == 0)
            {
                Globals.Gender = Gender.Male;
                Globals.m_Images = Globals.m_MaleImages;
            }
            else if (cbGender.SelectedIndex == 1)
            {
                Globals.Gender = Gender.Female;
                Globals.m_Images = Globals.m_FemaleImages;
            }
            else if (cbGender.SelectedIndex == 2)
            {
                return;
            }
            m_CurrentImageIndex = 0;
            pbCharacter.Image = Globals.m_Images[m_CurrentImageIndex];
        }

        //Changes image
        private void BtnLastImage_Click(object sender, EventArgs e)
        {
            m_CurrentImageIndex--;
            if (m_CurrentImageIndex < 0)
            {
                m_CurrentImageIndex = Globals.m_Images.Count - 1;
            }
            pbCharacter.Image = Globals.m_Images[m_CurrentImageIndex];
            Globals.Picture = Globals.m_Images[m_CurrentImageIndex];
        }

        //Changes image
        private void BtnNextImage_Click(object sender, EventArgs e)
        {
            m_CurrentImageIndex++;
            if (m_CurrentImageIndex >= Globals.m_Images.Count)
            {
                m_CurrentImageIndex = 0;
            }
            pbCharacter.Image = Globals.m_Images[m_CurrentImageIndex];
            Globals.Picture = Globals.m_Images[m_CurrentImageIndex];
        }

        //Changes the name of the character
        private void TxtBoxName_TextChanged(object sender, EventArgs e)
        {
            Globals.Name = txtBoxName.Text;
        }

        private void CreateRandomCharacter()
        {
            if (cbRandomGender.Checked)
            {
                int gender = cbGender.SelectedIndex = random.Next(0, 2);
                Globals.Gender = (Gender)gender;
            }
            if (cbGender.SelectedIndex == 0)
            {
                Globals.m_Images = Globals.m_MaleImages;
                pbCharacter.Image = Globals.m_MaleImages[random.Next(0, Globals.m_MaleImages.Count)];
                Globals.Picture = pbCharacter.Image;
                if (cbRandomName.Checked)
                {
                    txtBoxName.Text = m_MaleNames[random.Next(0, m_MaleNames.Length)];
                }
            }
            else
            {
                Globals.m_Images = Globals.m_FemaleImages;
                pbCharacter.Image = Globals.m_FemaleImages[random.Next(0, Globals.m_FemaleImages.Count)];
                Globals.Picture = pbCharacter.Image;
                if (cbRandomName.Checked)
                {
                    txtBoxName.Text = m_FemaleNames[random.Next(0, m_FemaleNames.Length)];
                }
            }
            int race = cbRace.SelectedIndex = random.Next(0, 3);
            int classI = cbClass.SelectedIndex = random.Next(0, 3);

            Globals.Race = (Race)race;
            Globals.Class = (Class)classI;
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            CreateRandomCharacter();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmShow form = new frmShow();

            form.SetName(Globals.Name);
            form.SetGender(Globals.Gender);
            form.SetRace(Globals.Race);

            form.SetClass(Globals.Class);
            form.SetStrength(Globals.Strength);
            form.SetIntelligence(Globals.Intelligence);

            form.SetAgility(Globals.Agility);
            form.SetImage(Globals.Picture);
            form.ShowDialog();
        }

        private void CbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClass.SelectedIndex == 0)
            {
                Globals.Class = Class.Wizard;
            }
            else if (cbClass.SelectedIndex == 1)
            {
                Globals.Class = Class.Archer;
            }
            else if (cbClass.SelectedIndex == 2)
            {
                Globals.Class = Class.Warrior;
            }
            else
            {
                return;
            }
        }

        private void CbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRace.SelectedIndex == 0)
            {
                Globals.Race = Race.Human;
            }
            else if (cbRace.SelectedIndex == 1)
            {
                Globals.Race = Race.Elf;
            }
            else if (cbRace.SelectedIndex == 2)
            {
                Globals.Race = Race.Dwarf;
            }
            else
            {
                return;
            }
        }

        private void Sfd_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
