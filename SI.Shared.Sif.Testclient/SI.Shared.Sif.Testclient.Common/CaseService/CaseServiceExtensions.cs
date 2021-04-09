﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SI.Shared.Sif.Testclient.Common
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for CaseService.
    /// </summary>
    public static partial class CaseServiceExtensions
    {
            /// <summary>
            /// 
            /// Just a ping method
            /// 
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pingArgs'>
            /// (See model for parameter info)
            /// </param>
            public static void Ping(this ICaseService operations, object pingArgs = default(object))
            {
                Task.Factory.StartNew(s => ((ICaseService)s).PingAsync(pingArgs), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// 
            /// Just a ping method
            /// 
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pingArgs'>
            /// (See model for parameter info)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PingAsync(this ICaseService operations, object pingArgs = default(object), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PingWithHttpMessagesAsync(pingArgs, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// 
            /// Create a case
            /// 
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='createCaseArgs'>
            /// (See model for parameter info)
            /// </param>
            public static CreateCaseOKResponse CreateCase(this ICaseService operations, CreateCaseArgs createCaseArgs = default(CreateCaseArgs))
            {
                return Task.Factory.StartNew(s => ((ICaseService)s).CreateCaseAsync(createCaseArgs), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// 
            /// Create a case
            /// 
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='createCaseArgs'>
            /// (See model for parameter info)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CreateCaseOKResponse> CreateCaseAsync(this ICaseService operations, CreateCaseArgs createCaseArgs = default(CreateCaseArgs), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateCaseWithHttpMessagesAsync(createCaseArgs, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// 
            /// Retrieves a list of all cases fulfilling the criteria of all the
            /// nonblank properties of the supplied parameter.
            /// 
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='getCasesArgs'>
            /// (See model for parameter info)
            /// </param>
            public static GetCasesOKResponse GetCases(this ICaseService operations, GetCasesArgs getCasesArgs = default(GetCasesArgs))
            {
                return Task.Factory.StartNew(s => ((ICaseService)s).GetCasesAsync(getCasesArgs), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// 
            /// Retrieves a list of all cases fulfilling the criteria of all the
            /// nonblank properties of the supplied parameter.
            /// 
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='getCasesArgs'>
            /// (See model for parameter info)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetCasesOKResponse> GetCasesAsync(this ICaseService operations, GetCasesArgs getCasesArgs = default(GetCasesArgs), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCasesWithHttpMessagesAsync(getCasesArgs, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// 
            /// Updates a case in 360. If the case has a closed status this
            /// operation can only be done by an archivist.
            /// If a property is set to null, meaning not provided in the
            /// parameter passed to the method, the property is not updated.To clear the
            /// field in 360° the property has to be explicitly set to “”. Only works for
            /// string properties. Archive codes supplied to this method is ignored and
            /// no changes to an archive code is possible once the case is created.
            /// 
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='updateCaseArgs'>
            /// (See model for parameter info)
            /// </param>
            public static UpdateCaseOKResponse UpdateCase(this ICaseService operations, UpdateCaseArgs updateCaseArgs = default(UpdateCaseArgs))
            {
                return Task.Factory.StartNew(s => ((ICaseService)s).UpdateCaseAsync(updateCaseArgs), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// 
            /// Updates a case in 360. If the case has a closed status this
            /// operation can only be done by an archivist.
            /// If a property is set to null, meaning not provided in the
            /// parameter passed to the method, the property is not updated.To clear the
            /// field in 360° the property has to be explicitly set to “”. Only works for
            /// string properties. Archive codes supplied to this method is ignored and
            /// no changes to an archive code is possible once the case is created.
            /// 
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='updateCaseArgs'>
            /// (See model for parameter info)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UpdateCaseOKResponse> UpdateCaseAsync(this ICaseService operations, UpdateCaseArgs updateCaseArgs = default(UpdateCaseArgs), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateCaseWithHttpMessagesAsync(updateCaseArgs, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}