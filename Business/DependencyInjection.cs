// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DependencyInjection.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved. 
// </copyright>
// <summary>
//   Defines the DependencyInjection type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


namespace Business
{
    using Microsoft.Extensions.DependencyInjection;
    using AutoMapper;
    using System.Reflection;

    using Infrastructure.Services;
    using Business.Services;
    using Core.Services;
    using Core.Repositories;
    using Infrastructure;
    using Infrastructure.Data;

    public static class DependencyInjection
    {
        /// <summary>
        /// The register business dependencies.
        /// </summary>
        /// <param name="services">
        /// The services.
        /// </param>
        /// <returns>
        /// The <see cref="IServiceCollection"/>.
        /// </returns>
        public static IServiceCollection RegisterBusinessDependencies(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ICaseServices, CaseServices>();
            services.AddSingleton<ICaseRepository, CaseRepository>();
            services.AddSingleton<IConsultaCEP, ConsultaCEP_Correios>();
            services.RegisterInfrastructureDependencies();

            return services;
            
        }
    }
}
