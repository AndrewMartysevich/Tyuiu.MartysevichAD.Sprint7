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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonClose_MAD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_MAD_MouseEnter(object sender, EventArgs e)
        {
            buttonClose_MAD.BackColor = Color.LightGray;
        }

        private void buttonClose_MAD_MouseLeave(object sender, EventArgs e)
        {
            buttonClose_MAD.BackColor = Color.White;
        }
    }
}
