namespace Garage
{
    public class Cessna : Vehicle, IGasVehicles // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set;}
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
            Console.WriteLine($"Let's not fall out of the sky and refuel our tank to be completely refueled.");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past. Zoooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna comes to a very gentle stop.");
        }
    }
}