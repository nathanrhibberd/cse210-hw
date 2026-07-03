using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What score did you get on your class? ");
        string valueInText = Console.ReadLine();
        float score = float.Parse(valueInText);
        if (score >= 0)
        {
            // Define the letter score
            string letter = "N/A";
            if (score >= 90)
            {
                letter = "A";
            }
            else if (score >= 80)
            {
                letter = "B";
            }
            else if (score >= 70)
            {
                letter = "C";
            }
            else if (score >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Define the + or - value
            string modifier = "";
            float ones_digit = score % 10;
            if (score < 95 && score > 60)
            {
                if (ones_digit >= 7)
                {
                    modifier = "+";
                }
                else if (ones_digit < 3)
                {
                    modifier = "-";
                }
                else
                {
                modifier = "";
                }
            }
            else
            {
                modifier = "";
            }

            // Define the pass/not pass message sent
            string passed = "Error lol";
            if (score >= 70)
            {
                passed = "You passed!";
            }
            else
            {
                passed = "Better luck next time!";
            }

            // Output
            Console.WriteLine($"Your grade is: {letter}{modifier} ({score}%)");
            Console.Write(passed);
        }
        else
        {
            Console.Write("You can't have a negative score, silly!");
        }
    }
}