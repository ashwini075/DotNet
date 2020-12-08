using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionhandlingEx
{
    class Program
    {
        //simple catch
        static void Main1(string[] args)
        {
            Class1 obj = new Class1();
            try 
            { obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }catch {
                Console.WriteLine("Exception Occured");
            }
            Console.ReadLine();
        }
        //catching multiple exception
        static void Main2(string[] args)
        {
            Class1 obj = new Class1();
            try
            {
               // obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero Exception Occured");
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("null reference expection occured");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            Console.ReadLine();
        }
        //catching base class exception
        static void Main3()
        {
            Class1 obj = new Class1();
            try
            {
                // obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }
           
            catch(FormatException e)
            {
                Console.WriteLine("FormatException occured");
            }
            catch (Exception e)
            {
                Console.WriteLine("All exceptions handled");
            }
            Console.ReadLine();
        }
        static void Main4()
        {
            Class1 obj = new Class1();
            try
            {
                // obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }

            catch (FormatException e)
            {
                Console.WriteLine("FormatException occured");
            }
            catch (Exception e)
            {
                Console.WriteLine("All exceptions handled");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.ReadLine();
        }
        static void Main()
        {
            Class1 obj = new Class1();
            try
            {
                // obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }

            catch (FormatException e)
            {
                try
                {
                    Console.WriteLine("FormatException occurred. Enter only numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                }
                catch
                {
                    Console.WriteLine("nested try catch example");
                }
                finally
                {
                    Console.WriteLine("nested try finally example");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("All exceptions handled");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.ReadLine();
        }
    }
    public class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }
    }

}