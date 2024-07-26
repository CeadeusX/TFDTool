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
    /// Interaktionslogik für CalculatorPage.xaml
    /// </summary>
    public partial class CalculatorPage : Page
    {
        public CalculatorPage()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double dropRate;
            int tries;

            // Replace dots with commas
            string dropRateText = Droprate.Text.Replace('.', ',');
            bool isDropRateValid = double.TryParse(dropRateText, out dropRate);
            bool isTriesValid = int.TryParse(Tries.Text, out tries);

            if (isDropRateValid && isTriesValid)
            {
                double chance = CalculateChance(dropRate, tries);
                Chance.Text = $"Chance: {chance:P5}";
            }
            else
            {
                Chance.Text = "Invalid input.";
            }
        }

        private void Calculate2_Click(object sender, RoutedEventArgs e)
        {
            double dropRate;
            double wantedChance;

            // Replace dots with commas
            string dropRateText = Droprate2.Text.Replace('.', ',');
            string wantedChanceText = WantedChance.Text.Replace('.', ',');

            bool isDropRateValid = double.TryParse(dropRateText, out dropRate);
            bool isWantedChanceValid = double.TryParse(wantedChanceText, out wantedChance);

            if (isDropRateValid && isWantedChanceValid)
            {
                int tries = CalculateTries(dropRate, wantedChance);
                Tries2.Text = $"Tries needed: {tries}";
            }
            else
            {
                Tries2.Text = "Invalid input.";
            }
        }

        private double CalculateChance(double dropRate, int tries)
        {
            // Convert percentage to probability
            double dropProbability = dropRate / 100;

            // Calculate the chance that the item will drop at least once
            double noDropProbability = Math.Pow(1 - dropProbability, tries);
            double dropChance = 1 - noDropProbability;

            return dropChance;
        }

        private int CalculateTries(double dropRate, double wantedChance)
        {
            // Convert percentages to probabilities
            double dropProbability = dropRate / 100;
            double wantedProbability = wantedChance / 100;

            // Calculate the number of tries needed
            double tries = Math.Log(1 - wantedProbability) / Math.Log(1 - dropProbability);

            // Return the ceiling of tries as an integer
            return (int)Math.Ceiling(tries);
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && (textBox.Text == "Wanted Chance" || textBox.Text == "Droprate" || textBox.Text == "Tries"))
            {
                textBox.Text = string.Empty;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "WantedChance")
                {
                    textBox.Text = "Wanted Chance";
                }
                else if (textBox.Name == "Droprate" || textBox.Name == "Droprate2")
                {
                    textBox.Text = "Droprate";
                }
                else if (textBox.Name == "Tries")
                {
                    textBox.Text = "Tries";
                }
            }
        }
    }
}
