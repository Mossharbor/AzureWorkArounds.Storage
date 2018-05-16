using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mosshaarbor.AzureWorkArounds.Storage
{
    public static class TableExtensions
    {
#if NETSTANDARD2_0
        public static TableResult Execute(this CloudTable table, TableOperation op)
        {
            return table.ExecuteAsync(op).Result;
        }

#endif
    }
}
