// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaseDto.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved.
// </copyright>
// <summary>
//   Defines the CaseDto type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


namespace Core.Dtos
{
    /// <summary>
    /// The case DTO.
    /// </summary>
    public class CaseDto
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

        /// <summary>
        /// Gets or sets the process name.
        /// </summary>
        public string ProcessName { get; set; }

        /// <summary>
        /// Gets or sets the process user id.
        /// </summary>
        public int ProcessUserId { get; set; }
    }
}
