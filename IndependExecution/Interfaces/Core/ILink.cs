﻿namespace IndependExecution.Interfaces.Core
{
    public interface ILink
    {
        INode Source { get; }
        INode Target { get; }
    }
}
