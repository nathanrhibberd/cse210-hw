using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = 0;
        int guess = 0;
        bool play_again = true;
        string more_than_30_away = "much ";
        string need_larger_number = "higher";
        string need_smaller_number = "lower";
        string your_did_it = "You guessed it!";

        do
        {
            guess = 0;
            number = randomGenerator.Next(1, 100);

            do
            {
                Console.Write("Guess a number between 1 and 100: ");
                guess = int.Parse(Console.ReadLine());
                if (guess >= 1 && guess <= 100)
                {
                    if (guess != number)
                    {
                        string message_answer = "";
                        string message_prefix = "";
                        if (guess < number)
                        {
                            message_answer = need_larger_number;
                        }
                        else
                        {
                            message_answer = need_smaller_number;
                        }
                        if ((guess + 30 < number) || (guess - 30 > number))
                        {
                            message_prefix = more_than_30_away;
                        }
                        string full_message = message_prefix + message_answer;
                        Console.WriteLine($"The number is {full_message}.");
                    }
                    else
                    {
                        Console.WriteLine(your_did_it);
                        Console.Write("Play again? [y/n]: ");
                        string yes_or_no = Console.ReadLine();
                        if (yes_or_no == "n")
                        {
                            play_again = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"I said 1 and 100, {guess} is outside that range, you sillyhead.");
                }
            } while (guess != number);
        } while (play_again == true);
    }
}