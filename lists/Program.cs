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
                    {"Voyager", new List<string>() {"Jupiter", "Saturn"}},
                },
                new Dictionary<string,List<string>>() {
                    {"Pioneer", new List<string>() {"Jupiter"}}
                }
            };
           
            // initialize variables to contain the strings
            string probeMatches = "";
            int c = 0;
            
            planetList.ForEach(planet => {
                //initialize the output string
                probeMatches = "";
                // loop through the list of spacecraft
                c=0;
                spacecraft.ForEach(probe => {
                    // loop through the dictionary of planets visited
                    foreach(KeyValuePair<string,List<string>> spacecraftKVP in probe) {
                        string probeName = spacecraftKVP.Key;
                        List<string> planetsVisited = spacecraftKVP.Value;
                        if (planetsVisited.Any(p => p.Equals(planet))) {
                            c++;
                            if (c==1) {
                                probeMatches = probeName;
                            } else {
                                probeMatches = probeMatches +  ", " + probeName;
                            }
                        }
                    }

                });

                // now output planets
                if (probeMatches.Length > 0) {
                    Console.Write($"{planet}: ");
                    Console.WriteLine(probeMatches);
                }

            });
              
        }
    }
}
