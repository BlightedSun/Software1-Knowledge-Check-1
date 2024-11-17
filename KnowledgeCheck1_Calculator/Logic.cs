using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    internal class Logic
    {

        
        public List<double> GetNumbers()
        {
           List<double> numbers = new List<double>();
            
            
            bool numCheckGood = true;


            do
            {
                Console.WriteLine("Please enter two numbers...");
                string inputOne = Console.ReadLine();
                string inputTwo = Console.ReadLine();
                bool isNumOne = double.TryParse(inputOne, out double resultOne);
                bool isNumTwo = double.TryParse(inputTwo, out double resultTwo);
                

                
                if (isNumOne && isNumTwo)
                {

                    numbers.Add(resultOne);
                    numbers.Add(resultTwo);

                    numCheckGood = true;
                }
                else
                {

                    Console.WriteLine("One or more of the inputs is not a number");
                    numCheckGood = false;

                }

                


                
            } while (numCheckGood == false);




            return numbers;
        }










    }
}
