public class Order{
    private List<Products> _products = new List<Products>();
    private Customer _customer;
    public Order(Customer customer){
        _customer = customer;
    }
    public void GetPackingLabel(){
        foreach(Products product in _products){
            string productInfo = product.GetPackingInfo();
            Console.WriteLine(productInfo);
        }
    }
    public void GetShippingLabel(){
        string name = _customer.GetCustomerName();
        Address address = _customer.GetCustomerAddress();
        string shippingAddress = address.GetAddress();
        Console.WriteLine($"{name}\n{shippingAddress}");
    }
    public void AddProduct(Products product){
        _products.Add(product);
    }
    public string CalculateShippingCost(){
        double total = 0;
        foreach(Products product in _products){
            double price = product.GetPrice();
            total += price;
        }
        if(_customer.IsStateside() == true){
            total += 5;
        }
        else{
            total += 35;
        }
        string totalCost = ($"${total}");
        return totalCost;
    }
}