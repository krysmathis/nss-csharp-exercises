public interface IFlyable  {

    double MaxAirSpeed { get; set; }    
    bool Winged {get; set;}
    void Fly();
}
