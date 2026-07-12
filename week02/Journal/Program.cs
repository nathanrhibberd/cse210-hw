using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        do
        {
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n> ");
            option = int.Parse(Console.ReadLine());
            if (option != 5)
            {
                Journal journal = new Journal();
                if (option == 1)
                {
                    PromptGenerator promptGenerator = new PromptGenerator();
                    Entry newEntry = new Entry();
                    DateTime theCurrentTime = DateTime.Now;

                    newEntry._promptText = promptGenerator.GetRandomPrompt();
                    Console.Write($"{newEntry._promptText}\n> ");
                    newEntry._entryText = Console.ReadLine();
                    newEntry._date = theCurrentTime.ToShortTimeString();

                    journal.AddEntry(newEntry);
                }
                else if (option == 2)
                {
                    journal.DisplayAll();
                }
                else if (option == 3)
                {
                    // LOAD
                }
                else if (option == 4)
                {
                    // SAVE
                }
                else
                {
                    Console.WriteLine("Whoops! That's in invalid input, try again!\n----------");
                }
            }
        }while (option != 5);
    }
}