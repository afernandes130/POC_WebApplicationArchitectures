// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BusinessAutoMapping.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved. 
// </copyright>
// <summary>
//   The auto mapping.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


namespace Business.Common.Mappings
{
    using AutoMapper;

    using FluentValidation.Results;

    using Core.Domain;
    using Core.Dtos;

    class BusinessAutoMapping : Profile
    {
        public BusinessAutoMapping()
        {
            CreateMap<CaseDto, Case>();
            CreateMap<Case, CaseDto>();

            this.CreateMap<ValidationResult, ValidationResultDto>();
            this.CreateMap<ValidationFailure, ValidationFailureDto>();
        }



    }
}
