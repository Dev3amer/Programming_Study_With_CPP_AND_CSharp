namespace LoggerExample
{
    class Logger
    {
        public delegate void delLogger(string message);

        public delLogger _logger;
        public Logger(delLogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger(message);
        }
    }
    internal class Program
    {
        static void LogToScreen(string message)
        {
            Console.WriteLine(message);
        }
        static void LogToFile(string message)
        {
            string Path = "Log.txt";
            using (StreamWriter Writer = new StreamWriter(Path, true))
            {
                Writer.WriteLine(message);
            }
        }
  
        static void Main(string[] args)
        {
            Logger ScreenLogger = new Logger(LogToScreen);
            Logger FileLogger = new Logger(LogToFile);

            ScreenLogger.Log("This Meesage Should Logged On Screen");
            FileLogger.Log("This Meesage Should Logged In File");
        }
    }
}