using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data
{
    public interface IDbDataParameter : IDataParameter
    {
        // Properties
        byte Precision { get; set; }
        byte Scale { get; set; }
        int Size { get; set; }
    }

    public interface IDataParameter
    {
        // Properties
        DbType DbType { get; set; }
        ParameterDirection Direction { get; set; }
        bool IsNullable { get; }
        string ParameterName { get; set; }
        string SourceColumn { get; set; }
        DataRowVersion SourceVersion { get; set; }
        object Value { get; set; }
    }

}
