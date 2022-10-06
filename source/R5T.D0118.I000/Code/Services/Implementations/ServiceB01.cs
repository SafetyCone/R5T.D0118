using System;

using R5T.T0064;


namespace R5T.D0118.I000
{
    [ServiceImplementationMarker]
    public class ServiceB01 : IServiceB, IServiceImplementation
    {
        private IServiceA ServiceA { get; }


        public ServiceB01(
            IServiceA serviceA)
        {
            this.ServiceA = serviceA;
        }

        public void Run()
        {
            this.ServiceA.Run();

            Console.WriteLine($"{nameof(ServiceB01)}");
        }
    }
}
