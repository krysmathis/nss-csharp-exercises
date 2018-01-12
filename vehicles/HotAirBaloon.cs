using System;
public class HotAirBaloon : IVehicle, IFlyable, ICarriesPassengers
{
    int ICarriesPassengers.PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    double IFlyable.MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    bool IFlyable.Winged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
    public void Fly()
    {
        Console.WriteLine("The Hot Air Baloon floats to the stratosphere while passengers sip wine and eat cheese.");
    }

    void IVehicle.Start()
    {
        throw new NotImplementedException();
    }

    void IVehicle.Stop()
    {
        throw new NotImplementedException();
    }
}
