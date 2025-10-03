namespace ADP1_Practice01;
public class Motorcycle : Vehicle 
{
    public string BodyType { get; }
    public bool HasLuggageBox { get; set; }

    public Motorcycle(int year, string model, string mark, string bodyType, bool hasLuggageBox) 
        : base(year, model, mark)
    {
        BodyType = bodyType;
        HasLuggageBox = hasLuggageBox;
    }
}