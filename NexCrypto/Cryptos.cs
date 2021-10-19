using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexCrypto
{
    public partial class Cryptos : Form
    {
        private Form1 mainForm;

        public Cryptos()
        {
            InitializeComponent();
        }

        public Cryptos(Form1 callingForm)
        {
            this.mainForm = callingForm;
            InitializeComponent();
        }

        private void Cryptos_Load(object sender, EventArgs e)
        {
            Task.Run(() => this.loadCryptos());
        }

        private void loadCryptos()
        {
            foreach (var crypto in Nex.CryptoManager.Cryptos)
            {
                Invoke(new Action(() => 
                this.dataGridView1.Rows.Add(crypto.type_is_crypto == 1 ? "Crypto" : "Currency", crypto.asset_id, crypto.name, crypto.price_usd, crypto.volume_1day_usd, crypto.volume_1mth_usd)));
            }
        }

        private void loadIcon(string iconId)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Image", typeof(Image));

            string imageLocalPath = AppDomain.CurrentDomain.BaseDirectory + "Resources/" + iconId + ".png";

            if (File.Exists(imageLocalPath))
            {
                dataTable.Rows.Add(new object[] { Image.FromFile(imageLocalPath) });
            }
            else
            {
                // Get request to download the image if it does not exist locally
                var request = WebRequest.Create("https://s3.eu-central-1.amazonaws.com/bbxt-static-icons/type-id/png_16/" + iconId + ".png");

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    // Check if the request is successful
                    if ((response as System.Net.HttpWebResponse).StatusCode == HttpStatusCode.OK)
                    {
                        var image = Bitmap.FromStream(stream);
                        image.Save(imageLocalPath);

                        dataTable.Rows.Add(new object[] { image });
                    }
                    // No local image exist and the URL is no longer valid
                    else
                    {
                        // The default Windows Forms image will be displayed
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
