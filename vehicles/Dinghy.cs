using System;
public class Dinghy : IVehicle, ISailable, ICarriesPassengers
{
    double ISailable.MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int ICarriesPassengers.PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("Smiling, we rowed our treasure-filled dinghy out to the ship");
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
