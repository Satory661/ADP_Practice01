namespace ADP1_Practice01;

public class Vehicle 
{
    public int Year { get; }
    public string Model { get; }
    public string Mark { get; }

    public void StartEngine()
    {
        Console.WriteLine("Двигатель запущен");
    }

    public void StopEngine()
    {
        Console.WriteLine("Двигатель остановлен");
    }

    public Vehicle(int year, string model, string mark)
    {
        Year = year;
        Model = model;
        Mark = mark;
    }
}