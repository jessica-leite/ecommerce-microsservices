namespace SalesService.Domain;
public class SalesOrder
{
    public int Id { get; private set; }
    public DateTime OrderDate { get; private set; }
    public string CustomerId { get; private set; }
    public List<SalesOrderItem> Items { get; private set; }

    public SalesOrder(string customerId)
    {
        CustomerId = customerId;
        OrderDate = DateTime.UtcNow;
        Items = new List<SalesOrderItem>();
    }

    public void AddItem(SalesOrderItem item)
    {
        ValidateAvailability(item);
        Items.Add(item);
    }

    // TODO verify stock availability via API Gateway
    public bool ValidateAvailability(SalesOrderItem item)
    {
        return true;
    }

    public void ReduceStock()
    {
        foreach (var item in Items)
        {
            item.ReduceStock();
        }
    }
}