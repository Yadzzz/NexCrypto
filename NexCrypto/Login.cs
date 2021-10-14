using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexCrypto
{
    public partial class Login : Form
    {
        private Form1 mainForm;

        public Login()
        {
            InitializeComponent();
        }

        public Login(Form1 callingForm)
        {
            this.mainForm = callingForm;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.checkLoginCredentials(this.usernameTextBox.Text, this.passwordTextBox.Text);
        }

        private void checkLoginCredentials(string username, string password)
        {
            var user = Nex.NexCryptoContext.Users.SingleOrDefault(usr => usr.Username == username && usr.Password == password);

            if(user == null)
            {
                MessageBox.Show("Wrong login details");
                return;
            }

            Nex.LoggedInUser = user;
            Nex.LoggedIn = true;
            this.mainForm.UpdateUsername(user.Username);
            this.Hide();
        }
        
        private string getPasswordHash(string password)
        {
            var data = Encoding.ASCII.GetBytes(password);
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(data);

            return Encoding.ASCII.GetString(sha1data);
        }
    }
}
