namespace ADP1_Practice01;

public class Program
{
    public static void Main()
    {
        Car car1 = new Car(2018, "5-Series", "BMW", 4, "Automatic");
        Car car2 = new Car(2015, "E-Class", "Mercedes", 2, "Manual");
        Motorcycle moto = new Motorcycle(2021, "Panigale V4", "Ducati", "Sportbike", false);
        
        Garage garage1 = new Garage(1);
        garage1.AddVehicle(car1);
        garage1.AddVehicle(moto);

        Garage garage2 = new Garage(2);
        garage2.AddVehicle(car2);
        
        Fleet fleet = new Fleet();
        fleet.AddGarage(garage1);
        fleet.AddGarage(garage2);
        
        garage1.ShowVehicles();
        Console.WriteLine("-------------------");
        garage2.ShowVehicles();
        
        var foundGarage = fleet.SearchVehicle(car2);
        if (foundGarage != null)
        {
            Console.WriteLine($"Машина {car2.Model} найдена в гараже #{foundGarage.Id}");
        }

        foundGarage = fleet.SearchVehicle(moto);
        if (foundGarage != null)
        {
            Console.WriteLine($"Мотоцикл {moto.Model} найден в гараже #{foundGarage.Id}");
        }
    }
}