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
            cbGender.SelectedIndex = 1;
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

            if (!ofd.CheckFileExists || ofd.FileName == "")
            {
                return;
            }

            StreamReader sr = File.OpenText(ofd.FileName);

            Globals.Name = sr.ReadLine();
            Globals.Gender = Globals.StringToGender(sr.ReadLine());
            Globals.Race = Globals.StringToRace(sr.ReadLine());

            Globals.Class = Globals.StringToClass(sr.ReadLine());
            Globals.Strength = Int32.Parse(sr.ReadLine());
            Globals.Intelligence = Int32.Parse(sr.ReadLine());

            Globals.Agility = Int32.Parse(sr.ReadLine());
            string text = sr.ReadLine();

            if (Globals.Gender == Gender.Female)
            {
                Globals.Picture = Globals.m_FemaleImages[Int32.Parse(text)];
            }
            else
            {
                Globals.Picture = Globals.m_MaleImages[Int32.Parse(text)];
            }

            pbCharacter.Image = Globals.Picture;
            txtBoxName.Text = Globals.Name;
            cbGender.SelectedIndex = (int)Globals.Gender;

            cbRace.SelectedIndex = (int)Globals.Race;
            cbClass.SelectedIndex = (int)Globals.Class;

            lblStrengthCount.Text = Globals.Strength.ToString();
            lblIntelligenceCount.Text = Globals.Intelligence.ToString();
            lblAgilityCount.Text = Globals.Agility.ToString();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.DefaultExt = "chf";
            sfd.Filter = "Character Files (*.chf)|*.chf|All Files (*.*)|*.*";
            sfd.ShowDialog();

            if (sfd.FileName == "")
            {
                return;
            }

            StreamWriter sw = File.CreateText(sfd.FileName);

            sw.WriteLine(Globals.Name);
            sw.WriteLine(Globals.GenderToString());
            sw.WriteLine(Globals.RaceToString());

            sw.WriteLine(Globals.ClassToString());
            sw.WriteLine(Globals.Strength);
            sw.WriteLine(Globals.Intelligence);

            sw.WriteLine(Globals.Agility);
            sw.WriteLine(Globals.GetImageIndex());

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

            if (Globals.Class == Class.Warrior)
            {
                Globals.Strength = random.Next(10, 21);
                Globals.Intelligence = random.Next(1, 11);
                Globals.Agility = random.Next(3, 12);
            }
            else if (Globals.Class == Class.Archer)
            {
                Globals.Strength = random.Next(5, 13);
                Globals.Intelligence = random.Next(10, 16);
                Globals.Agility = random.Next(10, 21);
            }
            else if (Globals.Class == Class.Wizard)
            {
                Globals.Strength = random.Next(3, 11);
                Globals.Intelligence = random.Next(13, 21);
                Globals.Agility = random.Next(7, 16);
            }

            lblStrengthCount.Text = Globals.Strength.ToString();
            lblIntelligenceCount.Text = Globals.Intelligence.ToString();
            lblAgilityCount.Text = Globals.Agility.ToString();
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
