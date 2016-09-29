using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RunescapeToolTip
{
    class Save
    {
        //thoose where prop idk why

        private string saveString;
        private TransactiesWindow transactiewindow;
        public int TotProfit { get; set; }


        public Save()
        {

        }


        public void saveData(string itemName, int quantity, int purchasePrice, int sellPrice, int profit)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter("BackupProfit.txt", true))
                {
                    saveString = itemName + " / " + quantity + " / " + purchasePrice + " / " + sellPrice + " / " + profit;
                    writer.WriteLine(saveString);
                    // MessageBox.Show("Saving processing occured");
                    // test to know if this code run or not
                }


                using (StreamWriter writer = new StreamWriter("TotProfit.txt", true))
                {
                    writer.WriteLine(profit);
                }

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unkown error occured.");

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

        public void printTransacties()
        {
            transactiewindow = new TransactiesWindow();

            string lineGegevens = "";
            StringBuilder output = new StringBuilder();

            using (StreamReader readerGegevens = new StreamReader("BackupProfit.txt"))
            {

                lineGegevens = readerGegevens.ReadLine();


                while (lineGegevens != null)
                {

                    output = output.Append(lineGegevens + "\n");
                    lineGegevens = readerGegevens.ReadLine();
                }

            }

            string lineProfit = "";

            using (StreamReader readerProfit = new StreamReader("TotProfit.txt"))
            {


                lineProfit = readerProfit.ReadLine();

                while (lineProfit != null)
                {
                    TotProfit += Convert.ToInt32(lineProfit);


                    lineProfit = readerProfit.ReadLine();
                }


            }

            string outputTotProfit = TotProfit.ToString();
            int lengteTotProfit = outputTotProfit.Length;
            // set " " between the 1 000

            
            transactiewindow.txtBlockPrint.Text = output.ToString();
            transactiewindow.lblTotalProfit.Content = "Total profit: " + TotProfit;



            transactiewindow.Show();



        }


    }
}
