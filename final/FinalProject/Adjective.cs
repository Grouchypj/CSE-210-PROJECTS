class Adjective : Word
{
    private string value;
    public Adjective(string val) { value = val; }
    public override string ToString() { return $"Adjective: {value}"; }
}