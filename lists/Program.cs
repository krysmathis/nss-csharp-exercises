using System;
using System.Collections.Generic;
using System.Linq;

namespace lists
{
    class Program
    {
        public class Probe {

        public Probe(string name) 
        {
            this.Name = name;
               
        }
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
            List<string> planetList = new List<string>(){
                "Mercury", "Mars", "Jupiter", "Saturn"
            };

            List<string> lastPlanets = new List<string>(){
                "Uranus","Neptune"
            };

            planetList.AddRange(lastPlanets);
            planetList.Insert(1,"Venus");
            planetList.Insert(2,"Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0,4);
            planetList.Remove("Pluto");   


            List<Dictionary<string,List<string>>> spacecraft = new List<Dictionary<string,List<string>>>() 
            {
                new Dictionary<string,List<string>>() {
                    {"Mariner", new List<string>(){"Mercury", "Venus", "Mars"}}
                },
                new Dictionary<string,List<string>>() {
                    {"Venera", new List<string>() {"Venus"}}
                },
                new Dictionary<string,List<string>>() {
                    {"Voyager", new List<string>() {"Jupiter", "Saturn", "Neptune", "Uranus"}},
                },
                new Dictionary<string,List<string>>() {
                    {"Pioneer", new List<string>() {"Jupiter"}}
                },
               
            };
           
            // initialize variables to contain the strings
            string probesThatVisitedThisPlanet = "";
            int c = 0;

            /*
                Here I used the ForEach using lambda, which is going around the intended
                meaning of the lambda expression
             */
            planetList.ForEach(planet => {

                //initialize the output string
                probesThatVisitedThisPlanet = "";
                // loop through the list of spacecraft
                // keep track of how many matches to handle the formatting of commas on the final output
                c=0;

                spacecraft.ForEach(probe => {
                    // loop through the dictionary of planets visited
                    foreach(KeyValuePair<string,List<string>> spacecraftEntry in probe) {
                        // get the probe name and list of planets visited from the 
                        // current probe and planet list
                        string currentProbe = spacecraftEntry.Key;
                        List<string> currentPlanetVisited = spacecraftEntry.Value;

                        //if the current planet is in the list, then add it to the 
                        // list of probes that have visited this planet
                        if (currentPlanetVisited.Any(p => p.Equals(planet))) {
                            c++;
                            if (c==1) {
                                probesThatVisitedThisPlanet = currentProbe;
                            } else {
                                probesThatVisitedThisPlanet = probesThatVisitedThisPlanet +  ", " + currentProbe;
                            }
                        }
                    }

                });

                // now output planets
                if (probesThatVisitedThisPlanet.Length > 0) {
                    Console.Write($"{planet}: ");
                    Console.WriteLine(probesThatVisitedThisPlanet);
                }

            });
              
        }
    }
}
