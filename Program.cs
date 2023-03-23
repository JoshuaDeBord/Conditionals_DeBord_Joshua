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

                int number1 = 4;  //Creates an integer called number1 with the value of 6
                int number2 = 82;  //Creates an integer called number2 with the value of 99

                int firstMax = Math.Max(myWholeNumber, number1);  //creates an integer called firstMax
                int max = Math.Max(firstMax, number2);  //creates an integer called max.


                Console.WriteLine($"The maximum number of {myWholeNumber}, {number1}, and {number2} is {max}.");  //tells the user the maximum number out of myWholeNumber, number1, and number2.


            }
        }
    }
}
