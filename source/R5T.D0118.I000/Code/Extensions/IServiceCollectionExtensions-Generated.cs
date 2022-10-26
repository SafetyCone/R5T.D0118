using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0118;
using R5T.T0147;


namespace R5T.D0118.I000
{
	public static partial class IServiceCollectionExtensions
	{
		/// <summary>
		/// Adds the <see cref="ServiceA01"/> implementation of <see cref="IServiceA"/> as a <see cref="ServiceLifetime.Singleton"/>.
		/// </summary>
		public static IServiceCollection AddServiceA01(this IServiceCollection services)
		{
			services
				.AddSingleton<IServiceA, ServiceA01>();
		
			return services;
		}
		/// <summary>
		/// Adds the <see cref="ServiceA02"/> implementation of <see cref="IServiceA"/> as a <see cref="ServiceLifetime.Singleton"/>.
		/// </summary>
		public static IServiceCollection AddServiceA02(this IServiceCollection services)
		{
			services
				.AddSingleton<IServiceA, ServiceA02>();
		
			return services;
		}
		/// <summary>
		/// Adds the <see cref="ServiceB01"/> implementation of <see cref="IServiceB"/> as a <see cref="ServiceLifetime.Singleton"/>.
		/// </summary>
		public static IServiceCollection AddServiceB01(this IServiceCollection services,
			IServiceAction<IServiceA> serviceAAction)
		{
			services
				.Run(serviceAAction)
				.AddSingleton<IServiceB, ServiceB01>();
		
			return services;
		}
	}
}
