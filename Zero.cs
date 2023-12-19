namespace Garage
{
    public class Zero  : Vehicle// Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
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