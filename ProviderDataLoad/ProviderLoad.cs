using Microsoft.VisualBasic.FileIO;
using MySql.Data.MySqlClient;
using NPPES_Entities;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Text;

namespace TestProviderData
{
    internal class ProviderLoad : DataLoadBase
    {
        private int taxonomy_total = 0;
        private int identifier_total = 0;

        public void Load()
        {
            //limit = 500000;
            List<Provider> providers = new List<Provider>();
            LoadDataFromFile("npidata_pfile_20050523-20241208.csv", "provider", 330,
                (line) => { providers.Add(Provider.Load(line)); },
                () => { PerformInsert(providers); providers.Clear(); }
            );
        }

        protected override void DoInsert<T>(MySqlConnection connection, List<T> records)
        {
            List<Provider>? providers = records as List<Provider>;
            InsertRecords(connection, providers, ref total);

            var taxonomies = providers.SelectMany(p => p.ProviderTaxonomies).ToList();
            InsertRecords(connection, taxonomies, ref taxonomy_total);

            var identifiers = providers.SelectMany(p => p.ProviderIdentifiers).ToList();
            InsertRecords(connection, identifiers, ref identifier_total);

        }
    }
}