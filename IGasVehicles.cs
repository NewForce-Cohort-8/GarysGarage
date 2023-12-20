namespace Garage 
{
public interface IGasVehicles 
{
 void RefuelTank()
    {
        Console.WriteLine("This vehicle's fuel is now full");
    }
    int CurrentTankPercentage { get; set;}

}
}