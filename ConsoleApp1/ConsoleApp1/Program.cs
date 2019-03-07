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
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
        }
    }
    public class DelegateExercises
    {
        public delegate int MyDelegate();
        void Method1()
        {
            System.Console.WriteLine("MyDelgate");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}




