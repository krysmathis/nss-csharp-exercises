using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> clientSide = new List<IWorker>() {
                new Greg(),
                new Lissa(),
                new Kevin()
            };

            List<IWorker> serverSide = new List<IWorker>() {
                new Krys(),
                new Chris(),
                new Ray()
            };
               

            Console.WriteLine("Client Side -- DO WORK!");
            clientSide.ForEach( x => x.Work());

            Console.WriteLine("Server Side -- DO WORK!");
            serverSide.ForEach( x => x.Work());

        }   

         public class Krys : Person, IWorker, ISpecialist {
             
            public Krys() {
                this.FirstName = "Krys";
                this.LastName = "Mathis";
            }

            public string Specialty { get; set;} = "SQL";

            public void Work() {
                Console.WriteLine($"{this.FullName}: SELECT * FROM COFFEEPOT");
            }
            
        }
        public class Chris : Person, IWorker, ISpecialist {

            public Chris() {
                this.FirstName = "Chris";
                this.LastName = "Miller";
            }
            
            public string Specialty { get; set;} = "C#";
            public void Work() {
                Console.WriteLine($"{this.FullName}: Keep those files sharp, get it like C#");
            }

        }

        public class Ray : Person, IWorker, ISpecialist {

            public Ray() {
                this.FirstName = "Ray";
                this.LastName = "Medrano";
            }
                
            public string Specialty { get; set;} = "ASP.NET";
            public void Work() {
                Console.WriteLine($"{this.FullName}: You better ASP somebody");
            }

        }

        public class Kevin : Person, IWorker, ISpecialist {

            
            public Kevin() {
                this.FirstName = "Kevin";
                this.LastName = "Haggerty";
            }
            
            public string Specialty { get; set;} = "Grunt";
            
            public void Work() {
                Console.WriteLine($"{this.FullName}: Automate, automate, automate");
            }

        }

        public class Lissa : Person, IWorker, ISpecialist {

            
            public Lissa() {
                this.FirstName = "Lissa";
                this.LastName = "Goforth";
            }
            
            public string Specialty { get; set;} = "Javascript";
            public void Work() {
                Console.WriteLine($"{this.FullName}: document.getElementById('DoWork!')");
            }

        }

        public class Greg : Person, IWorker, ISpecialist {

            
            public Greg() {
                this.FirstName = "Greg";
                this.LastName = "Lawrence";    
            }

            public string Specialty { get; set;} = "JQuery";               
            public void Work() {
                Console.WriteLine($"{this.FullName}: All I see is $");
            }

        }

    }
}

