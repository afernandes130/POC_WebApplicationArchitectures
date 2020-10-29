using Core.Repositories;
using Core.
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using Core.Services;
using Infrastructure.Services;
using AutoMapper;
using Business.Extensions;

namespace Business
{
    public static class DependencyInjection
    {
        public static void registerBusinessDependencies(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperConfig());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddSingleton<ICaseRepository, CaseRepository>();
            services.AddSingleton<IConsultaCEP, ConsultaCEP_Correios>();
            
        }
    }
}
