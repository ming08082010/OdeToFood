using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>() {
                new Restaurant {Id = 1, Name = "Nasi Lemak", Location = "Selangor", Cuisine = CuisineType.KL},
                new Restaurant {Id = 2, Name = "Tomyam", Location = "Genting", Cuisine = CuisineType.Pahang},
                new Restaurant {Id = 3, Name = "Cendol", Location = "Geoge", Cuisine = CuisineType.Penang}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
