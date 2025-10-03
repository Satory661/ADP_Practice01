namespace ADP1_Practice01;

public class Fleet 
{
    private readonly List<Garage> _garages = new List<Garage>();

    public void AddGarage(Garage garage)
    {
        _garages.Add(garage);
        Console.WriteLine($"Гараж #{garage.Id} добавлен в автопарк");
    }

    public void RemoveGarage(Garage garage)
    {
        _garages.Remove(garage);
        Console.WriteLine($"Гараж #{garage.Id} удалён из автопарка");
    }

    public Garage? SearchVehicle(Vehicle vehicle)
    {
        foreach (var garage in _garages)
        {
            if (garage.VehiclesList.Contains(vehicle))
            {
                return garage;
            }
        }
        return null;
    }
}