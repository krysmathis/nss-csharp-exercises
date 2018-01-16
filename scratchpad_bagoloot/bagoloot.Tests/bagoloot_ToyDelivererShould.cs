using System;
using Xunit;

namespace bagoloot.Tests
{
    public class ToyDelivererShould
    {

        public Child _child;

        public ToyDelivererShould() {
            _child = new Child();
            _child.FirstName = "Bobby";
            _child.LastName = "Hill";
            _child.Address = "1600 Pennsylvania Ave";
        }
        
        [Fact]
        public void DeliverToys()
        {   
            ToyDeliverer toyDeliverer = new ToyDeliverer();
            toyDeliverer.DeliverToysToChild(_child);

            Assert.True(_child.Delivered);
           
        }

    }
}
