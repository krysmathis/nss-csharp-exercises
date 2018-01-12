using System;
public class Car : IVehicle, IDrivable, ICarriesPassengers, IPowered, IWheels
{
    double IDrivable.MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int ICarriesPassengers.PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    double IPowered.EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    string IPowered.TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int IWheels.Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The car's passed the police car unnoticed, like the period after the Dr. on a Dr Pepper can. ");
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
