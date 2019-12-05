using PSModule.Core.Models;

namespace PSModule.Core.Services
{
    public class FavoriteStuffService
    {
        public static FavoriteStuff Create(int number, string pet) => new FavoriteStuff
        {
            FavoriteNumber = number,
            FavoritePet = pet
        };
    }
}
