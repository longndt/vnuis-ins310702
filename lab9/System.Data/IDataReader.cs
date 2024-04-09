using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data
{
    public interface IDataReader : IDisposable, IDataRecord
    {
        int Depth { get; }
        bool IsClosed { get; }
        int RecordsAffected { get; }

        void Close();
        DataTable GetSchemaTable();
        bool NextResult();
        bool Read();
    }
}
