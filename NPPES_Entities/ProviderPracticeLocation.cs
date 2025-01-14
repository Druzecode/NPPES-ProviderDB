namespace NPPES_Entities
{
    public class ProviderPracticeLocation:EntityBase
    {
        public string ProviderNPI { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string TelephoneExtension { get; set; }
        public string FaxNumber { get; set; }

        public static ProviderPracticeLocation? Load(string[] columns)
        {
            columns = RemoveQuotes(columns);

            ProviderPracticeLocation ppl = new ProviderPracticeLocation();
            ppl.ProviderNPI = columns[0];
            ppl.Address1 = columns[1];
            ppl.Address2 = columns[2];
            ppl.CityName = columns[3];
            ppl.StateName = columns[4];
            ppl.PostalCode = columns[5];
            ppl.CountryCode = columns[6];
            ppl.TelephoneNumber = columns[7];
            ppl.TelephoneExtension = columns[8];
            ppl.FaxNumber = columns[9];

            return ppl;
        }

        public override string InsertQuery(bool bulk = false)
        {
            string insert = bulk ? "," : "INSERT INTO provider_practice_location" +
                "(NPI, Address1, Address2, CityName, StateName, " +
                "PostalCode, CountryCode, TelephoneNumber, TelephoneExtension, FaxNumber) VALUES ";

            return insert +
                String.Format("('{0}','{1}','{2}','{3}','{4}'," +
                "'{5}','{6}','{7}','{8}','{9}')",
                ProviderNPI, Address1, Address2, CityName, StateName,
                PostalCode, CountryCode, TelephoneNumber, TelephoneExtension, FaxNumber);
        }
    }
}
