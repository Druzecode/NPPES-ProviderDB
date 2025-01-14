using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace NPPES_Entities
{
    public class ProviderEndpoint:EntityBase
    {
        public string ProviderNPI { get; set; }
        public string EndpointType { get; set; }
        public string EndpointTypeDescription { get; set; }
        public string Endpoint { get; set; }
        public string Affiliation { get; set; }
        public string EndpointDescription { get; set; }
        public string AffiliationLegalBusinessName { get; set; }
        public string UseCode { get; set; }
        public string UseDescription { get; set; }
        public string UseOtherDecription { get; set; }
        public string ContentType { get; set; }
        public string ContentDescription { get; set; }
        public string OtherContentDescription { get; set; }
        public string AffiliationAddressLineOne { get; set; }
        public string AffiliationAddressLineTwo { get; set; }
        public string AffiliationAddressCity { get; set; }
        public string AffiliationAddressState { get; set; }
        public string AffiliationAddressCountry { get; set; }
        public string AffiliationAddressLinePostalCode { get; set; }

        public static ProviderEndpoint? Load(string[] columns)
        {
            columns = RemoveQuotes(columns);

            ProviderEndpoint pe = new ProviderEndpoint();
            pe.ProviderNPI = columns[0];
            pe.EndpointType = columns[1];
            pe.EndpointTypeDescription = columns[2];
            pe.Endpoint = columns[3];
            pe.Affiliation = columns[4];
            pe.EndpointDescription = columns[5];
            pe.AffiliationLegalBusinessName = columns[6];
            pe.UseCode = columns[7];
            pe.UseDescription = columns[8];
            pe.UseOtherDecription = columns[9];
            pe.ContentType = columns[10];
            pe.ContentDescription = columns[11];
            pe.OtherContentDescription = columns[12];
            pe.AffiliationAddressLineOne = columns[13];
            pe.AffiliationAddressLineTwo = columns[14];
            pe.AffiliationAddressCity = columns[15];
            pe.AffiliationAddressState = columns[16];
            pe.AffiliationAddressCountry = columns[17];
            pe.AffiliationAddressLinePostalCode = columns[18];

            return pe;
        }

        public override string InsertQuery(bool bulk = false)
        {
            string insert = bulk ? "," : "INSERT INTO provider_endpoint" +
                "(NPI, EndpointType, EndpointTypeDescription, Endpoint, Affiliation, " +
                "EndpointDescription, AffiliationLegalBusinessName, UseCode, UseDescription, UseOtherDecription, " +
                "ContentType, ContentDescription, OtherContentDescription, AffiliationAddressLineOne, AffiliationAddressLineTwo, " +
                "AffiliationAddressCity, AffiliationAddressState, AffiliationAddressCountry, AffiliationAddressLinePostalCode) VALUES ";

            return insert +
                String.Format("('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'," +
                "'{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}')",
                ProviderNPI, EndpointType, EndpointTypeDescription, Endpoint, Affiliation,
                EndpointDescription, AffiliationLegalBusinessName, UseCode, UseDescription, UseOtherDecription,
                ContentType, ContentDescription, OtherContentDescription, AffiliationAddressLineOne, AffiliationAddressLineTwo,
                AffiliationAddressCity, AffiliationAddressState, AffiliationAddressCountry, AffiliationAddressLinePostalCode);
        }
    }
}
