//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace IfElse
//{
//    internal class GrossSalary
//    {
//        static void Main(string[] args)
//        {
//            //10.Write a C# program to input basic salary of an employee and calculate its  
//            //Gross salary according to following: Basic Salary <= 10000 : HRA = 20 %, DA = 80 % Basic Salary <= 20000 : HRA = 25 %, 
//            //DA = 90 % Basic Salary > 20000 : HRA = 30 %, DA = 95 %

//            double basicSal = 50000;
//            double grossSal = 0;
//            if (basicSal <= 10000)
//            {
//                grossSal = basicSal + (basicSal * 0.20 * 0.80);
//            }
//            else if (basicSal <= 20000)
//            {
//                grossSal = basicSal + (basicSal * 0.25 * 0.90);
//            }
//            else if (basicSal > 20000)
//            {
//                grossSal = basicSal + (basicSal * 0.30 * 0.95);
//            }
//            Console.WriteLine(grossSal);
//        }
//    }
//}
