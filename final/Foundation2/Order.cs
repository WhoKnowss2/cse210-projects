public class Order
{
    private List<Product> _productList;
    private Customer _customer;
    
    public Order(Customer customer)
    {
         _customer = customer;
         _productList = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public double GetTotalCost()
    {
        double total = _customer.GetIsUSA() ? 5 : 35;
        foreach (var item in _productList)
        {
            total = total + item.GetTotalCost();
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string items = "Thank you for your order. Your order includes:\n";
        foreach (var item in _productList)
        {
            items = items + item.GetId() + ": " + item.GetName( ) + "\n";
        }
        return items;
    }

    public string GetShippingLabel()
    {
        return _customer.GetName()+"\n"
        + _customer.GetAddress().GetFullAddress();
    }

}