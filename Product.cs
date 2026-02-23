namespace C_Sharp_var_10 {
  public class Product {
    public uint Article { get; set; }        //  Артикул
    public string Department { get; set; }     //  Отдел
    public string Name { get; set; }           //  Название
    public string Unit { get; set; }           //  Единица измерения
    public uint ItemsPerPackage { get; set; }  //  Кол-во в упаковке
    public uint Price { get; set; }           //  Цена за упаковку

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
      return $"Артикул: {Article},\tОтдел: {Department},\tНаименование: {Name},\t" + 
             $"Единица измерения: {Unit},\tКоличество в упаковке: {ItemsPerPackage},\t" + 
             $"Цена за упаковку: {Price}";
    }
  }
}
