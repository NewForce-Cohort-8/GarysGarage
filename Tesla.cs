namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicles// Electric car
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"Let's charge our battery up so ions can discharge the potential energy into a fire - 100%");
        }
          public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla burns.Whooooosh!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla turns {direction} in a curve");
        }
        public override void Stop()
        {
         Console.WriteLine("The Tesla stops to burn itself up");
        }
    }
}