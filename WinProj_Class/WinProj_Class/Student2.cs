using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinProj_Class
{
    class Student2
    {
        private int _number;
        private string _stname;
        private string _stmajor;
        //實際用set get 存取器 更快
        public int No 
        {
            set 
            {
                _number = value;
            }
            get 
            {
                return _number;
            }
        }

        public string Name
        {
            set
            {
                _stname = value;
            }
            get
            {
                return _stname;
            }
        }

        public string Major
        {
            set
            {
                _stmajor = value;
            }
            get
            {
                return _stmajor;
            }
        }
    }
}
