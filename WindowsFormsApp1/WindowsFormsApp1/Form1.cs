using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "Hello World";
            byte[] arr = Encoding.Default.GetBytes(s);
            FileStream stream = File.Open("E:\\aaaa\\a.txt", FileMode.Create);
            stream.Write(arr, 0, arr.Length);
            stream.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //string s = "Hello Ashu";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo drive = new DriveInfo("D");

        }

    }
}
