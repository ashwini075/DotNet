using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";
            SqlDataReader dr = cmd.ExecuteReader();

            List<Employee> objEmpList = new List<Employee>();

            while (dr.Read())
            {
                objEmpList.Add(new Employee {EmpNo = (int)dr["EmpNo"],Name=(string)dr["Name"],Basic=(decimal)dr["Basic"],DeptNo=(short)(int)dr["DeptNo"]});
           
            }
           
            return View(objEmpList);
            dr.Close();
            cn.Close();
        }

        // GET: Employees/Details/5
        public ActionResult Details(int EmpNo)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";
            SqlDataReader dr = cmd.ExecuteReader();

            Employee objEmp = new Employee();


            while (dr.Read())
            {
                if (EmpNo ==(int)dr["EmpNo"])
                { 
                objEmp.EmpNo = (int)dr["EmpNo"];
                objEmp.Name = (string)dr["Name"];
                objEmp.Basic = (decimal)dr["Basic"];
                objEmp.DeptNo = (short)(int)dr["DeptNo"];
                }
            }

            return View(objEmp);
            dr.Close();
            cn.Close();
          
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(Employee objEmp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employees values(@EMpNo,@Name,@Basic,@DeptNo)";

            cmd.Parameters.AddWithValue("@EmpNo", objEmp.EmpNo);
            cmd.Parameters.AddWithValue("@Name", objEmp.Name);
            cmd.Parameters.AddWithValue("@Basic", objEmp.Basic);
            cmd.Parameters.AddWithValue("@DeptNo", objEmp.DeptNo);
            try
            {
                // TODO: Add insert logic here
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            finally
            {
                cn.Close();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int EmpNo)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

            SqlDataReader dr = cmd.ExecuteReader();

            List<Employee> objEmpList = new List<Employee>();

            Employee objEmp = new Employee();

            while (dr.Read())
            {
                objEmpList.Add(new Employee { EmpNo = (int)dr["EmpNo"], Name = (string)dr["Name"], Basic = (decimal)dr["Basic"], DeptNo = (short)(int)dr["DeptNo"] });

                if (EmpNo == (int)dr["EmpNo"])
                {
                    objEmp.EmpNo = (int)dr["EmpNo"];
                    objEmp.Name = (string)dr["Name"];
                    objEmp.Basic = (decimal)dr["Basic"];
                    objEmp.DeptNo = (short)(int)dr["DeptNo"];
                }
            }

            return View(objEmp);
            dr.Close();
            cn.Close();

        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int EmpNo, Employee objEmp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Employees set Name=@Name,Basic= @Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";

            cmd.Parameters.AddWithValue("@EmpNo", objEmp.EmpNo);
            cmd.Parameters.AddWithValue("@Name", objEmp.Name);
            cmd.Parameters.AddWithValue("@Basic", objEmp.Basic);
            cmd.Parameters.AddWithValue("@DeptNo", objEmp.DeptNo);
            try
            {
                // TODO: Add update logic here
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            finally { cn.Close(); }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int EmpNo=0)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

            SqlDataReader dr = cmd.ExecuteReader();
            Employee objEmp = new Employee();

            while (dr.Read())
            {
                if (EmpNo == (int)dr["EmpNo"])
                {

                  objEmp.EmpNo = (int)dr["EmpNo"];
                    objEmp.Name = (string)dr["Name"];
                    objEmp.Basic = (decimal)dr["Basic"];
                    objEmp.DeptNo = (short)(int)dr["DeptNo"];
                }
            }

            return View(objEmp);
            dr.Close();
            cn.Close();

        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int? EmpNo, Employee objEmp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Employees where EmpNo=@EmpNo";

            cmd.Parameters.AddWithValue("@EmpNo", objEmp.EmpNo);
            try
            {
                cmd.ExecuteNonQuery();
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
