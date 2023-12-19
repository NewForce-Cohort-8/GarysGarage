namespace Garage
{
    public class Ram  : Vehicle// Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
          public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. Baraaaaaaaaaap!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram comes to a halt");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MaximumOccupancy} seater Ram turns {direction} but diagonally really. ");
        }
    }
}