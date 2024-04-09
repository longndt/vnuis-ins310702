using System;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

// Changed the namespace to avoid using system namespaces for custom implementations
namespace System.Common
{
    public abstract class DbProviderFactory
    {
        // Properties
        public virtual bool CanCreateDataSourceEnumerator { get; }

        // Constructors
        protected DbProviderFactory() { }

        // Methods  
        public abstract DbCommand CreateCommand();
        public abstract DbCommandBuilder CreateCommandBuilder();
        public abstract DbConnection CreateConnection();
        public abstract DbConnectionStringBuilder CreateConnectionStringBuilder();
        public abstract DbDataAdapter CreateDataAdapter();
        public abstract DbDataSourceEnumerator CreateDataSourceEnumerator();
        public abstract DbParameter CreateParameter();
    }
}
