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
    /// Interaktionslogik für VoidFragmentsPage.xaml
    /// </summary>
    public partial class VoidFragmentsPage : Page
    {
        private string searchElement = "";
        private string searchFragmentType = "";
        Fragmentdatabase db = new Fragmentdatabase();
        public VoidFragmentsPage()
        {
            InitializeComponent();

            cbbElement.Items.Add(new ComboBoxItem() { Content = "Non-Attribute" });
            cbbElement.Items.Add(new ComboBoxItem() { Content = "Electric" });
            cbbElement.Items.Add(new ComboBoxItem() { Content = "Fire" });
            cbbElement.Items.Add(new ComboBoxItem() { Content = "Chill" });
            cbbElement.Items.Add(new ComboBoxItem() { Content = "Toxic" });

            cbbFragmentType.Items.Add(new ComboBoxItem() { Content = "Monomer" });
            cbbFragmentType.Items.Add(new ComboBoxItem() { Content = "Polymer" });
            cbbFragmentType.Items.Add(new ComboBoxItem() { Content = "Inorganic" });
            cbbFragmentType.Items.Add(new ComboBoxItem() { Content = "Organic" });

        }

        private void cbbElement_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                if (comboBox.SelectedItem is ComboBoxItem selectedItem)
                {
                    searchElement = selectedItem.Content.ToString();
                    Search();
                }               
            }
        }

        private void cbbFragmentType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                if (comboBox.SelectedItem is ComboBoxItem selectedItem)
                {
                    searchFragmentType = selectedItem.Content.ToString();
                    Search();
                }
            }
        }

        private void Search()
        {
            if (searchElement.Equals("") && searchFragmentType.Equals("")) { return; }
            else if (!searchElement.Equals("") && searchFragmentType.Equals("")) { tblLocations.ItemsSource = db.GetZonesByElement(searchElement); }
            else if (!searchElement.Equals("") && !searchFragmentType.Equals("")) { tblLocations.ItemsSource = db.GetZonesByElementAndFragment(searchElement, searchFragmentType); }
            else if (searchElement.Equals("") && !searchFragmentType.Equals("")) { tblLocations.ItemsSource = db.GetZonesByFragment(searchFragmentType); };
        }

    }
}
