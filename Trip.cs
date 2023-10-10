public class Trip
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void DisplayVehiclesInfo()
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle: {vehicle.GetType().Name}, Max speed: {vehicle.MaxSpeed}, Max passengers: {vehicle.MaxPassengers}");
        }
    }
}