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


        public Save(int quantity, int purchasePrice, int sellPrice, int profit)
        {
            this.Quandity = quantity;
            this.PurchasePrice = purchasePrice;
            this.SellPrice = sellPrice;
            this.Profit = profit;
        }


        public void saveData()
        {

            try
            {
                using (StreamWriter writer = new StreamWriter("BackupProfit.txt", true))
                {
                    writer.WriteLine("Hello World");
                    MessageBox.Show("azerty");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.");

            }
            //finally
            //{
            //    if (outputstream != null)
            //    {

            //        outputstream.Close();


            //    }
            //}

            MessageBox.Show("Succesfull save");

        }


    }
}
