// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailService.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved.
// </copyright>
// <summary>
//   The email sender.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Infrastructure.Services
{
    using System.Threading.Tasks;

    using Core.Services;

    /// <summary>
    /// The email sender.
    /// </summary>
    public class EmailService : IEmailService
    {
        /// <summary>
        /// The send email async.
        /// </summary>
        /// <param name="to">
        /// The to.
        /// </param>
        /// <param name="subject">
        /// The subject.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task SendEmailAsync(string to, string subject, string message)
        {
            // TODO Email Process
            return Task.CompletedTask;
        }
    }
}
