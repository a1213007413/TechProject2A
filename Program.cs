using System;

namespace Tech_Project_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input between 1 and 25
            Console.WriteLine("Enter an Integer value between 1 and 25 to execute an iterative system");

            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to preform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);

                //If the vaule of user input is between 1 and 25, execute a For Loop
                if ((value_of_input > 0) && (value_of_input <=
                    25))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " time.");
                    // Here is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);

                }
                // if the user does not enter a value between 1 and 25, display a message
                else
                {
                    Console.WriteLine("Please enter an interger between 1 and 25 and try again...");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an interger between 1 and 25 and try again...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
