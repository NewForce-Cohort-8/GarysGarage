namespace Garage
{
public interface IElectricVehicles
{
    void ChargeBattery()
    {
        Console.WriteLine("This vehicle's battery is now charged");
    }
    int CurrentChargePercentage { get; set;}
}
}