using OData.Models;

namespace OData.Data
{
    public static class DataSource
    {
        private static List<Car> _cars { get; set; }

        public static IEnumerable<Car> GetCars()
        {
            if (_cars != null)
            {
                return _cars;
            }

            _cars = new List<Car>();

            _cars.Add(new Car(1, "Tesla", 59.99m, "Model 3"));
            _cars.Add(new Car(2, "BMW", 49.99m, "3 Series"));

            return _cars;
        }
    }
}