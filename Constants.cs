namespace C_Sharp_var_10{
  public static class Constants{
    public const string LogPath = "log.txt";

    public const string DbPath = "LR-var10.xls";

    public enum LogChoice {
      None,                   // Не выбрано
      OverwriteOrCreate,      // Перезапись или создание файла
      Append                  // Добавление в файл
    }
  }
}
