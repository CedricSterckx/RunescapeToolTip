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

namespace RunescapeToolTip
{
    /// <summary>
    /// Interaction logic for MoneyMakingWindow.xaml
    /// </summary>
    public partial class MoneyMakingWindow : Window
    {
        MainWindow mainWindow = new MainWindow();

        public MoneyMakingWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
    }
}
