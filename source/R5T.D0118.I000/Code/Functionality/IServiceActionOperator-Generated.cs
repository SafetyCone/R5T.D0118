using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0118;
using R5T.T0132;
using R5T.T0147;


namespace R5T.D0118.I000
{
	[FunctionalityMarker]
	public partial interface IServiceActionOperator : IFunctionalityMarker,
		R5T.T0147.IServiceActionOperator
	{
		/// <summary>
		/// Adds the <see cref="ServiceA01"/> implementation of <see cref="IServiceA"/> as a <see cref="ServiceLifetime.Singleton"/>.
		/// </summary>
		public IServiceAction<IServiceA> AddServiceA01Action()
		{
			var serviceAction = this.New<IServiceA>(services => services.AddServiceA01());
		
			return serviceAction;
		}
		/// <summary>
		/// Adds the <see cref="ServiceA02"/> implementation of <see cref="IServiceA"/> as a <see cref="ServiceLifetime.Singleton"/>.
		/// </summary>
		public IServiceAction<IServiceA> AddServiceA02Action()
		{
			var serviceAction = this.New<IServiceA>(services => services.AddServiceA02());
		
			return serviceAction;
		}
		/// <summary>
		/// Adds the <see cref="ServiceB01"/> implementation of <see cref="IServiceB"/> as a <see cref="ServiceLifetime.Singleton"/>.
		/// </summary>
		public IServiceAction<IServiceB> AddServiceB01Action(
			IServiceAction<IServiceA> serviceAAction)
		{
			var serviceAction = this.New<IServiceB>(services => services.AddServiceB01(
				serviceAAction));
		
			return serviceAction;
		}
	}
}
