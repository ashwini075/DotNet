using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBindingAndDb.Models;

namespace ModelBindingAndDb.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            //List<Employee> objEmpList = new List<Employee>();
            //objEmpList.Add(new Employee { EmpNo = 1, Name = "Ashwini", Basic = 90000, DeptNo = 10 });
            //objEmpList.Add(new Employee { EmpNo = 2, Name = "Ashuu", Basic = 90000, DeptNo = 10 });
            //objEmpList.Add(new Employee { EmpNo = 3, Name = "Mahii", Basic = 96660, DeptNo = 10 });
            //objEmpList.Add(new Employee { EmpNo = 4, Name = "Kaluu", Basic = 90000, DeptNo = 10 });
           
            //or
            
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

            SqlDataReader dr = cmd.ExecuteReader();
            
            List<Employee> objEmpList = new List<Employee>();

            while (dr.Read())
            {
                objEmpList.Add(new Employee {EmpNo= (int)dr["EmpNo"], Name= (string)dr["Name"],Basic=(decimal)dr["Basic"],DeptNo=(short)(int)dr["DeptNo"]  });
              

            }
           
            return View(objEmpList);
            dr.Close();
            cn.Close();
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id=0)
        {
            //Employee objEmp = new Employee();
            //objEmp.EmpNo = 123;
            //objEmp.Name = "sai";
            //objEmp.Basic = 65421645;
            //objEmp.DeptNo = 20;

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
                if (id == (int)dr["EmpNo"])
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
                // string Name = objEmp.Name;

                cmd.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            finally { cn.Close(); }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id=0)
        {
            //Employee objEmp = new Employee();
            //objEmp.EmpNo = 123;
            //objEmp.Name = "Asj";
            //objEmp.Basic = 64312;
            //objEmp.DeptNo = 10;

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
                objEmpList.Add(new Employee {  EmpNo = (int)dr["EmpNo"], Name = (string)dr["Name"], Basic = (decimal)dr["Basic"], DeptNo = (short)(int)dr["DeptNo"] });
            
                if (id == (int)dr["EmpNo"])
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
        public ActionResult Edit(int? id, Employee objEmp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Employees set Name=@Name,Basic= @Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";
            
            cmd.Parameters.AddWithValue("@EmpNo", id);
            cmd.Parameters.AddWithValue("@Name", objEmp.Name);
            cmd.Parameters.AddWithValue("@Basic", objEmp.Basic);
            cmd.Parameters.AddWithValue("@DeptNo", objEmp.DeptNo);

            try
            {
                // TODO: Add update logic here
                //  string Name = objEmp.Name;
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
        public ActionResult Delete(int id)
        {
            //Employee objEmp = new Employee();
            //objEmp.EmpNo = 123;
            //objEmp.Name = "Asj";
            //objEmp.Basic = 64312;
            //objEmp.DeptNo = 10;


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
                if (id == (int)dr["EmpNo"])
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
        public ActionResult Delete(int id, Employee objEmp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Employees where EmpNo=@EmpNo";

            cmd.Parameters.AddWithValue("@EmpNo", id);
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
