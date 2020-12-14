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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        static int n1;
        static int n2;
        public Window2()
        {
            InitializeComponent();
        }

     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
             
            int result= Int32.Parse(txtNum1.Text ) +  Int32.Parse(txtNum2.Text);
            txtSum.Text = result.ToString();
        }

        private void txtNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            n1 = Int32.Parse(txtNum1.Text);
            int sum = n1 + n2;
            txtSum.Text = sum.ToString();
        }

        private void txtNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            n2 = Int32.Parse(txtNum2.Text);
            int sum = n2 + n1;
           txtSum.Text = sum.ToString();

        }

        private void txtSum_TextChanged(object sender, TextChangedEventArgs e)
        {
           int sum = n1 + n2;
            txtSum.Text = sum.ToString();
          
        }
    }
}
