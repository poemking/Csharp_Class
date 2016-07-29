using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinProj_Class
{
    class Teacher
    {
        private int _age;
        private string _tename;
        private string _major;
        private static int count;


        public int Age 
        {
            set { _age = value; }
            get { return _age; }
        }

        public string Name 
        {
            set { _tename = value; }
            get { return _tename; }
        }
        public string major
        {
            set { _major = value; }
            get { return _major; }
        }
        public Teacher() 
        {
            _age = -1;
            _tename = "Bruce";
            _major = "sicense";

        }
        public Teacher(int a, string n) 
        {
            _age = a;
            _tename = n;
        }
        public void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2}", _age, _tename, _major);
        }
        public void setCount() 
        {
            count++;
        }
        public int getCount() 
        {
            return count;
        }
    }
}
