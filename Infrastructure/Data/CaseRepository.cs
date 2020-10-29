// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaseRepository.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved.   
// </copyright>
// <summary>
//   Defines the CaseRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using Orbium.Database;
using Core.Repositories;

namespace Infrastructure.Data
{
    public class CaseRepository : ICaseRepository
    {
        /// <summary>
        /// The case repository.
        /// </summary>
        /// <param name="caseEntity"></param>
        public bool Update(Core.Domain.Case caseEntity)
        {
            Case _cases = new Case() {
                CaseId = caseEntity.CaseId
            };

            //_cases.Add();
            return true;
        }
    }
}
