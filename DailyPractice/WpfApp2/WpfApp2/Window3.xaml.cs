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
using WpfApp2.DataSet1TableAdapters;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        DataSet1 ds;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ds = new DataSet1();
            DepartmentsTableAdapter daDeps = new DepartmentsTableAdapter();
            daDeps.Fill(ds.Departments);

            EmployeesTableAdapter daEmps = new EmployeesTableAdapter();
            daEmps.Fill(ds.Employees);

            dgEmps.ItemsSource = ds.Employees.DefaultView;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmployeesTableAdapter daEmps = new EmployeesTableAdapter();
            daEmps.Update(ds.Employees);
        }
    }
}
