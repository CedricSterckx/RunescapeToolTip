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
using System.IO;

namespace TestProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int count = 0;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer =
          new StreamWriter("log.txt", true))
            {
                writer.WriteLine(count++);
            }
            // Append line to the file.
        

            MessageBox.Show("Job done");

        }
    }
}
