using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V4
{
    public partial class FormInf : Form
    {
        public FormInf()
        {
            InitializeComponent();
        }

        private void buttonInf3_MAD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInf1_MAD_MouseEnter(object sender, EventArgs e)
        {
            buttonInf1_MAD.BackColor = Color.LightGray;
        }

        private void buttonInf1_MAD_MouseLeave(object sender, EventArgs e)
        {
            buttonInf1_MAD.BackColor = Color.White;
        }


        private void buttonInf3_MAD_MouseEnter(object sender, EventArgs e)
        {
            buttonInf3_MAD.BackColor = Color.LightGray;
        }

        private void buttonInf3_MAD_MouseLeave(object sender, EventArgs e)
        {
            buttonInf3_MAD.BackColor = Color.White;
        }

        private void buttonInf1_MAD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonInf2_MAD_Click(object sender, EventArgs e)
        {
            FormGuid formGuid = new FormGuid();
            formGuid.ShowDialog();
        }
    }
}
