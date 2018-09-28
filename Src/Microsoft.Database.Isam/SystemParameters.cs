//-----------------------------------------------------------------------
// <copyright file="SystemParameters.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation.
// </copyright>
//-----------------------------------------------------------------------

// <remarks>
// Generated by params.pl
// </remarks>
namespace Microsoft.Database.Isam
{
    using System;
    using Microsoft.Isam.Esent.Interop;
    using Microsoft.Isam.Esent.Interop.Vista;

    /// <summary>
    /// Properties for per-instance system parameters
    /// </summary>
    public class IsamSystemParameters
    {
        /// <summary>
        /// The instance.
        /// </summary>
        private readonly IsamInstance instance;

        /// <summary>
        /// Initializes a new instance of the <see cref="IsamSystemParameters"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        internal IsamSystemParameters(IsamInstance instance)
        {
            this.instance = instance;
        }

        /// <summary>
        /// Gets or sets system parameter which is a string.
        /// </summary>
        public string SystemPath
        {
            get
            {
                int ignored = 0;
                string val;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.SystemPath, ref ignored, out val, 1024);
                return val;
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.SystemPath, 0, value);
            }
        }

        /// <summary>
        /// Gets or sets system parameter which is a string.
        /// </summary>
        public string TempPath
        {
            get
            {
                int ignored = 0;
                string val;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.TempPath, ref ignored, out val, 1024);
                return val;
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.TempPath, 0, value);
            }
        }

        /// <summary>
        /// Gets or sets system parameter which is a string.
        /// </summary>
        public string LogFilePath
        {
            get
            {
                int ignored = 0;
                string val;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.LogFilePath, ref ignored, out val, 1024);
                return val;
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.LogFilePath, 0, value);
            }
        }

        /// <summary>
        /// Gets or sets system parameter which is a string.
        /// </summary>
        public string BaseName
        {
            get
            {
                int ignored = 0;
                string val;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.BaseName, ref ignored, out val, 1024);
                return val;
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.BaseName, 0, value);
            }
        }

        /// <summary>
        /// Gets or sets system parameter which is a string.
        /// </summary>
        public string EventSource
        {
            get
            {
                int ignored = 0;
                string val;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EventSource, ref ignored, out val, 1024);
                return val;
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EventSource, 0, value);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int MaxSessions
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxSessions, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxSessions, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int MaxOpenTables
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxOpenTables, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxOpenTables, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int MaxCursors
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxCursors, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxCursors, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int MaxVerPages
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxVerPages, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxVerPages, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int MaxTemporaryTables
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxTemporaryTables, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxTemporaryTables, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int LogFileSize
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.LogFileSize, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.LogFileSize, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int LogBuffers
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.LogBuffers, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.LogBuffers, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the underlying system parameter is true.
        /// </summary>
        public bool CircularLog
        {
            get
            {
                int val = 0;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CircularLog, ref val, out ignored, 0);
                return 0 != val;
            }

            set
            {
                int val = value ? 1 : 0;
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CircularLog, val, null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int DbExtensionSize
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.DbExtensionSize, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.DbExtensionSize, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int PageTempDBMin
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.PageTempDBMin, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.PageTempDBMin, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int CacheSizeMax
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CacheSizeMax, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CacheSizeMax, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (long).
        /// </summary>
        public long CheckpointDepthMax
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CheckpointDepthMax, ref val, out ignored, 0);
                return unchecked((long)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CheckpointDepthMax, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets a system parameter which is an integer type (int).
        /// </summary>
        public int OutstandingIOMax
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.OutstandingIOMax, ref val, out ignored, 0);
                return unchecked((int)val);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int StartFlushThreshold
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.StartFlushThreshold, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.StartFlushThreshold, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int StopFlushThreshold
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.StopFlushThreshold, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.StopFlushThreshold, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets system parameter which is a string.
        /// </summary>
        public string Recovery
        {
            get
            {
                int ignored = 0;
                string val;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.Recovery, ref ignored, out val, 1024);
                return val;
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.Recovery, 0, value);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int EnableOnlineDefrag
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EnableOnlineDefrag, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EnableOnlineDefrag, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int CacheSize
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CacheSize, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CacheSize, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public bool EnableIndexChecking
        {
            get
            {
                int numericValue = 0;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EnableIndexChecking, ref numericValue, out ignored, 0);
                return Convert.ToBoolean(numericValue);
            }

            set
            {
                // int numericValue = value ? 1 : 0;
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EnableIndexChecking, Convert.ToInt32(value), null);
            }
        }

        /// <summary>
        /// Disables or enables all database engine callbacks to application provided functions.
        /// </summary>
        public bool DisableCallbacks
        {
            get
            {
                int numericValue = 0;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.DisableCallbacks, ref numericValue, out ignored, 0);
                return Convert.ToBoolean(numericValue);
            }
            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.DisableCallbacks, Convert.ToInt32(value), null);
            }
        }

        /// <summary>
        /// Gets or sets system parameter which is a string.
        /// </summary>
        public string EventSourceKey
        {
            get
            {
                int ignored = 0;
                string val;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EventSourceKey, ref ignored, out val, 1024);
                return val;
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EventSourceKey, 0, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the underlying system parameter is true.
        /// </summary>
        public bool NoInformationEvent
        {
            get
            {
                int val = 0;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.NoInformationEvent, ref val, out ignored, 0);
                return 0 != val;
            }

            set
            {
                int val = value ? 1 : 0;
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.NoInformationEvent, val, null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int EventLoggingLevel
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EventLoggingLevel, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EventLoggingLevel, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the underlying system parameter is true.
        /// </summary>
        public bool DeleteOutOfRangeLogs
        {
            get
            {
                int val = 0;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.DeleteOutOfRangeLogs, ref val, out ignored, 0);
                return 0 != val;
            }

            set
            {
                int val = value ? 1 : 0;
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.DeleteOutOfRangeLogs, val, null);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the underlying system parameter is true.
        /// </summary>
        public bool EnableIndexCleanup
        {
            get
            {
                int val = 0;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EnableIndexCleanup, ref val, out ignored, 0);
                return 0 != val;
            }

            set
            {
                int val = value ? 1 : 0;
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.EnableIndexCleanup, val, null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int CacheSizeMin
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CacheSizeMin, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CacheSizeMin, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int PreferredVerPages
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.PreferredVerPages, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.PreferredVerPages, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets a system parameter which is an integer type (int).
        /// </summary>
        public int DatabasePageSize
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.DatabasePageSize, ref val, out ignored, 0);
                return unchecked((int)val);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the underlying system parameter is true.
        /// </summary>
        public bool CleanupMismatchedLogFiles
        {
            get
            {
                int val = 0;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CleanupMismatchedLogFiles, ref val, out ignored, 0);
                return 0 != val;
            }

            set
            {
                int val = value ? 1 : 0;
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CleanupMismatchedLogFiles, val, null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int ExceptionAction
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.ExceptionAction, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.ExceptionAction, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the underlying system parameter is true.
        /// </summary>
        public bool CreatePathIfNotExist
        {
            get
            {
                int val = 0;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CreatePathIfNotExist, ref val, out ignored, 0);
                return 0 != val;
            }

            set
            {
                int val = value ? 1 : 0;
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.CreatePathIfNotExist, val, null);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the underlying system parameter is true.
        /// </summary>
        public bool OneDatabasePerSession
        {
            get
            {
                int val = 0;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.OneDatabasePerSession, ref val, out ignored, 0);
                return 0 != val;
            }

            set
            {
                int val = value ? 1 : 0;
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.OneDatabasePerSession, val, null);
            }
        }

        /// <summary>
        /// Gets a system parameter which is an integer type (int).
        /// </summary>
        public int MaxInstances
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.MaxInstances, ref val, out ignored, 0);
                return unchecked((int)val);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int VersionStoreTaskQueueMax
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.VersionStoreTaskQueueMax, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, JET_param.VersionStoreTaskQueueMax, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets or sets a system parameter which is an integer type (int).
        /// </summary>
        public int Configuration
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, VistaParam.Configuration, ref val, out ignored, 0);
                return unchecked((int)val);
            }

            set
            {
                Api.JetSetSystemParameter(this.instance.Inst, JET_SESID.Nil, VistaParam.Configuration, new IntPtr(value), null);
            }
        }

        /// <summary>
        /// Gets a system parameter which is an integer type (long).
        /// </summary>
        public long KeyMost
        {
            get
            {
                IntPtr val = IntPtr.Zero;
                string ignored;
                Api.JetGetSystemParameter(this.instance.Inst, JET_SESID.Nil, VistaParam.KeyMost, ref val, out ignored, 0);
                return unchecked((long)val);
            }
        }
    }
}
