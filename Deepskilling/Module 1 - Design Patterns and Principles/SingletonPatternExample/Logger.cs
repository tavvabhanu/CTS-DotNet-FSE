using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        // Private static instance
        private static Logger instance;

        // Private constructor
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        // Public static method
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
    }
}