using System;
public class Motorcycle : IVehicle, IDrivable, ICarriesPassengers, IPowered, IWheels
{
    double IDrivable.MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int ICarriesPassengers.PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    double IPowered.EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    string IPowered.TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int IWheels.Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
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
