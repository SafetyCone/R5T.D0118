using System;

using R5T.T0064;


namespace R5T.D0118.I000
{
    [ServiceImplementationMarker]
    public class ServiceA02 : IServiceA, IServiceImplementation
    {
        public void Run()
        {
            Console.WriteLine($"{nameof(ServiceA02)}");
        }
    }
}
