﻿using System;

namespace ConsoleApp1
{
    class MultipleLogWriter:ILogerWriter
    {
        
        private ILogerWriter[] _ilogerWriters;
        public MultipleLogWriter(ILogerWriter[] logersArg)
        {
            _ilogerWriters = logersArg;
        }

        public void LogInfo(string message)
        {
            foreach (var log in _ilogerWriters)
            {
                log.LogInfo(message);
            }
        }
        public void LogWarning(string message)
        {
            foreach (var log in _ilogerWriters)
            {
                log.LogWarning(message);
            }
        }
        public void LogError(string message)
        {
            foreach (var log in _ilogerWriters)
            {
                log.LogError(message);
            }
        }
    }
}
