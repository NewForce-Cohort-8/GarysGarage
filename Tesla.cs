namespace Garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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