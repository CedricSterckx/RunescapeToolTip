using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeToolTip
{
    class JsonParser
    {

        public string ItemName { get; set; }
        public int SellPrice { get; set; }
        public int PurchasePrice { get; set; }
        private string jsonURL;

        public JsonParser(string itemName, int sellPrice, int purchasePrice)
        {
            this.ItemName = itemName;
            this.SellPrice = sellPrice;
            this.PurchasePrice = purchasePrice;
        }




        private void controleInternet()
        {
            //internet conexion control
        }
    }
}
