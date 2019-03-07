//damanpreet singh
//.C0731788
//Assignment2
//March 07,2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DelegateExercises
    {
        public delegate void MyDelgate();


        void Method1()
        {

            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelgate myDelgate = new MyDelgate(Method1);

            myDelgate();
        }





    }
}

class Program
{
    static void Main(string[] args)
    {
    }
}