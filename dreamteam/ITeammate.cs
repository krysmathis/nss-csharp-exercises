using System;

namespace dreamteam
{
    
    public class Person {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string FullName {get => $"{this.FirstName.ToUpper()} {this.LastName.ToUpper()}";}
    }

    public interface ISpecialist {
        string Specialty {get;set;}
    }

    public interface IWorker {
        void Work();
    }


}