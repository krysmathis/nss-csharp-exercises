using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalsShould
    {
        [Fact]
        public void IsAnimal()
        {
            Animal animal = new Animal();
            Assert.True(animal is Animal);
        }

        [Theory]
        [InlineData("Ralph")]
        [InlineData("Buster")]
        [InlineData("Peanut")]
        public void AnimalName(string a)
        {
            Animal animal = new Animal();
            animal.Name = a;

            Assert.Equal(animal.Name, a);
        }

        [Theory]
        [InlineData("Wolf")]
        [InlineData("Dingo")]
        [InlineData("Coyote")]
        [InlineData("Collie")]
        public void Species(string a)
        {
            Animal animal = new Animal();
            animal.Species = a;

            Assert.Equal(animal.Species, a);
        }
        
        [Fact]
        public void AnimalWalking()
        {
            Animal animal = new Animal();
            animal.Walk();

            Assert.Equal(animal.Speed, 3);
        }

       
    }
}
