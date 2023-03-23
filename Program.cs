using System;

namespace Conditionals_DeBord_Joshua
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //loops the program
            {

                Console.WriteLine("Enter a whole number!"); //Prompts the user to enter a whole number
                int myWholeNumber = Convert.ToInt32(Console.ReadLine());  //creates an integer called myWholeNumber with the use of Console.ReadLine()

                if (myWholeNumber >= 0)  //creates an if statement with myWholeNumber and 0
                {
                    Console.WriteLine($"{myWholeNumber} is a positive number.");  //prints out if the user inputed amount is a postive number
                }
                else  //creates an else statement going off of the if statement above
                {
                    Console.WriteLine($"{myWholeNumber} is a negative number.");  //prints out if the user inputed amount is a negative number
                }

                if (myWholeNumber % 2 == 0)  //creates an if statement with myWholeNumber and 2 and 0. i forgot what the names of the operators are called so yeah. lol
                {
                    Console.WriteLine($"{myWholeNumber} is an even number.");  //prints out if the user inputed amount is a even numebr
                }
                else  //creates an else statement going off of the if statement above
                {
                    Console.WriteLine($"{myWholeNumber} is an odd number.");  //prints out if the user inputed amount is a odd number
                }

                int number1 = 6;  //Creates an integer called number1 with the value of 6
                int number2 = 99;  //Creates an integer called number2 with the value of 99

                int firstMax = Math.Max(myWholeNumber, number1);  //creates an integer called firstMax
                int max = Math.Max(firstMax, number2);  //creates an integer called max.


                Console.WriteLine($"The maximum number of {myWholeNumber}, {number1}, and {number2} is {max}.");  //tells the user the maximum number out of myWholeNumber, number1, and number2.


                Console.WriteLine("Enter a grade (A, B, C, D, F).");  //asks the user to enter a grade and assigns it to a the char variable grade
                char grade = Console.ReadKey().KeyChar;

                switch (grade)    //prints description based on grade value
                {
                    case 'A':
                        Console.WriteLine("\nSuperior");
                        break;
                    case 'B':
                        Console.WriteLine("\nvery good");
                        break;
                    case 'C':
                        Console.WriteLine("\nAverage");
                        break;
                    case 'D':
                        Console.WriteLine("\nBelow Average");
                        break;
                    case 'F':
                        Console.WriteLine("\nFail");
                        break;
                    default:
                        Console.WriteLine("\nYou entered a valid grade");
                        break;

                }
                    



            }
        }
    }
}
