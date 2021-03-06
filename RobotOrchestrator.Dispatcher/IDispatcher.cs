// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;

namespace RobotOrchestrator.Dispatcher
{
    public interface IDispatcher
    {
        Task SendJobAsync(Job job);
    }
}
