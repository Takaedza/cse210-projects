using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade  percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        string letter = "";

        string gradeSign = "";
    

        if (gradePercentage >= 90)
        {
            letter = "A";

            if (gradePercentage >= 95)
            {
                gradeSign = "+";
            }

            else
            {
                gradeSign = "-";
            }

        }

        else if (gradePercentage >= 80)
        {
            letter = "B";

            if (gradePercentage >= 85)
            {
                gradeSign = "+";
            }

            else
            {
                gradeSign = "-";
            }
        }

        else if (gradePercentage >= 70)
        {
            letter = "C";

            if (gradePercentage >= 75)
            {
                gradeSign = "+";
            }

            else
            {
                gradeSign = "-";
            }
        }

        else if (gradePercentage >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine("Your Grade is:" + letter);

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations you have passed the class.");
        
        }

        else
        {
            Console.WriteLine("Better luck next semester.");
        }
    }
}