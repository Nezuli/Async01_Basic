using System.Threading.Tasks;
using Async01_Basic.Util;

namespace Async01_Basic.MorningRoutine.Cheatsheet
{
    public class MorningRoutineOrg
    {
        private readonly IOutputProvider _outputProvider;

        public MorningRoutineOrg(IOutputProvider outputProvider)
        {
            _outputProvider = outputProvider;
        }

        private void Do(string action, int actionTime = 0)
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
            Do("Boot computer", 2000);
            Do("Make coffee", 2000);
            Do("Take a sip of coffee", 1000);
            Do("Check email/calendar", 1000);
            Do("Boot IDE", 2000);
            Do("Take a sip of coffee", 1000);
            Do("Complete programming task", 4000);
            Do("Compile code and run unit tests", 4000);
            Do("Take a sip of coffee", 1000);
            Do("Do research for project... aka browse social media", 2000);
            Do("Push changes to repository", 1000);
            Do("Time to head for lunch");
        }
    }
}