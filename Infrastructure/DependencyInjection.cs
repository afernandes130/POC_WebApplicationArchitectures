﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DependencyInjection.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved. 
// </copyright>
// <summary>
//   The dependency injection.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Infrastructure
{
    using Microsoft.Extensions.DependencyInjection;
    using Core.Services;
    using Infrastructure.Services;
    using Orbium.Core.Services;

    public static class DependencyInjection
    {
        /// <summary>
        /// The register infrastructure dependencies.
        /// </summary>
        /// <param name="services">
        /// The services.
        /// </param>
        /// <returns>
        /// The <see cref="IServiceCollection"/>.
        /// </returns>
        public static IServiceCollection RegisterInfrastructureDependencies(this IServiceCollection services )
        {
            services.AddSingleton<IEmailService, EmailService>();
            services.AddSingleton<ILoggerService, LoggerService>();
            services.AddSingleton<IConsultaCEP, ConsultaCEP_Correios>();
            return services;
        }
    }
}
