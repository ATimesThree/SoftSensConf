using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSensConf
{
    public partial class FormRickAshtley : Form
    {
        public FormRickAshtley()
        {
            InitializeComponent();
        }

        private void buttonRickAshleyCancel_Click(object sender, EventArgs e)
        {
            GlobalDataContainerClass.RickAstleyConfirmed = false;
            GlobalDataContainerClass.RickAstleyDialogOpen = false;
            this.Close();
        }

        private void buttonRickAshleyConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxRickAshley.Text.Length == 0)
            {
                MessageBox.Show("Password cant be empty!\nPlease type a password", "Empty Password!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxRickAshley.Focus();
            }
            else
            {
                GlobalDataContainerClass.RickAstley = textBoxRickAshley.Text;
                GlobalDataContainerClass.RickAstleyDialogOpen = false;
                GlobalDataContainerClass.RickAstleyConfirmed = true;
                this.Close();
            }
        }


        private void textBoxRickAshley_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonRickAshleyConfirm_Click(sender, e);
                return;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                buttonRickAshleyCancel_Click(sender, e);
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GlobalDataContainerClass.ConnectivityStatus == false)
            {
                this.Close();
            }
        }

        private void textBoxRickAshley_Leave(object sender, EventArgs e)
        {
            if (textBoxRickAshley.Text.Length!=8)
            {
                MessageBox.Show("Password length must be exactly 8 characters", "Length Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxRickAshley.Focus();
            }
        }
    }
}
