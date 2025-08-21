namespace SalesService.Domain;

public class SalesItem
{
    public int Id { get; private set; }
    public int ProductId { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }

    public SalesItem(int productId, int quantity, decimal unitPrice)
    {
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    // TODO reduce stock via API Gateway
    public void ReduceStock()
    {
        
    }
}