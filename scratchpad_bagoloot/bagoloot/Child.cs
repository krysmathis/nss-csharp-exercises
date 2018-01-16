using System.Collections.Generic;

namespace bagoloot
{
    public class Child
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool Delivered { get; set; } = false;
        public List<string> BagOLoot = new List<string>();
    }

}