using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.DivideTwoIntegers(5, 2, out int remainder);
            //DivideTwoIntegers(1, 2, out int remainder2); Have to be static in order to use it without the p object
            CalcInts mySum = p.Sum;
            mySum(1, 2);
            CalcInts myDiv = p.Div;
            myDiv(1, 2);
            CalcInts mySub = p.Sub;
            mySub(1, 2);

            CalcInts myCalcs = p.Sum;
            myCalcs(1, 2);
            myCalcs = p.Div;
            myCalcs(1, 2);
            myCalcs = p.Sub;
            myCalcs(1, 2);

            CalcInts myCalcAll = myDiv + mySub + mySum;//MULTICAST DELEGATE
            //myCalcs(1, 2);
            Console.WriteLine(myCalcAll(1, 2));

            Del x = i => i * 10 + 1 - 2;
            x(5);
            //--------------------------
            Home home = new Home();
            home.Address = "Tritonos";
            home.Name = "Michalopoulos";
             

            PrintHome printDel;
            printDel = give => Console.WriteLine($"{home.Address}, {home.Name}");
            printDel(home);
            //Console.WriteLine(); 
            
            
        }

        public delegate void PrintHome(Home home);
        public delegate int Del(int i);
        public delegate int CalcInts(int i, int j);
        //public delegate int Div(int i, int j);
        //public delegate int Sub(int i, int j);


        public int Sum(int i, int j)
        {
            return (i + j);
        }
        public int Div(int i, int j)
        {
            return (i / j);
        }
        public int Sub(int i, int j)
        {
            return (i - j);
        }
        //public int DivideTwoIntegers(int i, int j, out int remainder)//By creating an object from Program, I can avoid using static
        //{
        //    remainder = i + j;
        //    return i + j;
        //}

    }
}
