using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexCrypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Nex.Initialize();

            this.openChildForm(new Login());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            childPanel.Controls.Add(childForm);
            childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void closePanels()
        {
            this.cryptosPanel.Visible = false;
            this.adminPanel.Visible = false;
            this.adminUsersPanel.Visible = false;
            this.adminCryptoPanel.Visible = false;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.closePanels();
        }

        private void cryptoButton_Click(object sender, EventArgs e)
        {
            this.closePanels();
            this.cryptosPanel.Visible = true;
        }

        private void adminButton_Click_2(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.closePanels();
            this.adminPanel.Visible = true;
        }

        private void adminUserButton_Click(object sender, EventArgs e)
        {
            this.closePanels();
            this.adminPanel.Visible = true;
            this.adminUsersPanel.Visible = true;
        }

        private void adminCryptoButton_Click(object sender, EventArgs e)
        {
            this.closePanels();
            this.adminPanel.Visible = true;
            this.adminCryptoPanel.Visible = true;
        }
    }
}
