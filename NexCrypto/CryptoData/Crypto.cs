using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexCrypto.CryptoData
{
    public class Crypto
    {
        public string asset_id { get; set; }
        public string name { get; set; }
        public int type_is_crypto { get; set; }
        public DateTime data_quote_start { get; set; }
        public DateTime data_quote_end { get; set; }
        public DateTime data_orderbook_start { get; set; }
        public DateTime data_orderbook_end { get; set; }
        public DateTime data_trade_start { get; set; }
        public DateTime data_trade_end { get; set; }
        public int data_symbols_count { get; set; }
        public double volume_1hrs_usd { get; set; }
        public double volume_1day_usd { get; set; }
        public double volume_1mth_usd { get; set; }
        public double price_usd { get; set; }
        public string id_icon { get; set; }
        public string data_start { get; set; }
        public string data_end { get; set; }
    }
}
