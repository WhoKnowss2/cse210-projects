public class Product
{
    private string _name;
    private string _id;
    private double _unitPrice;
    private int _quantity;

    public Product(string name, string id, double unitPrice, int quantity)
    {
        _name = name;
        _id = id;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _unitPrice * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }
}