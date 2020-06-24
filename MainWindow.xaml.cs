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

namespace WPF_Apps
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

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            this.NameText.Text = "";

            this.BreakfastCheckbox.IsChecked = false;
            this.BalconyCheckbox.IsChecked = false;
            this.SmokingCheckbox.IsChecked = false;

            this.SingleRadioButton.IsChecked = DoubleRadioButton.IsChecked = KingRadioButton.IsChecked = false;

            this.DiscountCombo.SelectedIndex = 0;

        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            String name = this.NameText.Text;
            int total = 0;

            if ((bool)this.SingleRadioButton.IsChecked)
                total = 100;

            else if ((bool)this.DoubleRadioButton.IsChecked)
                total = 150;

            else if ((bool)this.KingRadioButton.IsChecked)
                total = 175;

            if ((bool)this.BreakfastCheckbox.IsChecked)
                total += 15;

            if ((bool)this.BalconyCheckbox.IsChecked)
                total += 12;

            if ((bool)this.SmokingCheckbox.IsChecked)
                total += 6;

            if (this.DiscountCombo.SelectedIndex == 1) // Student Discount (5%)
                total = (int)(total * 0.95);

            else if (this.DiscountCombo.SelectedIndex == 2)
            {
                total = (int)(total * 0.92); //Military Discount (8%)
            }

            MessageBox.Show("Hi " + name + ", your room will cost $" + total + " per night.");


        }
    }
}
