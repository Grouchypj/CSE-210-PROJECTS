class Exclamation : Word
{
    private string value;
    public Exclamation(string val) { value = val; }
    public override string ToString() { return $"Exclamation: {value}"; }
}
