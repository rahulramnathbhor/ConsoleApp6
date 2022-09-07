using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampledemo
{
    internal class class1
    {
        static void Main(string[]args)
        {
            
                {
                { 
                    int num = 10 20 ;
                    Console.WriteLine("1. for add");
                    Console.WriteLine("2. for sub");
                    Console.WriteLine("3. for div");
                    Console.WriteLine("4. for multiply");
                    Console.WriteLine(". for mod");
                    Console.WriteLine("select your option");
                    Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("You have selected Addition of {num1+num2} ");
                            break;
                        case 2:
                            Console.WriteLine("You have selected Substraction {num1-num2) ");
                            break;
                        case 3:
                            Console.WriteLine("You have selected Division {num/num2} ");
                            break;
                        case 4:
                            Console.WriteLine("You have selected Multiplication {num1*num2} ");
                            break;
                        case 5:
                            Console.WriteLine("You have selected Modular {num1%num2} ");
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                }

            
        }





        }
    }
}
    