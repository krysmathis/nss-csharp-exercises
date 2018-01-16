using System;
using Xunit;

namespace bagoloot.Tests
{
    public class ChildRegisterShould
    {
         public Child _child;

        public ChildRegisterShould() {
            _child = new Child();
            _child.FirstName = "Bobby";
            _child.LastName = "Hill";
            _child.Address = "1600 Pennsylvania Ave";
        }

        [Fact]
        public void AddChild()
        {   
            
            ChildRegister register = new ChildRegister();
            register.AddChild(_child);

            Assert.Contains(_child, register.GetContents());

        }

        [Fact]
        public void RemoveChild()
        {   
            
            ChildRegister register = new ChildRegister();
            register.RemoveChild(_child);

            Assert.DoesNotContain(_child, register.GetContents());

        }
    }
}
