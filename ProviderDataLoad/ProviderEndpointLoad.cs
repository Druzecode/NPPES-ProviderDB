using MySql.Data.MySqlClient;
using NPPES_Entities;

namespace TestProviderData
{
    internal class ProviderEndpointLoad : DataLoadBase
    {
        public void Load()
        {
            List<ProviderEndpoint> endpoints = new List<ProviderEndpoint>();
            LoadDataFromFile("endpoint_pfile_20050523-20241208.csv", "provider_endpoint", 19,
                (line) => { endpoints.Add(ProviderEndpoint.Load(line)); },
                () => { PerformInsert(endpoints); endpoints.Clear(); }
            );
        }

        protected override void DoInsert<T>(MySqlConnection connection, List<T> records)
        {
            List<ProviderEndpoint>? endpoints = records as List<ProviderEndpoint>;
            InsertRecords(connection, endpoints, ref total);
        }
    }
}
