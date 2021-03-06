﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Case.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved.
// </copyright>
// <summary>
//   Defines the Case type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Core.Domain
{
    /// <summary>
    /// The case.
    /// </summary>
    public class Case
    {
        /// <summary>
        /// Gets or sets the case id.
        /// </summary>
        public int CaseId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the process id.
        /// </summary>
        public int ProcessId { get; set; }
    }
}
