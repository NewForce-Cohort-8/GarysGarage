// Move all common properties in your vehicles to a new Vehicle class.
// Create an instance of each vehicle.
// Define a different value for each vehicle's properties.
// Create a Drive() method in the Vehicle class.
// Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!").
// Create a Turn(string direction) mathod, and a Stop() method on Vehicle. Define a basic implementation of each.
// Override all three of those methods on some of the vehicles. For example, the Stop() method for a plane would be to output the message "The white Cessna rolls to a stop after rolling a mile down the runway."
// Make your vehicle instances perform all three behaviors.

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            fxs.MainColor = "purple";
            fxs.MaximumOccupancy = 2;
            fxs.BatteryKWh = 22.5;
            Tesla modelS = new Tesla();
            modelS.MainColor = "red";
            modelS.MaximumOccupancy = 4;
            modelS.BatteryKWh = 25.3;
            Cessna mx410 = new Cessna();
            mx410.MainColor = "blue";
            mx410.MaximumOccupancy = 4;
            mx410.FuelCapacity = 60.4;
            Ram dodger = new Ram();
            dodger.MainColor = "silver";
            dodger.MaximumOccupancy = 5;
            dodger.FuelCapacity = 35.2;

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            dodger.Drive();

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            dodger.Stop();

            fxs.Turn("north");
            modelS.Turn("right");
            mx410.Turn("left");
            dodger.Turn("u");
        }
    }
}