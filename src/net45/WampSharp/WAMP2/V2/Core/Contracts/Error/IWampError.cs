﻿using WampSharp.Core.Contracts;
using WampSharp.Core.Message;

namespace WampSharp.V2.Core.Contracts
{
    /// <summary>
    /// Handles generic client errors, or sends server proxy errors.
    /// </summary>
    /// <remarks>These messages are part of the WAMP2 specification.</remarks>
    /// <typeparam name="TMessage"></typeparam>
    public interface IWampError<TMessage>
    {
        /// <summary>
        /// Occurs when a generic request error arrives.
        /// </summary>
        /// <param name="requestType">The request's type.</param>
        /// <param name="requestId">The request id.</param>
        /// <param name="details">The request details.</param>
        /// <param name="error">The error uri.</param>
        [WampHandler(WampMessageType.v2Error)]
        void Error(int requestType, long requestId, TMessage details, string error);

        /// <summary>
        /// Occurs when a generic request error arrives.
        /// </summary>
        /// <param name="requestType">The request's type.</param>
        /// <param name="requestId">The request id.</param>
        /// <param name="details">The request details.</param>
        /// <param name="error">The error uri.</param>
        /// <param name="arguments">The error arguments.</param>
        [WampHandler(WampMessageType.v2Error)]
        void Error(int requestType, long requestId, TMessage details, string error, TMessage[] arguments);

        /// <summary>
        /// Occurs when a generic request error arrives.
        /// </summary>
        /// <param name="requestType">The request's type.</param>
        /// <param name="requestId">The request id.</param>
        /// <param name="details">The request details.</param>
        /// <param name="error">The error uri.</param>
        /// <param name="arguments">The error arguments.</param>
        /// <param name="argumentsKeywords">The error arguments keywords.</param>
        [WampHandler(WampMessageType.v2Error)]
        void Error(int requestType, long requestId, TMessage details, string error, TMessage[] arguments, TMessage argumentsKeywords);
    }
}