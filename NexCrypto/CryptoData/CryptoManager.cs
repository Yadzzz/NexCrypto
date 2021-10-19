using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexCrypto.CryptoData
{
    public class CryptoManager
    {
        public List<Crypto> Cryptos { get; set; }

        public CryptoManager()
        {
            this.Cryptos = new List<Crypto>();
            this.loadCryptos();
        }

        /// <summary>
        /// Loads all cryptos into a List
        /// </summary>
        private void loadCryptos()
        {
            var client = new RestClient("https://rest.coinapi.io/v1/assets");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-CoinAPI-Key", "4F8F450C-D5D4-416A-A669-01787619462B");
            IRestResponse response = client.Execute(request);

            this.Cryptos = JsonConvert.DeserializeObject<List<Crypto>>(response.Content);
        }

        /// <summary>
        /// Get all cryptos
        /// </summary>
        /// <returns>List of cryptos</returns>
        public List<Crypto> GetCryptos()
        {


            return null;
        }

        public bool GetCrypto(string assetId, out Crypto crypto)
        {
            if (assetId.Length == 3)
            {
                crypto = this.Cryptos.Find(c => c.asset_id.ToLower() == assetId.ToLower());
            }
            else
            {
                crypto = this.Cryptos.Find(c => c.name.ToLower() == assetId.ToLower());
            }

            if(crypto == null)
            {
                return false;
            }

            return true;
        }
    }
}
