using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data
{
    public interface IDbDataAdapter : IDataAdapter
    {
        // Properties
        IDbCommand DeleteCommand { get; set; }
        IDbCommand InsertCommand { get; set; }
        IDbCommand SelectCommand { get; set; }
        IDbCommand UpdateCommand { get; set; }
    }
    public interface IDataAdapter
    {
        // Properties
        MissingMappingAction MissingMappingAction { get; set; }
        MissingSchemaAction MissingSchemaAction { get; set; }
        ITableMappingCollection TableMappings { get; }
        // Methods
        int Fill(DataSet dataSet);
        DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType);
        IDataParameter[] GetFillParameters();
        int Update(DataSet dataSet);
    }

}
