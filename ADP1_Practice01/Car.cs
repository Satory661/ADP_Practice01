namespace ADP1_Practice01;

public class Car : Vehicle 
{
    public int DoorsCount { get; }
    public string TransmissionType { get; }

    public Car(int year, string model, string mark, int doorsCount, string transmissionType) 
        : base(year, model, mark)
    {
        DoorsCount = doorsCount;
        TransmissionType = transmissionType;
    }
}