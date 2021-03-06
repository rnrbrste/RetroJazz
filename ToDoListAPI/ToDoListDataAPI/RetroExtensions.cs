﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using RetroAPI;
using RetroAPI.Models;

namespace RetroAPI
{
    public static partial class RetroExtensions
    {
        /// <param name='operations'>
        /// Reference to the RetroAPI.IRetro.
        /// </param>
        /// <param name='owner'>
        /// Required.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static object DeleteByOwnerAndId(this IRetro operations, string owner, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRetro)s).DeleteByOwnerAndIdAsync(owner, id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the RetroAPI.IRetro.
        /// </param>
        /// <param name='owner'>
        /// Required.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> DeleteByOwnerAndIdAsync(this IRetro operations, string owner, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.DeleteByOwnerAndIdWithOperationResponseAsync(owner, id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the RetroAPI.IRetro.
        /// </param>
        /// <param name='owner'>
        /// Required.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static ToDoItem GetByIdByOwnerAndId(this IRetro operations, string owner, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRetro)s).GetByIdByOwnerAndIdAsync(owner, id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the RetroAPI.IRetro.
        /// </param>
        /// <param name='owner'>
        /// Required.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<ToDoItem> GetByIdByOwnerAndIdAsync(this IRetro operations, string owner, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<RetroAPI.Models.ToDoItem> result = await operations.GetByIdByOwnerAndIdWithOperationResponseAsync(owner, id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the RetroAPI.IRetro.
        /// </param>
        /// <param name='owner'>
        /// Required.
        /// </param>
        public static IList<ToDoItem> GetByOwner(this IRetro operations, string owner)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRetro)s).GetByOwnerAsync(owner);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the RetroAPI.IRetro.
        /// </param>
        /// <param name='owner'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<ToDoItem>> GetByOwnerAsync(this IRetro operations, string owner, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<RetroAPI.Models.ToDoItem>> result = await operations.GetByOwnerWithOperationResponseAsync(owner, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the RetroAPI.IRetro.
        /// </param>
        /// <param name='todo'>
        /// Required.
        /// </param>
        public static object PostByTodo(this IRetro operations, ToDoItem todo)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRetro)s).PostByTodoAsync(todo);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the RetroAPI.IRetro.
        /// </param>
        /// <param name='todo'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PostByTodoAsync(this IRetro operations, ToDoItem todo, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PostByTodoWithOperationResponseAsync(todo, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the RetroAPI.IRetro.
        /// </param>
        /// <param name='todo'>
        /// Required.
        /// </param>
        public static object PutByTodo(this IRetro operations, ToDoItem todo)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRetro)s).PutByTodoAsync(todo);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the RetroAPI.IRetro.
        /// </param>
        /// <param name='todo'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutByTodoAsync(this IRetro operations, ToDoItem todo, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutByTodoWithOperationResponseAsync(todo, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
