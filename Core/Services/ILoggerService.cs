// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILoggerService.cs" company="Orbium">
// Copyright (c) Orbium. All rights reserved.
// </copyright>
// <summary>
//   The Logger interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Orbium.Core.Services
{
    /// <summary>
    /// The Logger interface.
    /// </summary>
    public interface ILoggerService
    {
        /// <summary>
        /// The log debug.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        void LogDebug(string message);

        /// <summary>
        /// The log error.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        void LogError(string message);

        /// <summary>
        /// The log info.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        void LogInfo(string message);

        /// <summary>
        /// The log warn.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        void LogWarn(string message);
    }
}