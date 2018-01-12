using System;
using System.Collections.Generic;

namespace bangazon
{
    partial class Program
    {
        public class ITEmployee : Employee, IHandicapable, IShiftable, ISecurable
        {
            
            private List<string> _handicaps;
            public List<string> Handicaps { get => _handicaps; }
            public string Shift { get; set; }
            public int AccessLevel { get; set; }

            public ITEmployee(string firstName, string lastName, string shift, int accessLevel) : base(firstName, lastName)
            {
                _handicaps = new List<string>();
                Shift = shift;
                AccessLevel = accessLevel;
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

