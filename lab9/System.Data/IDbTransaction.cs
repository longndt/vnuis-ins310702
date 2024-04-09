﻿using System;

namespace System.Data
{
    public interface IDbTransaction : IDisposable
    {
        // Properties
        IDbConnection Connection { get; }

        IsolationLevel IsolationLevel { get; }

        // Methods
        void Commit();
        void Rollback();
    }
}
