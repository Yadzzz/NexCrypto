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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nexDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.nexDataSet.Users);
        }

        private void updateTabelButton_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Update(this.nexDataSet);
        }
    }
}
