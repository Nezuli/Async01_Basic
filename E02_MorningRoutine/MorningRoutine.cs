using System.Threading.Tasks;
using Async01_Basic.Util;

namespace Async01_Basic.MorningRoutine
{
    public class MorningRoutine
    {
        private readonly IOutputProvider _outputProvider;

        public MorningRoutine(IOutputProvider outputProvider)
        {
            _outputProvider = outputProvider;
        }

        private void Do(string action, int actionTime = 1000)
        {
            _outputProvider.WriteLine(action);
            if(actionTime <= 0) 
                return;
            Task.Delay(actionTime).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Perform my morning routine
        /// </summary>
        public void DoMorningRoutine()
        {
            Do("Boot computer", 4000);
            Do("Make coffee", 2000);
            Do("Take a sip of coffee", 1000);
            Do("Check email/calendar", 2000);
            Do("Boot IDE", 4000);
            Do("Take a sip of coffee", 1000);
            Do("Complete programming task", 5000);
            Do("Compile code and run unit tests", 4000);
            Do("Take a sip of coffee", 1000);
            Do("Do research for project... aka browse social media", 4000);
            Do("Push changes to repository", 1000);
            Do("Time to head for lunch");
        }
    }
}