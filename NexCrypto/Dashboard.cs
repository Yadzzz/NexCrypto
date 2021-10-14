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
    public partial class Dashboard : Form
    {
        private Form1 mainForm;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(Form1 callingForm)
        {
            this.mainForm = callingForm;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
