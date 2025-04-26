using System;

class Program
{
    static void Main(string[] args)
    {
        //get user input declaring grade percentage
        Console.Write("What is your grade percentage? ");
        string ui = Console.ReadLine();
        int gradePercentage = int.Parse(ui);

        string grade;

        if(gradePercentage >= 90)
        {
            grade = "A";
        }
        else if(gradePercentage >= 80)
        {
            grade = "B";
        }
        else if(gradePercentage >= 70)
        {
            grade = "C";
        }
        else if (gradePercentage >= 60)
       {
            grade = "D";
       }
       else 
       {
            grade = "F";
       }

       Console.WriteLine($"Your grade is {grade} ");
    
        //if (letter == "A" || letter == "B" || letter == "C")
        if (gradePercentage >= 70)
        {
        Console.WriteLine(" ----- Congratulations you passed ----- ");
        }
        else
        {
        Console.WriteLine("--- Sorry you failed seek help if needed and try again ---");
        }

    }
}