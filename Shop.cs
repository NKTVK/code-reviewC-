namespace C_Sharp_var_10 {
  public class Shop {
    public string Id { get; set; }        //  ID магазина
    public string District { get; set; }   //  Район
    public string Address { get; set; }    //  Адрес

    public Shop() {
      Id = "не задано";
      District = "не задано";
      Address = "не задано";
    }

    public Shop(string id, string district, string address) {
      Id = id;
      District = district;
      Address = address;
    }

    public override string ToString() {
      return $"ID магазина: {Id},\tРайон: {District},\tАдрес: {Address}";
    }
  }
}
