﻿using System;


namespace ConsoleApp1
{
    class ConsoleLogWriter : AbstractClass
    {
        private static readonly Lazy<ConsoleLogWriter> _intance = new Lazy<ConsoleLogWriter>(() => new ConsoleLogWriter(),
            System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);

        public DateTimeOffset Date;
        private ConsoleLogWriter()
        {
            Date = DateTimeOffset.UtcNow;
        }

        public override void LogInfo(string massage)
        {
            var MessageType = $"{Date:yyyy:MM:ddThh:mm:ss} \t LogInfo \t {massage}\n";
            Console.WriteLine(MessageType);
        }

        public override void LogWarning(string massage)
        {
            var MessageType = $"{Date:yyyy:MM:ddThh:mm:ss} \t LogWarning \t {massage}\n";
            Console.WriteLine(MessageType);
        }

        public override void LogError(string massage)
        {
            var MessageType = $"{Date:yyyy:MM:ddThh:mm:ss} \t LogError \t {massage}\n";
            Console.WriteLine(MessageType);
        }

        public static ConsoleLogWriter Intance
        {
            get { return _intance.Value; }
        }

    }

    
}
