using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPPES_Entities
{
    public class ProviderTaxonomy : EntityBase
    {
        public string ProviderNPI { get; set; }
        public string HealthcareProviderTaxonomyCode { get; set; }
        public string ProviderLicenseNumber { get; set; }
        public string ProviderLicenseNumberStateCode { get; set; }
        public string HealthcareProviderPrimaryTaxonomySwitch { get; set; }

        public static ProviderTaxonomy? Load(string NPI, string code, string number, string stateCode, string primary)
        {
            if (String.IsNullOrWhiteSpace(code) &&
                String.IsNullOrWhiteSpace(number) &&
                String.IsNullOrWhiteSpace(stateCode) &&
                String.IsNullOrWhiteSpace(primary))
                return null;

            ProviderTaxonomy pt = new ProviderTaxonomy();
            pt.ProviderNPI = NPI;
            pt.HealthcareProviderTaxonomyCode = code;
            pt.ProviderLicenseNumber = number;
            pt.ProviderLicenseNumberStateCode = stateCode;
            pt.HealthcareProviderPrimaryTaxonomySwitch = primary;

            return pt;
        }

        public override string InsertQuery(bool bulk = false)
        {
            string insert = bulk ? "," : "INSERT INTO provider_taxonomy" +
                "(NPI, TaxonomyCode, LicenseNumber, LicenseNumberStateCode, PrimaryTaxonomy) VALUES ";

            return insert +
                String.Format("('{0}','{1}','{2}','{3}','{4}')",
                ProviderNPI, HealthcareProviderTaxonomyCode, ProviderLicenseNumber, ProviderLicenseNumberStateCode, HealthcareProviderPrimaryTaxonomySwitch);
        }
    }
}
