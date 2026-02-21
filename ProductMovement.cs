using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace C_Sharp_var_10 {
  public class ProductMovement {
    public uint OperationId;      //  ID операции
    public DateOnly Date;         //  Дата
    public string ShopId;         //  ID магазина
    public uint ProductArticle;   //  Артикул товара
    public uint PackageCount;     //  Количество упаковок, шт
    public string OperationType;  //  Тип операции

        

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
      return $"ID операции: {OperationId},\tДата: {Date},\t" + $"ID магазина: {ShopId},\tАртикул: {ProductArticle},\t" + $"Количество упаковок: {PackageCount},\tТип операции: {OperationType}";
    }
  }
}