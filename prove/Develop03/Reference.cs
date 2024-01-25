public class Reference
{
    private string startVerse;
    private string endVerse;

    public Reference(string startVerse)
    {
        this.startVerse = startVerse;
    }

    public Reference(string startVerse, string endVerse)
    {
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public string GetFormattedReference()
    {
        if (endVerse != null)
            return $"{startVerse}-{endVerse}";
        else
            return startVerse;
    }
}
