using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CharacterCreator.Global
{
    public static class Globals
    {
        public static int Strength = 5;
        public static int Agility = 5;
        public static int Intelligence = 5;

        public static Gender Gender = Gender.Male;
        public static Race Race = Race.Human;
        public static Class Class = Class.Warrior;

        public static string Name = "";
        public static Image Picture;

        public static List<Image> m_MaleImages = new List<Image>();
        public static List<Image> m_FemaleImages = new List<Image>();
        public static List<Image> m_Images = new List<Image>();

        public static string GenderToString()
        {
            if (Gender == Gender.Male)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }
        public static string RaceToString()
        {
            if (Race == Race.Dwarf)
            {
                return "Dwarf";
            }
            else if (Race == Race.Elf)
            {
                return "Elf";
            }
            else
            {
                return "Human";
            }
        }
        public static string ClassToString()
        {
            if (Class == Class.Wizard)
            {
                return "Wizard";
            }
            else if (Class == Class.Archer)
            {
                return "Archer";
            }
            else
            {
                return "Warrior";
            }
        }
        public static string GetImagePath()
        {
            if (Gender == Gender.Male)
            {
                int temp = 0;

                for (int i = 0; i < m_MaleImages.Count; i++)
                {
                    if (Picture == m_MaleImages[i])
                    {
                        temp = i;
                    }
                }

                return "Images/Male/M_portrait0" + temp.ToString() + ".jpg";
            }
            else
            {
                int temp = 0;

                for (int i = 0; i < m_FemaleImages.Count; i++)
                {
                    if (Picture == m_FemaleImages[i])
                    {
                        temp = i;
                    }
                }

                return "Images/Female/F_portrait0" + temp.ToString() + ".jpg";
            }
        }
        //Loads the base images
        public static void LoadImages()
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
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Race
    {
        Human,
        Elf,
        Dwarf
    }

    public enum Class
    {
        Wizard,
        Archer,
        Warrior
    }
}
