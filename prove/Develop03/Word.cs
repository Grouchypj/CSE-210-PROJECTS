public class Word
{
    public string Value { get; private set; }
    public bool IsHidden { get; set; }

    public Word(string value)
    {
        Value = value;
        IsHidden = false;
    }
}