// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaseRepository.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved.   
// </copyright>
// <summary>
//   Defines the CaseRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using Core.Domain;
using Core.Repositories;

namespace Infrastructure.Data
{
    public class CaseRepository : ICaseRepository
    {
        /// <summary>
        /// The case repository.
        /// </summary>
        /// <param name="caseEntity"></param>
        public bool Update(Case caseEntity)
        {
            Orbium.Database.Case _cases = new Orbium.Database.Case() {
                CaseId = caseEntity.CaseId
            };

            //_cases.Add();
            return true;
        }
    }
}
