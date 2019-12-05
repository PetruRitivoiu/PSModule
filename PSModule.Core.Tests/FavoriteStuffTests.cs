using PSModule.Core.Models;
using Xunit;

namespace PSModule.Core.Tests
{
    public class FavoriteStuffTests
    {
        [Fact]
        public void PropertiesTest()
        {
            const int number = 7;
            const string pet = "Cat";

            var sut = new FavoriteStuff
            {
                FavoriteNumber = number,
                FavoritePet = pet
            };

            Assert.Equal(number, sut.FavoriteNumber);
            Assert.Equal(pet, sut.FavoritePet);
        }
    }
}
