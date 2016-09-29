using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeToolTipV2
{
    class Transactie
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int PurchasePrice { get; set; }
        public int SellPrice { get; set; }
        public int Profit { get; set; }


        public Transactie()
        {
            this.ItemName = "Unknown Item";
            this.Quantity = 0;
            this.PurchasePrice = 0;
            this.SellPrice = 0;
            this.Profit = 0;

        }

        public Transactie(string itemName, int quantity, int purchasePrice, int sellPrice, int profit)
        {
            this.ItemName = itemName;
            this.Quantity = quantity;
            this.PurchasePrice = purchasePrice;
            this.SellPrice = sellPrice;
            this.Profit = profit;

        }



        public string toString()
        {
            return "Item name " + ItemName + " quantity " + Quantity + " purchase price " + PurchasePrice + " sell price " + SellPrice
                + " profit " + Profit + "\n"; 
        }


        public int calcProfit()
        {
            return (SellPrice - PurchasePrice) * Quantity;
        }


    }
}
