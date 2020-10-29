// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaseValidator.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved.   
// </copyright>
// <summary>
//   Defines the CaseValidator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Business.Validators
{
    using FluentValidation;

    using Core.Dtos;

    /// <inheritdoc />
    /// <summary>
    /// The person validator.
    /// </summary>
    public class CaseValidator : AbstractValidator<CaseDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseValidator"/> class.
        /// </summary>
        public CaseValidator()
        {
            this.RuleFor(x => x.CaseId).GreaterThan(0);
            this.RuleFor(x => x.ProcessId).GreaterThan(0);
            this.RuleFor(x => x.Description).NotNull().NotEmpty();
        }
    }
}
