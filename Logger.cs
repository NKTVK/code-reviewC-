namespace C_Sharp_var_10{
  public static class Logger{
    private static string _path => Constants.LogPath;
    public static void Init(bool overwrite){
      if (overwrite && File.Exists(_path)){
        File.WriteAllText(_path, string.Empty); // очищаем файл
      }
    }

    public static void Log(string message, string type = "INFO") {
      string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} |\t{type}\t|\t{message}";
      File.AppendAllText(_path, logEntry + Environment.NewLine);
    }
  }
}