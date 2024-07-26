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

namespace Calculator2._0
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isCalculatorPage = false;
        private CalculatorPage calculatorPage = new CalculatorPage();
        private VoidFragmentsPage voidFragmentsPage = new VoidFragmentsPage();
        public MainWindow()
        {
            InitializeComponent();
            this.Pages.Content = calculatorPage;
            isCalculatorPage = true;
        }

        private void btnCalculator_Click(object sender, RoutedEventArgs e)
        {
            if (!isCalculatorPage) { this.Pages.Content = calculatorPage; isCalculatorPage = !isCalculatorPage; }
        }

        private void btnVoidFragments_Click(object sender, RoutedEventArgs e)
        {
            if (isCalculatorPage) { this.Pages.Content = voidFragmentsPage; isCalculatorPage = !isCalculatorPage; }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnX_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
