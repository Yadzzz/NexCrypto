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
    public partial class CryptoSearch : Form
    {
        private Form1 mainForm;

        public CryptoSearch()
        {
            InitializeComponent();
        }

        public CryptoSearch(Form1 callingForm)
        {
            this.mainForm = callingForm;
            InitializeComponent();
        }

        private void CryptoSearch_Load(object sender, EventArgs e)
        {
            this.assetIdLabel.Hide();
            this.assetIdTextBox.Hide();
            this.assetLabel.Hide();
            this.assetTextBox.Hide();
            this.priceLabel.Hide();
            this.priceTextBox.Hide();
            this.volumeTraded24hLabel.Hide();
            this.volumeTraded24hTextBox.Hide();
            this.volumeTraded30dLabel.Hide();
            this.volumeTraded30dTextBox.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.getCryptoData(this.cryptoSearchTextBox.Text);
        }

        private void getCryptoData(string cryptoName)
        {
            CryptoData.Crypto crypto;
            if (Nex.CryptoManager.GetCrypto(cryptoName, out crypto))
            {
                this.assetIdLabel.Show();
                this.assetIdTextBox.Text = crypto.asset_id;
                this.assetIdTextBox.Show();

                this.assetLabel.Show();
                this.assetTextBox.Text = crypto.name;
                this.assetTextBox.Show();

                this.priceLabel.Show();
                this.priceTextBox.Text = Math.Round(crypto.price_usd, 3).ToString();
                this.priceTextBox.Show();

                this.volumeTraded24hLabel.Show();
                this.volumeTraded24hTextBox.Text = crypto.volume_1day_usd.ToString();
                this.volumeTraded24hTextBox.Show();

                this.volumeTraded30dLabel.Show();
                this.volumeTraded30dTextBox.Text = crypto.volume_1mth_usd.ToString();
                this.volumeTraded30dTextBox.Show();

                this.cryptoSearchTextBox.Text = string.Empty;
            }
        }
    }
}
