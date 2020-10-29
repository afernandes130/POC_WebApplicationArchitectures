// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmailService.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved.
// </copyright>
// <summary>
//   The EmailSender interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Core.Services
{
    using System.Threading.Tasks;

    /// <summary>
    /// The EmailSender interface.
    /// </summary>
    public interface IEmailService
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
        public Task SendEmailAsync(string to, string subject, string message);
    }
}
