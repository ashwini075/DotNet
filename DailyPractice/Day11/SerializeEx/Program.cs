using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Seializeex1

{
    class Program
    {
        public static void SerializeData()
        {
            string str = "Welcome at TutorialRide.";
            // Create file to save the data.
            FileStream fs = new FileStream(@"E:\MyDataFile.txt", FileMode.Create);
            // BinaryFormatter object will perform the serialization
            BinaryFormatter bf = new BinaryFormatter();
            // Serialize() method serializes the data to the file
            bf.Serialize(fs, str);
            // Close the file
            fs.Close();
        }
        public static void DeSerializeData()
        {
            // Open file to read the data
            FileStream fs = new FileStream(@"E:\MyDataFile.txt", FileMode.Open);
            // BinaryFormatter object performs the deserialization
            BinaryFormatter bf = new BinaryFormatter();
            // Create the object to store the deserialized data
            string data = "";
            data = (string)bf.Deserialize(fs);
            //// Close the file
            fs.Close();
            // Display the deserialized strings
            Console.WriteLine("Your deserialize data is ");
            Console.WriteLine(data);
        }
      
        static void Main1(string[] args)
        {
            SerializeData();
            DeSerializeData();
            Console.ReadLine();
        }
    }
}
//to do :craete a seriazliation for employee class
namespace EmployeeClass
{
    class Program
    {
        static void Main()
        {
            serializable();
            Deserializable();
            Console.ReadLine();
        }
        public static void serializable()
        {
            Employee obj = new Employee(1, "Ashwini");
            //create file to save data
            FileStream fs = new FileStream(@"E:\Employee.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, obj);
            fs.Close();
        }
        public static void Deserializable()
        {
            Employee obj1 ;
            //create file to save data
            FileStream fs = new FileStream(@"E:\Employee.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            obj1= (Employee) bf.Deserialize(fs);
            int id = obj1.EmpId;
            string name = obj1.EmpName;
            fs.Close();
            Console.WriteLine("Employee Data : "+id +" "+name);
        }
    }
    [Serializable]
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public Employee(int id,string name)
        {
            EmpId = id;
            EmpName = name;
        }
    }
}