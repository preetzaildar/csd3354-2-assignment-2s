//damanpreet singh
//.C0731788
//Assignment2
//March 07,2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public ststic void Main()
        {

            DelegateExercises delegateExercises = new DelegateExercises();
            DelegateExercises.Method3();
            Console.ReadLine();
        }
    }

    public delegate void MyDelegate();

    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
            System.Console.WriteLine(myDelegate.ToString());
        }

    }
}

