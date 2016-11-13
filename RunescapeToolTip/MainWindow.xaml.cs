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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RunescapeToolTip
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ProfitWindow ProfitWindow { get; set; }
        public MoneyMakingWindow MoneyMakingWindow { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnProfit_Click(object sender, RoutedEventArgs e)
        {
            if (ProfitWindow == null)
            {
                ProfitWindow = new ProfitWindow(this);
            }

            ProfitWindow.Show();
            this.Hide();
        }

        private void btnMoneyMaking_Click(object sender, RoutedEventArgs e)
        {
            if (MoneyMakingWindow == null)
            {
                MoneyMakingWindow = new MoneyMakingWindow(this);
            }

            MoneyMakingWindow.Show();
            
        }

    
    }
}
