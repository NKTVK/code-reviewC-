using System.Globalization;

namespace C_Sharp_var_10 {
  public class ProductMovement {
    public uint OperationId { get; set; }      //  ID операции
    public DateOnly Date { get; set; }         //  Дата
    public string ShopId { get; set; }         //  ID магазина
    public uint ProductArticle { get; set; }  //  Артикул товара
    public uint PackageCount { get; set; }     //  Количество упаковок, шт
    public string OperationType { get; set; }  //  Тип операции

        

    public ProductMovement() {
      OperationId = 1;
      Date = DateOnly.MinValue;
      ShopId = "не задано";
      ProductArticle = 1;
      PackageCount = 1;
      OperationType = "Поступление";
    }

    public ProductMovement(uint operationId, string date, string shopId, uint productArticle,uint packageCount, string operationType) {
      if (operationType != "Поступление" && operationType != "Продажа") {
        throw new Exception($"Ошибка валидации: некорректное значение типа операции {operationType}");
      }

      string[] formats = {
        "dd.MM.yyyy", 
        "yyyy-MM-dd", 
        "dd/MM/yyyy",
        "MM/dd/yyyy", 
        "dd.MM.yyyy H:mm:ss", 
        "dd.MM.yyyy HH:mm:ss"
      };

      if (!DateTime.TryParseExact(date.Trim(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime)) {
        throw new Exception($"Ошибка валидации: некорректное значение даты {date}");
      }

      OperationId = operationId;
      Date = DateOnly.FromDateTime(dateTime);
      ShopId = shopId;
      ProductArticle = productArticle;
      PackageCount = packageCount;
      OperationType = operationType;
    }

    public ProductMovement(uint operationId, DateOnly date, string shopId, uint productArticle,uint packageCount,string operationType) {
      if (operationType != "Поступление" && operationType != "Продажа") {
        throw new Exception("Ошибка валидации: некорректное значение типа операции.");
      }
      
      OperationId = operationId;
      Date = date;
      ShopId = shopId;
      ProductArticle = productArticle;
      PackageCount = packageCount;
      OperationType = operationType;
    }

    public override string ToString(){
      return $"ID операции: {OperationId},\tДата: {Date},\t" + 
             $"ID магазина: {ShopId},\tАртикул: {ProductArticle},\t" + 
             $"Количество упаковок: {PackageCount},\tТип операции: {OperationType}";
    }
  }
}