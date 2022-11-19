using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0118
{
    /// <summary>
    /// An asynchronous service.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IServiceC : IServiceDefinition
    {
        Task RunAction();
        Task<string> RunFunction();
    }
}
