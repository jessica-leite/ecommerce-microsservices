namespace InventoryService.Domain;

    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }

        public Product(int id, string name, string description, decimal price, int stockQuantity)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public void IncreaseStock(int quantity)
        {
            StockQuantity += quantity;
        }

        public void ReduceStock(int quantity)
        {
            if (quantity > StockQuantity)
                throw new InvalidOperationException("Insufficient stock available.");
            
            StockQuantity -= quantity;
        }
}