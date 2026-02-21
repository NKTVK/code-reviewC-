using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_var_10 {
  public class Shop {
    public string Id;         //  ID магазина
    public string District;   //  Район
    public string Address;    //  Адрес

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
