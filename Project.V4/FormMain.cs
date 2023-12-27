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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBooks formBooks = new FormBooks();
            formBooks.ShowDialog();
        }

        private void buttonExit_MAD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDo_MAD_MouseEnter(object sender, EventArgs e)
        {
            buttonDo_MAD.BackColor = Color.LightGray;
        }

        private void buttonDo_MAD_MouseLeave(object sender, EventArgs e)
        {
            buttonDo_MAD.BackColor = Color.White;
        }

        private void buttonInf_MAD_Click(object sender, EventArgs e)
        {
            FormInf formInf = new FormInf();
            formInf.ShowDialog();
        }

        private void buttonInf_MAD_MouseEnter(object sender, EventArgs e)
        {
            buttonInf_MAD.BackColor = Color.LightGray;
        }

        private void buttonInf_MAD_MouseLeave(object sender, EventArgs e)
        {
            buttonInf_MAD.BackColor = Color.White;
        }

        private void buttonExit_MAD_MouseEnter(object sender, EventArgs e)
        {
            buttonExit_MAD.BackColor = Color.LightGray;
        }

        private void buttonExit_MAD_MouseLeave(object sender, EventArgs e)
        {
            buttonExit_MAD.BackColor = Color.White;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
