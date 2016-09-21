using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace RunescapeToolTip
{
    class Save
    {
        public int Quandity { get; set; }
        public int SellPrice { get; set; }
        public int PurchasePrice { get; set; }
        public int Profit { get; set; }
        StreamWriter outputstream;

        public Save(int quantity, int purchasePrice, int sellPrice, int profit)
        {
            this.Quandity = quantity;
            this.PurchasePrice = purchasePrice;
            this.SellPrice = sellPrice;
            this.Profit = profit;
        }


        public void saveData()
        {
            outputstream = File.CreateText("ProfitBackup.txt");
            outputstream.WriteLine("Hello World");
            outputstream.WriteLine("Dit is een tekst");

            outputstream.Close();
            MessageBox.Show("Job done");
        }



    }
}
