using System;
using Xunit;

namespace Animals.Tests
{
    public class DogsShould
    {
        [Fact]
        public void IsDog()
        {
            Dog dog = new Dog();
            Assert.True(dog is Dog);
        }

        [Fact]
        public void DogWalking()
        {
             Dog dog = new Dog();
             dog.Walk();

            Assert.Equal(dog.Speed, 3.5);
        }
    }
}