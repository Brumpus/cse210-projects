public class Address{
    private string _city;
    private string _street;
    private string _stateProvince;
    private string _country;
    public Address(string city, string street, string state, string country){
        _city = city;
        _street = street;
        _stateProvince = state;
        _country = country;
    }
    // public bool IsStateside(){
    //     bool stateside = new bool();
    //     if(_country == "USA"){
    //         stateside = true;
    //         return stateside;
    //     }
    //     else{
    //         stateside = false;
    //         return stateside;
    //     }
    // }
    public string GetAddress(){
        string address = ($"{_street}\n{_city}, {_stateProvince}, {_country}");
        return address;
    }
}