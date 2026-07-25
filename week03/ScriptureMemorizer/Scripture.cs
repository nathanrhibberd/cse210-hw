using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new();
    private char[] _separators = new char[] {',', ' ', ':', '-', '.', ';'};

    // CONSTRUCTORS
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = text.Split(_separators, StringSplitOptions.RemoveEmptyEntries)
            .Select(wordText => new Word(wordText))
            .ToList();
    }

    // METHODS
    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide <= _words.Count)
        {
            int min = 0;
            int max = _words.Count;
            Random rand = new Random();
            List<int> wordsToHide = new List<int>();
            while (wordsToHide.Count < numberToHide)
            {
                wordsToHide.Add(rand.Next(min, max));
            }
            for (int w = 0; w < _words.Count; w++)
            {
                bool itsThere = wordsToHide.Contains(w);
                if (itsThere)
                {
                    _words[w].Hide();
                }
            }
        }
        else
        {
            Console.WriteLine("Number too high!");
        }
    }
    public string GetDisplayText()
    {
        string result = "";
        string currentWord = "";
        for (int i = 0; i < _words.Count; i++)
        {
            currentWord = _words[i].GetDisplayText();
            result = $"{result} {currentWord}";
        }
        return result;
    }
    public bool IsCompletelyHidden()
    {
        int wordsHidden = 0;
        for (int w = 0; w < _words.Count; w++)
        {
            bool wordHidden = _words[w].IsHidden();
            if (wordHidden)
            {
                wordsHidden++;
            }
        }
        if (wordsHidden == _words.Count)
        {
            return true;
        }
        else {return false;}
    }
}