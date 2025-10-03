namespace ADP1_Practice01;

public class Garage 
{
    public List<Vehicle> VehiclesList { get; } = new List<Vehicle>();
    public int Id { get; }

    public Garage(int id)
    {
        Id = id;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        VehiclesList.Add(vehicle);
        Console.WriteLine($"Транспорт {vehicle.Model} добавлен в гараж #{Id}");
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        VehiclesList.Remove(vehicle);
        Console.WriteLine($"Транспорт {vehicle.Model} удалён из гаража #{Id}");
    }

    public void ShowVehicles()
    {
        Console.WriteLine($"Список транспорта в гараже #{Id}:");
        foreach (var vehicle in VehiclesList)
        {
            Console.WriteLine($"- {vehicle.Mark} {vehicle.Model} ({vehicle.Year})");
        }
    }
}