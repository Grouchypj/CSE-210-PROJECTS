class Adverb : Word
{
    private string value;
    public Adverb(string val) { value = val; }
    public override string ToString() { return $"Adverb: {value}"; }
}