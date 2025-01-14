using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPPES_Entities
{
    public abstract class EntityBase
    {
        protected static string[] RemoveQuotes(string[] columns)
        {
            for (int i = 0; i < columns.Length; i++)
                columns[i] = columns[i].Replace("'", "''");
            return columns;
        }

        public abstract string InsertQuery(bool bulk = false);
    }
}
