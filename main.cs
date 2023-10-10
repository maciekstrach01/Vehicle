class Program
{
    static void Main(string[] args)
    {
        Trip trip = new Trip();

        while (true)
        {
            Console.WriteLine("1. Add car");
            Console.WriteLine("2. Add bus");
            Console.WriteLine("3. Add plane");
            Console.WriteLine("4. Display trip info");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        trip.AddVehicle(new Car());
                        break;
                    case "2":
                        trip.AddVehicle(new Bus());
                        break;
                    case "3":
                        trip.AddVehicle(new Plane());
                        break;
                    case "4":
                        trip.DisplayVehiclesInfo();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please choose again");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}

