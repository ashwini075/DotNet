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

namespace BoxAssignment
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Forward to right side box
            foreach (var item in lstNames.SelectedItems)
            {
                lstNames_1.Items.Add(item.ToString());

            }

            lstNames.Items.Remove(lstNames.SelectedItem);

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Forward All to right side box
            foreach (var item in lstNames.Items)
            {
                lstNames_1.Items.Add(item.ToString());

            }
            foreach (var item in lstNames_1.Items)
            {
                lstNames.Items.Remove(item.ToString());

            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Backword to left side box
            foreach (var item in lstNames_1.SelectedItems)
            {
                lstNames.Items.Add(item.ToString());

            }

            lstNames_1.Items.Remove(lstNames_1.SelectedItem);

        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {//Backword all to left side
            foreach (var item in lstNames_1.Items)
            {
                lstNames.Items.Add(item.ToString());
            }
            foreach (var item in lstNames.Items)
            {
                lstNames_1.Items.Remove(item.ToString());
            }
        }

        private void lstNames_Loaded(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add("C");
            lstNames.Items.Add("C#");
            lstNames.Items.Add("C++");
            lstNames.Items.Add("DS");
            lstNames.Items.Add("OOP");
            lstNames.Items.Add("OS");

        }
    }
}
