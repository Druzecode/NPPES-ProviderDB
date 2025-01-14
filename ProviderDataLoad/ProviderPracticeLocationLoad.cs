using MySql.Data.MySqlClient;
using NPPES_Entities;

namespace TestProviderData
{
    internal class ProviderPracticeLocationLoad : DataLoadBase
    {
        public void Load()
        {
            List<ProviderPracticeLocation> locations = new List<ProviderPracticeLocation>();
            LoadDataFromFile("pl_pfile_20050523-20241208.csv", "provider_practice_location", 10,
                (line) => { locations.Add(ProviderPracticeLocation.Load(line)); },
                () => { PerformInsert(locations); locations.Clear(); }
            );
        }

        protected override void DoInsert<T>(MySqlConnection connection, List<T> records)
        {
            List<ProviderPracticeLocation>? locations = records as List<ProviderPracticeLocation>;
            InsertRecords(connection, locations, ref total);
        }
    }
}
