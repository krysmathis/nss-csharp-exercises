using System;
public class JetSki : IVehicle, ISailable, IPowered, ICarriesPassengers
{
    double ISailable.MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    double IPowered.EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    string IPowered.TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int ICarriesPassengers.PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
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
