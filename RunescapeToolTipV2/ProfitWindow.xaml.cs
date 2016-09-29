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

namespace RunescapeToolTipV2
{
    /// <summary>
    /// Interaction logic for ProfitWindow.xaml
    /// </summary>
    public partial class ProfitWindow : Window
    {
        private MainWindow mainWindow;
        private Transactie transactie;
        private List<Transactie> transacties;

        public ProfitWindow(MainWindow window)
        {
            InitializeComponent();
            this.mainWindow = window;

            transacties = new List<Transactie>;

        }



        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.profitWindow = null;
            mainWindow.Show();
        }

        private void txtBoxItemName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBoxItemName.Text != "")
            {
                try
                {
                    
                }
            }
        }
    }
}
