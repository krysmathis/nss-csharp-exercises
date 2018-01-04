using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        public class Probe {

            public string Name {get; set;}
            public List<string> PlanetsVisited {get; set;}

            public Probe(string name, List<string> planetsVisited) {
                this.Name = name;
                this.PlanetsVisited = PlanetsVisited;
            }

        }
        static void Main(string[] args)
        {
            // Lists
            List<string> planetList = new List<string>(){"Mercury", "Mars", "Jupiter", "Saturn"};
            List<string> lastPlanets = new List<string>(){"Uranus","Neptune"};
            planetList.AddRange(lastPlanets);
            planetList.Insert(1,"Venus");
            planetList.Insert(2,"Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0,4);
            planetList.Remove("Pluto");   

            // List of Dictionaries
            List<Dictionary<string,string>> probes = new List<Dictionary<string,string>>(){};
            probes.Add(new Dictionary<string,string>{{"Mariner","Mercury"}});
            probes.Add(new Dictionary<string,string>{{"Mariner","Venus"}});
            probes.Add(new Dictionary<string,string>{{"Mariner","Mars"}});
            probes.Add(new Dictionary<string,string>{{"Venera","Venus"}});
            probes.Add(new Dictionary<string,string>{{"Voyager","Jupiter"}});
            probes.Add(new Dictionary<string,string>{{"Voyager","Saturn"}});
            probes.Add(new Dictionary<string,string>{{"Pioneer","Jupiter"}});

            // An alernate approach using a probe object created above, 
            // this however is not a dictionary
            List<Probe> probeList = new List<Probe>(){};
            probeList.Add(new Probe("Maringer",new List<string>() {"Mercury", "Venus", "Mars"}));

            // initialize variables to contain the strings
            string planets = "";
            int c = 0;
            
            planetList.ForEach(planet => {
                planets = "";
                c = 0;
                probes.ForEach(probe => {
                    foreach(KeyValuePair<string,string> kvp in probe) {
                        if (kvp.Value == planet) {
                        c++;
                            if (c==1) {
                                planets = kvp.Key;
                            } else {
                                planets = planets +  ", " + kvp.Key;
                            }
                        }
                    }
                });
                // only output results if the planet was visited by a probe
                if (planets.Length > 0) {
                    Console.Write($"{planet}: ");
                    Console.WriteLine(planets);
                } 
            });


        
        }
    }
}
