public class Word
{
    private string _text;
    private bool _hidden;

    // CONSTRUCTORS
    public Word(string text)
    {
        _text = text;
    }

    // METHODS
    public void Hide()
    {
        _text = new string('_', _text.Length);
        _hidden = true;
    }
    public void Show()
    {
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}