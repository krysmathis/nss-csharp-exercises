using System.Collections.Generic;

namespace bangazon
{
    partial class Program
    {
        public interface IHandicapable {
            
            List<string> Handicaps {get;}
            void AddHandicap(string handicap);
            void RemoveHandicap(string handicap);

        }

    }
}

