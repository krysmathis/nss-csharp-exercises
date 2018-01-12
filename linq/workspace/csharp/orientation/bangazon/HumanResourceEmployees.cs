using System;
using System.Collections.Generic;

namespace bangazon
{
    partial class Program
    {
        public class HumanResourceEmployees : Employee, IHandicapable
        {
            
            private List<string> _handicaps;
            public List<string> Handicaps { get => _handicaps; }
            public HumanResourceEmployees(string firstName, string lastName) : base(firstName, lastName)
            {
                _handicaps = new List<string>();

            }

            public void AddHandicap(string handicap)
            {
                _handicaps.Add(handicap);
            }

            public void RemoveHandicap(string handicap)
            {
                _handicaps.Remove(handicap);
            }
        }

    }
}

