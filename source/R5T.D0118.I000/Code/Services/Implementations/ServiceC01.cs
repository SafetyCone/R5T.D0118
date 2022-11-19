using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0118.I000
{
    [ServiceImplementationMarker]
    public class ServiceC01 : IServiceC, IServiceImplementation
    {
        public async Task RunAction()
        {
            // Take some time, simulating doing something.
            await Task.Delay(3000);
        }

        public async Task<string> RunFunction()
        {
            // Take some time, simulating doing something.
            await Task.Delay(3000);

            // Then return something.
            var output = $"{nameof(ServiceC01)} result";
            return output;
        }
    }
}
