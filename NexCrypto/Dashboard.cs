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
            CryptoData.Crypto btc;
            if(Nex.CryptoManager.GetCrypto("BTC", out btc))
            {
                this.btcPriceLabel.Text = "$" + Math.Round(btc.price_usd, 3).ToString();
            }
            else
            {
                this.btcPriceLabel.Text = "Invalid Data";
            }

            CryptoData.Crypto eth;
            if (Nex.CryptoManager.GetCrypto("ETH", out eth))
            {
                this.ethPriceLabel.Text = "$" + Math.Round(eth.price_usd, 3).ToString();
            }
            else
            {
                this.btcPriceLabel.Text = "Invalid Data";
            }

            CryptoData.Crypto xrp;
            if (Nex.CryptoManager.GetCrypto("XRP", out xrp))
            {
                this.xrpPriceLabel.Text = "$" + Math.Round(xrp.price_usd, 3).ToString();
            }
            else
            {
                this.btcPriceLabel.Text = "Invalid Data";
            }
        }
    }
}
