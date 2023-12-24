using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SmirnovIA.Sprint7.Project.V14
{
    public partial class FormManual_SIA : Form
    {
        public FormManual_SIA()
        {
            InitializeComponent();
        }
        static int curentImage = 0;

        private void ChangeImage()
        {
            if (curentImage == 0)
            {
                pictureBoxGuide_SIA.BackgroundImage = Properties.Resources.Скриншот_24_12_2023_144028;
            }
            if (curentImage == 1)
            {
                pictureBoxGuide_SIA.BackgroundImage = Properties.Resources._2;
            }
            if (curentImage == 2)
            {
                pictureBoxGuide_SIA.BackgroundImage = Properties.Resources._3;
            }
            if (curentImage == 3)
            {
                pictureBoxGuide_SIA.BackgroundImage = Properties.Resources._4;
            }
            if (curentImage == 4)
            {
                pictureBoxGuide_SIA.BackgroundImage = Properties.Resources._5;
            }
            if (curentImage == 5)
            {
                pictureBoxGuide_SIA.BackgroundImage = Properties.Resources._6;
            }

        }
        private void buttonNext_SIA_Click(object sender, EventArgs e)
        {
            curentImage++;
            buttonPrev_SIA.Enabled = true;
            if (curentImage == 5)
            {
                buttonNext_SIA.Enabled = false;
            }
            ChangeImage();
        }

        private void buttonPrev_SIA_Click(object sender, EventArgs e)
        {
            curentImage--;
            buttonNext_SIA.Enabled = true;
            if (curentImage == 0) 
            {
                buttonPrev_SIA.Enabled = false;
            }
            ChangeImage();
        }
    }
}
