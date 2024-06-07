public interface IVehicle
{
    void Drive();
}

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Bike is driving...");
    }
}

public abstract class VehicleFactory
{
    public abstract IVehicle CreateVehicle();
    public void MakeOperation()
    {
        IVehicle vehicle = CreateVehicle();
        vehicle.Drive();
    }
}

public class CarFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}

public class BikeFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Bike();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        VehicleFactory carFactory = new CarFactory();
        carFactory.MakeOperation();
    }
}