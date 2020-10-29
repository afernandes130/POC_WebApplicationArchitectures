// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICaseRepository.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved.
// </copyright>
// <summary>
//   Defines the ICaseRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace Core.Repositories
{
    using Core.Domain;
    /// <summary>
    /// The CaseRepository interface.
    /// </summary>
    public interface ICaseRepository
    {
        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="caseEntity">
        /// The case entity.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool Update(Case caseEntity);
    }
}
