using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinProj_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Student 
        {
            //add static var
            private static int count; 
            private int _no;
            private string _name;
            private string _major;

            public void setCount() 
            {
                count++;
            }
            public int getCount() 
            {
                return count;
            }

            //標準基本建構子
            public Student() 
            {
                _no = -1;
                _name = "Bob";
                _major = "Math";
            }

            //建構子+參數
            public Student(int i,string n,string m)
            {
                _no = i;
                _name = n;
                _major = m;
            }
            //student method
            public void Show()
            {
                Console.WriteLine("{0} {1} {2}", _no, _name, _major);
            }
           //這邊是set get原始概念
            public int getNo() 
            {
                return _no;
            }
            public void setNo(int s) 
            {
                _no = s;
            }

            public string getName()
            {
                return _name;
            }
            public void setName(string s)
            {
                _name = s;
            }

            public string getMajor()
            {
                return _major;
            }
            public void setMajor(string s)
            {
                _major = s;
            }
            //到這是set get原始概念
            public void ShowInfo() 
            {
                Console.WriteLine("{0} {1} {2}", _no, _name, _major);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.setNo(1);
            s.setName("Bruce");
            s.setMajor("Chinese");
            s.ShowInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.Show();
            Student s2 = new Student(2, "Tom", "Math");
            s2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student2 s3 = new Student2();
            s3.No = 1;
            s3.Name = "Marry";
            s3.Major = "English";
            Console.WriteLine("{0} {1} {2}", s3.No, s3.Name, s3.Major);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var宣告static時 s1,s2對於count都會存在並改變 s1 count+1 到s2 又+1
            Student s1 = new Student();
            s1.setCount();
 
            Student s2 = new Student();
            Console.WriteLine("{0} {1}", s1.getCount(), s2.getCount());
            s2.setCount();
            Console.WriteLine("{0} {1}", s1.getCount(), s2.getCount());
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Teacher t1 = new Teacher();
            //get預設建構子
            //Console.WriteLine("Age: {0} name: {1} major: {2}", t1.Age, t1.Name, t1.major);
            t1.ShowInfo();
            //set value to 建構子
            t1.Age = 28;
            t1.Name = "Jammy";
            t1.major = "Math";
            //Console.WriteLine("Age: {0} name: {1} major: {2}", t1.Age, t1.Name, t1.major);
            t1.ShowInfo();

            t1.setCount();//不加static 每按一次button count離開迴圈變數會變回去
            Console.WriteLine("count: {0}", t1.getCount());
        }
    }
}
