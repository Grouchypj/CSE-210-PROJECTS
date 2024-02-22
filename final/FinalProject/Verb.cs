class Verb : Word
{
    private string value;
    public Verb(string val) { value = val; }
    public override string ToString() { return $"Verb: {value}"; }
}