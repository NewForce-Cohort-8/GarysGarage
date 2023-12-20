namespace Garage
{
    public class Zero  : Vehicle, IElectricVehicles// Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage {get; set;}
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"We can't go potato without any go go juice - 100%");
        }
          public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past. Potato! Potato! Potato!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MaximumOccupancy} seater gradually comes to a very nice stop")   ;
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {BatteryKWh} powered Zero turns {direction} to go somewhere fun");
        }
    }
}