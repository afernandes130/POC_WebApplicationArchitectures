// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationResultDto.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved. 
// </copyright>
// <summary>
//   The validation result DTO.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Core.Dtos
{
    using System.Collections.Generic;

    /// <summary>
    /// The validation result DTO.
    /// </summary>
    public class ValidationResultDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResultDto"/> class.
        /// </summary>
        /// <param name="failures">
        /// The failures.
        /// </param>
        public ValidationResultDto(IList<ValidationFailureDto> failures)
        {
            this.IsValid = false;
            this.Errors = failures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResultDto"/> class.
        /// </summary>
        /// <param name="failure">
        /// The failures.
        /// </param>
        public ValidationResultDto(ValidationFailureDto failure)
        {
            this.IsValid = false;
            this.Errors = new List<ValidationFailureDto> { failure };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResultDto"/> class.
        /// </summary>
        public ValidationResultDto()
        {
            this.IsValid = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether is valid.
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or sets the error details.
        /// </summary>
        public IList<ValidationFailureDto> Errors { get; set; }
    }
}
