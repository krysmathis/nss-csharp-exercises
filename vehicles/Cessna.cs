using System;
public class Cessna : IVehicle, IDoors, IFlyable, IWheels, IPowered, ICarriesPassengers
{
    int ICarriesPassengers.PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    double IFlyable.MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    bool IFlyable.Winged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int IDoors.Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int IWheels.Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    double IPowered.EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    string IPowered.TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
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
