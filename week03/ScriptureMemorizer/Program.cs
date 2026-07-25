using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        Reference ref1 = new Reference("Moses", 1, 39);
        Scripture scripture1 = new Scripture(ref1, "This is my work and my glory—to bring to pass the immortality and eternal life of man.");
        Reference ref2 = new Reference("John", 3, 16);
        Scripture scripture2 = new Scripture(ref2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Reference ref3 = new Reference("1 Nephi", 3, 7);
        Scripture scripture3 = new Scripture(ref3, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Reference ref4 = new Reference("D & C", 130, 22, 23);
        Scripture scripture4 = new Scripture(ref4, "The Father has a body of flesh and bones as tangible as man’s; the Son also; but the Holy Ghost has not a body of flesh and bones, but is a personage of Spirit. Were it not so, the Holy Ghost could not dwell in us. A man may receive the Holy Ghost, and it may descend upon him and not tarry with him.");
        
        Scripture scriptureChosen = scripture1;
        Reference refChosen = ref1;

        static int PromptScriptureChoice ()
        {
            Console.Write("Please enter a number from 1-4: ");
            return int.Parse(Console.ReadLine());
        }

        do
        {
            option = PromptScriptureChoice();
            if (option == 1)
            {
                scriptureChosen = scripture1;
                refChosen = ref1;
            }
            else if (option == 2)
            {
                scriptureChosen = scripture2;
                refChosen = ref2;
            }
            else if (option == 3)
            {
                scriptureChosen = scripture3;
                refChosen = ref3;
            }
            else if (option == 4)
            {
                scriptureChosen = scripture4;
                refChosen = ref4;
            }
        }while (option < 1 || option > 4);

        int wordsToHide = 0;
        do
        {
        Console.Clear();
        Console.WriteLine(scriptureChosen.GetDisplayText());
        Console.WriteLine(refChosen.GetDisplayText());
        Console.Write("\nHow many words to hide? ");
        wordsToHide =  int.Parse(Console.ReadLine());
        scriptureChosen.HideRandomWords(wordsToHide);
        } while (scriptureChosen.IsCompletelyHidden() == false);
        Console.Clear();
        Console.WriteLine(scriptureChosen.GetDisplayText());
        Console.WriteLine(refChosen.GetDisplayText());
    }
}