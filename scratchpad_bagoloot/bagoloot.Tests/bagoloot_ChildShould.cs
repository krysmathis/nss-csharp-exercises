using System;
using Xunit;

namespace bagoloot.Tests
{
    public class ChildShould
    {

        public Child _child;

        public ChildShould() {
            _child = new Child();
            _child.FirstName = "Bobby";
            _child.LastName = "Hill";
            _child.Address = "1600 Pennsylvania Ave";
        }
        [Fact]
        public void HaveProperties()
        {   
            Assert.Equal("Bobby", _child.FirstName);
            Assert.Equal("Hill", _child.LastName);
            Assert.Equal("1600 Pennsylvania Ave", _child.Address);

        }
    }
}
