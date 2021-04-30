using System;

namespace exemplo7Interface
{   
    public interface ILogger {
        void logError(string msg);
        void logInfo(string msg);
    }

    public class Logger: ILogger {
        public void logError(string msg){
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(msg);
        }
        public void logInfo(string msg){
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(msg);
        }
    }
    public class DBMigrate {
        private readonly ILogger _logger;

        public DBMigrate(ILogger logger){
            _logger = logger;
        }
        public void Migrate(){
            _logger.logInfo("Tudo certo!!!");

            _logger.logError("Algo errado!!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DBMigrate(new Logger());
            db.Migrate();
        }
    }
}
