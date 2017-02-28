/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while(counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}
*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int counter = 1;
            while (counter <= 10)
            {
                sum = sum + counter; //this can also be sum =+ counter;
                counter++;

                Console.WriteLine(sum);
            }
        }
    }
}
*/


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Let's count! What is the number you would like to start counting?: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("And what number would you like to end counting?: ");
            int secondNumber = int.Parse(Console.ReadLine());

            
            int counter = firstNumber;
            while (counter <= secondNumber)
            {
                Console.WriteLine(counter);
                counter++; 

            }
        }
    }
}
*/



/*namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Let's make some factorials! What is the number you would like to start with?: ");
            int userInput = int.Parse(Console.ReadLine());


     
            int sum = 1; 

            while (userInput >= 1)
            {
               if (sum < 1)
                {
                    break;
                }

                sum = sum * userInput;
                userInput--;

            }

            Console.WriteLine("The factorial sum is " + sum);
        }
    }
}
*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a program to print the sum of the range of the user's numbers

            Console.WriteLine("Hello! Give me one number: ");
                int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a larger number: ");
                int secondNumber = int.Parse(Console.ReadLine());


            int total = 1;
            

            while (secondNumber >= firstNumber )
            {

                total = firstNumber * total; 

                firstNumber++;
                
            }
            Console.WriteLine("The sum of the range of numbers is: " + total);
        }
    }
}
*/


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a basic for loop

           
            for(int number = 0; number <= 100; number++)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}

*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a for loop example. Ask user for input 
            //Calculate number to the user's entered exponent
            //Write output to console 

            Console.WriteLine("Hello! Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            double answer = Math.Pow(number, exponent);

            Console.WriteLine("The answer is: " + answer);

            
            
        }
    }
}
*/


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //do-while loop example

            bool keepGoing = true;
            do
            {
                Console.WriteLine("Enter a number between 1 and 10: ");
                int userNumber = int.Parse(Console.ReadLine());
            
                if(userNumber == 7)
                {
                    Console.WriteLine("You guessed the right number!");
                    keepGoing = false;
                }

                else
                { Console.WriteLine("That's not the number I'm thinking of. Try again. ");
                    
                }
                

            } while (keepGoing == true);


        }
    }
}

*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an app that counts by ones

            Console.WriteLine("Hello! Give me a number to count to: ");
            int userNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= userNumber; i++)
            {
                Console.WriteLine(i);
            }
            


        }
    }
}
*/


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //app that prints  a range of odd numbers to the console

            Console.WriteLine("Hello! Let's count odd numbers. Give me a low odd number: ");
            int answer = int.Parse(Console.ReadLine());

            Console.WriteLine("Great! How high should I count to?: ");
            int highNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= highNumber; i++)
            {
                answer =+ i;

                i++;

                Console.WriteLine(answer);
            }
            


        }
    }
}

*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a console application that finds the sum of 1 to 20 and outputs that sum to the console.

            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum += i;
                Console.WriteLine(sum);
            }

            Console.WriteLine(sum);

        }
    }
}
*/
