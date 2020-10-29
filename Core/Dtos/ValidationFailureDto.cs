// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationFailureDto.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved. 
// </copyright>
// <summary>
//   The error details.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Core.Dtos
{
    /// <summary>
    /// The error details.
    /// </summary>
    public class ValidationFailureDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationFailureDto"/> class.
        /// </summary>
        public ValidationFailureDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationFailureDto"/> class.
        /// </summary>
        /// <param name="propertyName">
        /// The property name.
        /// </param>
        /// <param name="errorMessage">
        /// The error message.
        /// </param>
        /// <param name="errorCode">
        /// The error code.
        /// </param>
        public ValidationFailureDto(string propertyName, string errorMessage, string errorCode = "")
        {
            this.PropertyName = propertyName;
            this.ErrorMessage = errorMessage;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Gets or sets the property name.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        public string ErrorCode { get; set; }
    }
}
