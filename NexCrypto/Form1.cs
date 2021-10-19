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

            this.openChildForm(new Login(this));
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(!Nex.LoggedIn)
            {
                childForm = new Login(this);
            }

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
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.closePanels();
            this.openChildForm(new Dashboard(this));
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
        }

        public void OnLogin(bool isAdmin)
        {
            if(!isAdmin)
            {
                this.adminButton.Hide();
            }
        }

        public void UpdateUsername(string username)
        {
            this.usernameLabel.Text = username;
        }

        public void ViewDashboard()
        {
            this.closePanels();
            this.openChildForm(new Dashboard(this));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cryptosButton_Click(object sender, EventArgs e)
        {
            this.closePanels();
            this.openChildForm(new Cryptos(this));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.closePanels();
            this.openChildForm(new CryptoSearch());
        }

        private void adminUsersButton_Click(object sender, EventArgs e)
        {
            this.closePanels();
            this.adminPanel.Visible = true;
            this.adminUsersPanel.Visible = true;
            this.openChildForm(new Users());
        }
    }
}
