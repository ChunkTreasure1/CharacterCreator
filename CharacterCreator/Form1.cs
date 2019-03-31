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

        private int m_CurrentImageIndex = 0;

        public frmMain()
        {
            InitializeComponent();
            LoadImages();

            pbCharacter.Image = m_MaleImages[0];
            cbGender.SelectedIndex = 0;
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

            m_CurrentImageIndex = 0;
            pbCharacter.Image = m_Images[m_CurrentImageIndex];
        }

        private void BtnLastImage_Click(object sender, EventArgs e)
        {
            m_CurrentImageIndex--;
            if (m_CurrentImageIndex < 0)
            {
                m_CurrentImageIndex = m_Images.Count - 1;
            }
            pbCharacter.Image = m_Images[m_CurrentImageIndex];
        }

        private void BtnNextImage_Click(object sender, EventArgs e)
        {
            m_CurrentImageIndex++;
            if (m_CurrentImageIndex >= m_Images.Count)
            {
                m_CurrentImageIndex = 0;
            }
            pbCharacter.Image = m_Images[m_CurrentImageIndex];
        }

        private void TxtBoxName_TextChanged(object sender, EventArgs e)
        {
            Globals.Name = txtBoxName.Text;
        }
    }
}
