using System;

using R5T.T0064;


namespace R5T.D0118
{
    [ServiceDefinitionMarker]
    public interface IServiceA : IServiceDefinition
    {
        void Run();
    }
}
