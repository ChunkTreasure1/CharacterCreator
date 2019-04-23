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
    public partial class frmMain : Form
    {
        private List<Image> m_MaleImages = new List<Image>();
        private List<Image> m_FemaleImages = new List<Image>();
        private List<Image> m_Images = new List<Image>();

        private string[] m_MaleNames;
        private string[] m_FemaleNames;

        private int m_CurrentImageIndex = 0;
        private Random random = new Random();

        public frmMain()
        {
            InitializeComponent();
            LoadImages();
            LoadNames();

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

                DefaultExt = "char"
            };
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            if (Globals.Strength < 10)
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
            if (Globals.Agility < 10)
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
            if (Globals.Intelligence < 10)
            {
                Globals.Intelligence++;
                lblIntelligenceCount.Text = Globals.Intelligence.ToString();
            }
        }

        //Loads the base images
        private void LoadImages()
        {
            for (int i = 0; i < 9; i++)
            {
                m_MaleImages.Add(Image.FromFile("Images/Male/M_portrait0" + i.ToString() + ".jpg"));
            }

            for (int i = 0; i < 9; i++)
            {
                m_FemaleImages.Add(Image.FromFile("Images/Female/F_portrait0" + i.ToString() + ".jpg"));
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
                m_Images = m_MaleImages;
            }
            else if (cbGender.SelectedIndex == 1)
            {
                Globals.Gender = Gender.Female;
                m_Images = m_FemaleImages;
            }
            else if (cbGender.SelectedIndex == 2)
            {
                return;
            }
            m_CurrentImageIndex = 0;
            pbCharacter.Image = m_Images[m_CurrentImageIndex];
        }

        //Changes image
        private void BtnLastImage_Click(object sender, EventArgs e)
        {
            m_CurrentImageIndex--;
            if (m_CurrentImageIndex < 0)
            {
                m_CurrentImageIndex = m_Images.Count - 1;
            }
            pbCharacter.Image = m_Images[m_CurrentImageIndex];
        }

        //Changes image
        private void BtnNextImage_Click(object sender, EventArgs e)
        {
            m_CurrentImageIndex++;
            if (m_CurrentImageIndex >= m_Images.Count)
            {
                m_CurrentImageIndex = 0;
            }
            pbCharacter.Image = m_Images[m_CurrentImageIndex];
        }

        //Changes the name of the character
        private void TxtBoxName_TextChanged(object sender, EventArgs e)
        {
            Globals.Name = txtBoxName.Text;
        }

        private void CreateRandomCharacter()
        {
            if (cbGender.SelectedIndex == 2)
            {
                int gender = cbGender.SelectedIndex = random.Next(0, 2);
                Globals.Gender = (Gender)gender;

                if (gender == 0)
                {
                    m_Images = m_MaleImages;
                    pbCharacter.Image = m_MaleImages[random.Next(0, m_MaleImages.Count)];
                    txtBoxName.Text = m_MaleNames[random.Next(0, m_MaleNames.Length)];
                }
                else
                {
                    m_Images = m_FemaleImages;
                    pbCharacter.Image = m_FemaleImages[random.Next(0, m_FemaleImages.Count)];
                    txtBoxName.Text = m_FemaleNames[random.Next(0, m_FemaleNames.Length)];
                }
            }
            else if (cbGender.SelectedIndex == 1)
            {
                m_Images = m_FemaleImages;
                pbCharacter.Image = m_FemaleImages[random.Next(0, m_FemaleImages.Count)];
                txtBoxName.Text = m_FemaleNames[random.Next(0, m_FemaleNames.Length)];
            }
            else if (cbGender.SelectedIndex == 0)
            {
                m_Images = m_MaleImages;
                pbCharacter.Image = m_MaleImages[random.Next(0, m_MaleImages.Count)];
                txtBoxName.Text = m_MaleNames[random.Next(0, m_MaleNames.Length)];
            }
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            CreateRandomCharacter();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
