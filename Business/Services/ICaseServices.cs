// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaseService.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved.   
// </copyright>
// <summary>
//   The CaseServices interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Business.Services
{
    using System.Threading.Tasks;
    using Core.Dtos;

    public interface ICaseServices
    {
        /// <summary>
        /// The update case.
        /// </summary>
        /// <param name="caseDto">
        /// The case DTO.
        /// </param>
        Task<(ValidationResultDto, bool)> UpdateCase(CaseDto caseDto);
    }
}
