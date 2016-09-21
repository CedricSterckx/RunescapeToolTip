using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;


namespace RunescapeToolTip
{
    /// <summary>
    /// Interaction logic for ProfitWindow.xaml
    /// </summary>
    public partial class ProfitWindow : Window
    {

        private int purchasePrice;
        private int sellPrice;
        private int profit;
        private int quantity;
        private Save save;

        private MainWindow mainwindow;

        public ProfitWindow(MainWindow window)
        {
            InitializeComponent();

            this.mainwindow = window;

            purchasePrice = 0;
            sellPrice = 0;
            profit = 0;
            quantity = 0;
            
        }

        private void updateProfitlbl()
        {
            profit = (sellPrice - purchasePrice) * quantity;

            txtBoxProfit.Text = profit.ToString();
        }


        private void txtBoxPurchasePrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBoxPurchasePrice.Text != "") { 

            try
            { 
                this.purchasePrice = Convert.ToInt32(txtBoxPurchasePrice.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input, please retry! :D");
            }
            updateProfitlbl();
        }
        }


        private void txtBoxSellPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBoxSellPrice.Text != "") { 
            try
            {
                this.sellPrice = Convert.ToInt32(txtBoxSellPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input, please retry! :D");
            }
            updateProfitlbl();
            }

        }

        private void txtBoxQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBoxQuantity.Text != "")
            {
                try
                {
                    this.quantity = Convert.ToInt32(txtBoxQuantity.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong input, please retry! :D");
                }
                updateProfitlbl();
            }
        }


        private void txtBoxPurchasePrice_GotFocus(object sender, RoutedEventArgs e)
        {
            txtBoxPurchasePrice.Text = "";
        }


        private void txtBoxSellPrice_GotFocus(object sender, RoutedEventArgs e)
        {
            txtBoxSellPrice.Text = "";
        }

        private void txtBoxItemName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtBoxItemName.Text = "";
        }

        private void txtBoxQuantity_GotFocus(object sender, RoutedEventArgs e)
        {
            txtBoxQuantity.Text = "";
        }

        private void txtBoxItemName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtBoxItemName.Text == "")
            {
                txtBoxItemName.Text = "Unkown Item";
            }
        }

        private void txtBoxPurchasePrice_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtBoxPurchasePrice.Text == "")
            {
                txtBoxPurchasePrice.Text = "0";
            }
        }

        private void txtBoxSellPrice_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtBoxSellPrice.Text == "")
            {
                txtBoxSellPrice.Text = "0";
            }
        }


        private void txtBoxQuantity_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtBoxQuantity.Text == "")
            {
                txtBoxQuantity.Text = "0";
            }
        }

        
        private void Window_Closed(object sender, EventArgs e)
        {
            mainwindow.ProfitWindow = null;
            mainwindow.Show();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            save = new Save(quantity, purchasePrice, sellPrice, profit);
            save.saveData();
        }
    }

}
