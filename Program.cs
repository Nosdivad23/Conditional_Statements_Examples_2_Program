using System; //calling the system library

namespace Conditional_Statements_Examples_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Try catch to avoid bad inputs
            try
            {
                //Prompt the user to enter a grade and assign the value to a variable
                Console.WriteLine("Enter what grade you think you will get in this class: ");
                int grade = int.Parse(Console.ReadLine());

                //Checking if grade is within the range (0,100)

                if (grade >= 0 && grade <= 100)
                {
                    //The all the if statements bellow serve to print out the correct Letter grade
                    //The reason why I am going up is because the code is read from the bottem up, so if one of the 'If' statements is true, it will break all the others
                    //No need to define an interval, just stopping points.
                    if (grade < 60)
                    {
                        Console.WriteLine("Your Letter Grade is F");
                    }
                    else if (grade < 70)
                    {
                        Console.WriteLine("Your Letter Grade is D");
                    }
                    else if (grade < 80)
                    {
                        Console.WriteLine("Your Letter Grade is C");
                    }
                    else if (grade < 90)
                    {
                        Console.WriteLine("Your Letter Grade is B");
                    }
                    //If the score is not under 90 and it does not fit any of the above criteria, it has to be an A
                    else
                    {
                        Console.WriteLine("Your Letter Grade is A");
                    }

                }
                else
                {
                    Console.WriteLine("Your grade is out of range");
                }

                Console.WriteLine("Type any key to exit");
                Console.ReadKey(true);
            }
            //Printing user friendly message to prevent future errors
            catch
            {
                Console.WriteLine("Please enter an integer between 0 and 100");
                Console.WriteLine("Exit and try again");

            }

        }
    }
}
