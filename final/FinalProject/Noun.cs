class Noun : Word
{
    private string value;
    public Noun(string val) { value = val; }
    public override string ToString() { return $"Noun: {value}"; }
}