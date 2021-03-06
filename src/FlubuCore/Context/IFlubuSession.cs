﻿using System;
using System.Diagnostics;
using FlubuCore.Scripting;
using FlubuCore.Targeting;

namespace FlubuCore.Context
{
    public interface IFlubuSession : ITaskContextInternal
    {
        bool InteractiveMode { get; set; }

        CommandArguments InteractiveArgs { get; set; }

        bool HasFailed { get; }

        bool? UnknownTarget { get; set; }

        Stopwatch BuildStopwatch { get; }

        void Start();

        void Complete();
    }
}
