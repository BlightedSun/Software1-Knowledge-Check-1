using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            string input = Console.ReadLine();
            Calculator calculator = new Calculator();
            Logic logic = new Logic();
            List<double> inputs = new List<double>();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Add");

                    
                    inputs = logic.GetNumbers();

                    Console.Write($"{inputs[0]} + {inputs[1]} = ");
                    Console.Write(calculator.Add(inputs[0], inputs[1]));

                    break;

                case "2":
                    Console.WriteLine("Subtract");

                    inputs = logic.GetNumbers();
                    Console.Write($"{inputs[0]} - {inputs[1]} = ");
                    Console.Write(calculator.Subtract(inputs[0], inputs[1]));
                                     
                   
                    break;


                  
                case "3":
                    Console.WriteLine("Multiply");
                    inputs = logic.GetNumbers();
                    Console.Write($"{inputs[0]} * {inputs[1]} = ");
                    Console.Write(calculator.Multiply(inputs[0], inputs[1]));
                    break;

                
                

                case "4":
                    Console.WriteLine("Divide");
                    inputs = logic.GetNumbers();
                    Console.Write($"{inputs[0]} / {inputs[1]} = ");
                    Console.Write(calculator.Divide(Convert.ToDouble(inputs[0]), Convert.ToDouble(inputs[1])));
                    break;
                    

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}