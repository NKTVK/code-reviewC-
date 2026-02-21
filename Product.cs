using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Sharp_var_10 {
  public class Product {
    public uint Article;          //  Артикул
    public string Department;     //  Отдел
    public string Name;           //  Название
    public string Unit;           //  Единица измерения
    public uint ItemsPerPackage;  //  Кол-во в упаковке
    public uint Price;            //  Цена за упаковку

    public Product() {
      Article = 1;
      Department = "не задано";
      Name = "не задано";
      Unit = "не задано";
      ItemsPerPackage = 1;
      Price = 1;
    }

    public Product(uint article, string department, string name, string unit, uint itemsPerPackage, uint price) {
      Article = article;
      Department = department;
      Name = name;
      Unit = unit;
      ItemsPerPackage = itemsPerPackage;
      Price = price;
    }

    public override string ToString() {
      return $"Артикул: {Article},\tОтдел: {Department},\tНаименование: {Name},\t" + $"Единица измерения: {Unit},\tКоличество в упаковке: {ItemsPerPackage},\t" + $"Цена за упаковку: {Price}";
    }
  }
}
