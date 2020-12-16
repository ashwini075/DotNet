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
using System.Data.SqlClient;
using System.Data;

namespace WpfApp2
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

 
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true;";
            // Data Source = (localdb)\MsSqlLocalDb; Initial Catalog = JKDec20; Integrated Security = True; Pooling = False
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "insert into Employees values(1,'Ashwini',10000,10)";
            cmd.CommandText = "insert into Employees values(" + txtEmpNo.Text + ",'" + txtName.Text + "'," + txtBasic.Text + " ," + txtDeptNo.Text + ")";
            MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("okay");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
            // MessageBox.Show("okay");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";

            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("done with parameters");
            cn.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "InsertEmployee";

            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);

            //MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("okay");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            cn.Close();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "UpdateEmployee";

            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);

            //MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update okay");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            cn.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "DeleteEmployee";

            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
           // cmd.Parameters.AddWithValue("@Name", txtName.Text);
            //.Parameters.AddWithValue("@Basic", txtBasic.Text);
            //cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);

            //MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete okay ");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            cn.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from Employees";
            MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.ExecuteScalar();
                MessageBox.Show(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
             MessageBox.Show("ok!!");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();
            SqlTransaction t = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Transaction = t;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employees values(10,'sainath',23243,10)";
            //MessageBox.Show(cmd.CommandText);
            SqlCommand cmd2 = new SqlCommand();

            cmd2.Connection = cn;
            cmd2.Transaction = t;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into Employees values(11,'rushi',23243,10)";

            try
            {
                cmd.ExecuteScalar();
                cmd2.ExecuteScalar();
                t.Commit();
                MessageBox.Show("commit");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                t.Rollback();
            }
            finally
            {
                cn.Close();
                MessageBox.Show("ok!!");
            }
            
        }
    }
}
