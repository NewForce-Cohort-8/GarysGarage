namespace Garage
{
    public class Ram  : Vehicle, IGasVehicles// Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage {get; set;}

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
            Console.WriteLine($"I fueled my tank up to be completely refueled. Baraaap baraaap, forgetters");
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