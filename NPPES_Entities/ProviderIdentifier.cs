using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPPES_Entities
{
    public class ProviderIdentifier : EntityBase
    {
        public string ProviderNPI { get; set; }
        public string OtherProviderIdentifier { get; set; }
        public string OtherProviderIdentifierTypeCode { get; set; }
        public string OtherProviderIdentifierState { get; set; }
        public string OtherProviderIdentifierIssuer { get; set; }

        public static ProviderIdentifier? Load(string NPI, string id, string typeCode, string state, string issuer)
        {
            if (String.IsNullOrWhiteSpace(id) &&
                String.IsNullOrWhiteSpace(typeCode) &&
                String.IsNullOrWhiteSpace(state) &&
                String.IsNullOrWhiteSpace(issuer))
                return null;

            ProviderIdentifier pi = new ProviderIdentifier();
            pi.ProviderNPI = NPI;
            pi.OtherProviderIdentifier = id;
            pi.OtherProviderIdentifierTypeCode = typeCode;
            pi.OtherProviderIdentifierState = state;
            pi.OtherProviderIdentifierIssuer = issuer;

            return pi;
        }

        public override string InsertQuery(bool bulk = false)
        {
            string insert = bulk ? "," : "INSERT INTO provider_identifier" +
                "(NPI, OtherIdentifier, IdentifierTypeCode, IdentifierState, IdentifierIssuer) VALUES ";

            return insert +
                String.Format("('{0}','{1}','{2}','{3}','{4}')",
                ProviderNPI, OtherProviderIdentifier, OtherProviderIdentifierTypeCode, OtherProviderIdentifierState, OtherProviderIdentifierIssuer);
        }
    }
}
