using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calculator : ICalculate
    {
        public int number1;
        public int number2;
        public string operate;
                
        public void Calculation(int num1, int num2, string operation)
        {
            number1 = num1; 
            number2 = num2;
            operate = operation;
            {
                if (operation == "+")
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (operation == "-")
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (operation == "*")
                {
                    Console.WriteLine(num1 * num2);
                }
                else if (operation == "/")
                {
                    Console.WriteLine(num1 / num2);
                }
            }
        }
    }
}
