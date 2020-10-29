using AutoMapper;
using Core.DTO;
using Core.
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain;

namespace Business.Extensions
{
    class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CaseDTO, Case>();
            CreateMap<Case, CaseDTO>();
        }



    }
}
