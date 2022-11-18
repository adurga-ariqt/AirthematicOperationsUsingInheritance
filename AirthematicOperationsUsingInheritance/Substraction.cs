using MyClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirthematicOperationsUsingInheritance
{
    public  class Substraction: Multiplication
    {public double num4 { get; set; }
        public Substraction(int a,int b ,int c):base(a,b)
        {
            num3 = c;
        }
        public void MyMethod3()
        {
            MyMethod2();
            num4=num1-num3 -num2;
            Console.WriteLine("the substraction of three numbers :" + num4); 
        }

    }
}
