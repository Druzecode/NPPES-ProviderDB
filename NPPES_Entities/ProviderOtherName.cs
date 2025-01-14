namespace NPPES_Entities
{
    public class ProviderOtherName : EntityBase
    {
        public string ProviderNPI { get; set; }
        public string OtherOrganizationName { get; set; }
        public string OtherOrganizationTypeCode { get; set; }

        public static ProviderOtherName? Load(string[] columns)
        {
            columns = RemoveQuotes(columns);

            ProviderOtherName pon = new ProviderOtherName();
            pon.ProviderNPI = columns[0];
            pon.OtherOrganizationName = columns[1];
            pon.OtherOrganizationTypeCode = columns[2];
            
            return pon;
        }

        public override string InsertQuery(bool bulk = false)
        {
            string insert = bulk ? "," : "INSERT INTO provider_other_name" +
                "(NPI, ProviderOtherOrganizationName, ProviderOtherOrganizationNameTypeCode) VALUES ";

            return insert +
                String.Format("('{0}','{1}','{2}')",
                ProviderNPI, OtherOrganizationName, OtherOrganizationTypeCode);
        }
    }
}
