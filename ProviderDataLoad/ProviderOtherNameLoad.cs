using MySql.Data.MySqlClient;
using NPPES_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProviderData
{
    internal class ProviderOtherNameLoad : DataLoadBase
    {
        public void Load()
        {
            List<ProviderOtherName> otherNames = new List<ProviderOtherName>();
            LoadDataFromFile("othername_pfile_20050523-20241208.csv", "provider_other_name", 3,
                (line) => { otherNames.Add(ProviderOtherName.Load(line)); },
                () => { PerformInsert(otherNames); otherNames.Clear(); }
            );
        }

        protected override void DoInsert<T>(MySqlConnection connection, List<T> records)
        {
            List<ProviderOtherName>? endpoints = records as List<ProviderOtherName>;
            InsertRecords(connection, endpoints, ref total);
        }
    }
}
