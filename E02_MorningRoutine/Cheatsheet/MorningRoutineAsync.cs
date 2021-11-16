using System.Threading.Tasks;
using Async01_Basic.Util;

namespace Async01_Basic.MorningRoutine.Cheatsheet
{
    public class MorningRoutineAsync
    {
        private readonly IOutputProvider _outputProvider;

        public MorningRoutineAsync(IOutputProvider outputProvider)
        {
            _outputProvider = outputProvider;
        }

        private async Task Do(string action, int actionTime = 0)
        {
            _outputProvider.WriteLine(action);
            if(actionTime <= 0) 
                return;
            await Task.Delay(actionTime);
        }

        /// <summary>
        /// Perform my morning routine
        /// </summary>
        public async Task DoMorningRoutine()
        {
            var bootComputerTask = Do("Boot computer", 4000);
            await Do("Make coffee", 2000); // Need coffee to be done
            await Do("Take a sip of coffee", 1000);
            await bootComputerTask; // Need computer to be booted
            var checkEmailTask = Do("Check email/calendar", 2000);
            var bootIdeTask = Do("Boot IDE", 4000);
            await checkEmailTask;
            await Do("Take a sip of coffee", 1000);
            await bootIdeTask;
            await Do("Complete programming task", 5000);
            var compileCodeTask = Do("Compile code and run unit tests", 4000);
            await Do("Take a sip of coffee", 1000);
            await Do("Do research for project... aka browse social media", 4000);
            await compileCodeTask;
            await Do("Push changes to repository", 1000);
            await Do("Time to head for lunch");
        }
    }
}