using System.Threading.Tasks;
using Async01_Basic.Util;

namespace Async01_Basic.TeaTime
{
    public class TeaTime
    {
        private readonly IOutputProvider _outputProvider;

        public TeaTime(IOutputProvider outputProvider)
        {
            _outputProvider = outputProvider;
        }

        public void MakeTea()
        {
            var water = BoilWater();
            _outputProvider.WriteLine("Take cup out");
            _outputProvider.WriteLine("Put tea in cup");
            _outputProvider.WriteLine($"Pour {water} in cup");
            _outputProvider.WriteLine($"Tea is ready!");
        }

        private string BoilWater()
        {
            _outputProvider.WriteLine("Fill kettle with water");
            _outputProvider.WriteLine("Wait for kettle to finish boilding");
            Task.Delay(4000).GetAwaiter().GetResult();
            return "Boiling water";
        }
        
    }
}