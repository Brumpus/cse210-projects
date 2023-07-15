public class Products{
    private string _name;
    private int _productID;
    private double _quantity;
    private double _price;
    public Products(string name, int ID, double quantity, double price){
        _name = name;
        _productID = ID;
        _quantity = quantity;
        _price = price;
    }
    public double GetPrice(){
        double fullPrice = _quantity * _price;
        return fullPrice;
    }
    public string GetPackingInfo(){
        string info = ($"{_name} --- {_productID}");
        return info;
    }
}