namespace OData.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }

        public Car(int id, string brand, decimal price, string model) {
            Id = id;
            Brand = brand;
            Price = price;
            Model = model;
        }
    }
}