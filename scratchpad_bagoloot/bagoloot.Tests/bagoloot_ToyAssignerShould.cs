using System;
using Xunit;

namespace bagoloot.Tests
{
    public class ToyAssignerShould
    {

        public Child _child;

        public ToyAssignerShould() {
            _child = new Child();
            _child.FirstName = "Bobby";
            _child.LastName = "Hill";
            _child.Address = "1600 Pennsylvania Ave";
        }
        
        [Fact]
        public void AssignToyToChild()
        {   
            ToyAssigner toyAssigner = new ToyAssigner();

            toyAssigner.AssignToyToChild(_child,"Bike");

            Assert.Contains("Bike", _child.BagOLoot);

        }

        [Fact]
        public void RemoveToyFromChild()
        {   
            ToyAssigner toyAssigner = new ToyAssigner();

            toyAssigner.RemoveToyFromChild(_child,"Bike");

            Assert.DoesNotContain("Bike", _child.BagOLoot);

        }
    }
}
