namespace SalesService.Domain;
public class SalesOrder
{
    public int Id { get; private set; }
    public DateTime OrderDate { get; private set; }
    public string CustomerId { get; private set; }
    public List<SalesItem> Items { get; private set; }

    public SalesOrder(string customerId)
    {
        CustomerId = customerId;
        OrderDate = DateTime.UtcNow;
        Items = new List<SalesItem>();
    }

    public void AddItem(SalesItem item)
    {
        ValidateAvailability(item);
        Items.Add(item);
    }

    // TODO verify stock availability via API Gateway
    public bool ValidateAvailability(SalesItem item)
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