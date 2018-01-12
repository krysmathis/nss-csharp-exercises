using System.Linq;
using System.Collections.Generic;


public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        List<IFlyable> flyingVehicles = new List<IFlyable>() {
            new Cessna(),
            new HotAirBaloon()
        };
        // With a single `foreach`, have each vehicle Fly()
        flyingVehicles.ForEach(f=> f.Fly());


        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()
        List<IDrivable> roadVehicles = new List<IDrivable> {
            new Car(),
            new Motorcycle()
        };

        roadVehicles.ForEach(r => r.Drive());
        
        // Build a collection of all vehicles that operate on water
        
        List<ISailable> waterVehicles = new List<ISailable>() {
            new Dinghy(),
            new JetSki()
        };
        // With a single `foreach`, have each water vehicle Drive()
        waterVehicles.ForEach(w => w.Drive());
    }

}