using System;

namespace Async01_Basic.Util
{
    public class ConsoleOutputProvider : IOutputProvider
    {
        private DateTime? _firstEntry;
        
        public ConsoleOutputProvider()
        {
        }

        public void WriteLine(string? value)
        {
            var now = DateTime.Now;
            _firstEntry ??= now;

            var timeSinceFirstEntry = now.Subtract(_firstEntry.Value);
            
            Console.WriteLine($"{timeSinceFirstEntry:ss}: {value}");
        }
        
        public void WriteSummary(string? value)
        {
            Console.WriteLine(value);
        }
    }
}