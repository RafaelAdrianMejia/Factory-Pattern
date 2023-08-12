namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of wheels your vehicle has:");
            int tireCount = int.Parse(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(tireCount);
            vehicle.Drive();
        }
    }
}
