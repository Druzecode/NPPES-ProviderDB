namespace NPPES_Entities
{
    public class Provider : EntityBase
    {
        public string NPI { get; set; }
        public string EntityTypeCode { get; set; }
        public string ReplacementNPI { get; set; }
        public string EmployerIdentificationNumberEIN { get; set; }
        public string ProviderOrganizationNameLegalBusinessName { get; set; }
        public string ProviderLastNameLegalName { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string ProviderNamePrefixText { get; set; }
        public string ProviderNameSuffixText { get; set; }
        public string ProviderCredentialText { get; set; }
        public string ProviderOtherOrganizationName { get; set; }
        public string ProviderOtherOrganizationNameTypeCode { get; set; }
        public string ProviderOtherLastName { get; set; }
        public string ProviderOtherFirstName { get; set; }
        public string ProviderOtherMiddleName { get; set; }
        public string ProviderOtherNamePrefixText { get; set; }
        public string ProviderOtherNameSuffixText { get; set; }
        public string ProviderOtherCredentialText { get; set; }
        public string ProviderOtherLastNameTypeCode { get; set; }
        public string ProviderFirstLineBusinessMailingAddress { get; set; }
        public string ProviderSecondLineBusinessMailingAddress { get; set; }
        public string ProviderBusinessMailingAddressCityName { get; set; }
        public string ProviderBusinessMailingAddressStateName { get; set; }
        public string ProviderBusinessMailingAddressPostalCode { get; set; }
        public string ProviderBusinessMailingAddressCountryCodeIfoutsideUS { get; set; }
        public string ProviderBusinessMailingAddressTelephoneNumber { get; set; }
        public string ProviderBusinessMailingAddressFaxNumber { get; set; }
        public string ProviderFirstLineBusinessPracticeLocationAddress { get; set; }
        public string ProviderSecondLineBusinessPracticeLocationAddress { get; set; }
        public string ProviderBusinessPracticeLocationAddressCityName { get; set; }
        public string ProviderBusinessPracticeLocationAddressStateName { get; set; }
        public string ProviderBusinessPracticeLocationAddressPostalCode { get; set; }
        public string ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS { get; set; }
        public string ProviderBusinessPracticeLocationAddressTelephoneNumber { get; set; }
        public string ProviderBusinessPracticeLocationAddressFaxNumber { get; set; }
        public string ProviderEnumerationDate { get; set; }
        public string LastUpdateDate { get; set; }
        public string NPIDeactivationReasonCode { get; set; }
        public string NPIDeactivationDate { get; set; }
        public string NPIReactivationDate { get; set; }
        public string ProviderGenderCode { get; set; }
        public string AuthorizedOfficialLastName { get; set; }
        public string AuthorizedOfficialFirstName { get; set; }
        public string AuthorizedOfficialMiddleName { get; set; }
        public string AuthorizedOfficialTitleorPosition { get; set; }
        public string AuthorizedOfficialTelephoneNumber { get; set; }
        public string IsSoleProprietor { get; set; }
        public string IsOrganizationSubpart { get; set; }
        public string ParentOrganizationLBN { get; set; }
        public string ParentOrganizationTIN { get; set; }
        public string AuthorizedOfficialNamePrefixText { get; set; }
        public string AuthorizedOfficialNameSuffixText { get; set; }
        public string AuthorizedOfficialCredentialText { get; set; }
        public string HealthcareProviderTaxonomyGroup_1 { get; set; }
        public string HealthcareProviderTaxonomyGroup_2 { get; set; }
        public string HealthcareProviderTaxonomyGroup_3 { get; set; }
        public string HealthcareProviderTaxonomyGroup_4 { get; set; }
        public string HealthcareProviderTaxonomyGroup_5 { get; set; }
        public string HealthcareProviderTaxonomyGroup_6 { get; set; }
        public string HealthcareProviderTaxonomyGroup_7 { get; set; }
        public string HealthcareProviderTaxonomyGroup_8 { get; set; }
        public string HealthcareProviderTaxonomyGroup_9 { get; set; }
        public string HealthcareProviderTaxonomyGroup_10 { get; set; }
        public string HealthcareProviderTaxonomyGroup_11 { get; set; }
        public string HealthcareProviderTaxonomyGroup_12 { get; set; }
        public string HealthcareProviderTaxonomyGroup_13 { get; set; }
        public string HealthcareProviderTaxonomyGroup_14 { get; set; }
        public string HealthcareProviderTaxonomyGroup_15 { get; set; }
        public string CertificationDate { get; set; }

        public List<ProviderTaxonomy> ProviderTaxonomies { get; set; } = new List<ProviderTaxonomy>();
        public List<ProviderIdentifier> ProviderIdentifiers { get; set; } = new List<ProviderIdentifier>();

        public static Provider Load(string[] columns)
        {
            columns = RemoveQuotes(columns);

            var provider = new Provider();
            provider.NPI = columns[0];
            provider.EntityTypeCode = columns[1];
            provider.ReplacementNPI = columns[2];
            provider.EmployerIdentificationNumberEIN = columns[3];
            provider.ProviderOrganizationNameLegalBusinessName = columns[4];
            provider.ProviderLastNameLegalName = columns[5];
            provider.ProviderFirstName = columns[6];
            provider.ProviderMiddleName = columns[7];
            provider.ProviderNamePrefixText = columns[8];
            provider.ProviderNameSuffixText = columns[9];
            provider.ProviderCredentialText = columns[10];
            provider.ProviderOtherOrganizationName = columns[11];
            provider.ProviderOtherOrganizationNameTypeCode = columns[12];
            provider.ProviderOtherLastName = columns[13];
            provider.ProviderOtherFirstName = columns[14];
            provider.ProviderOtherMiddleName = columns[15];
            provider.ProviderOtherNamePrefixText = columns[16];
            provider.ProviderOtherNameSuffixText = columns[17];
            provider.ProviderOtherCredentialText = columns[18];
            provider.ProviderOtherLastNameTypeCode = columns[19];
            provider.ProviderFirstLineBusinessMailingAddress = columns[20];
            provider.ProviderSecondLineBusinessMailingAddress = columns[21];
            provider.ProviderBusinessMailingAddressCityName = columns[22];
            provider.ProviderBusinessMailingAddressStateName = columns[23];
            provider.ProviderBusinessMailingAddressPostalCode = columns[24];
            provider.ProviderBusinessMailingAddressCountryCodeIfoutsideUS = columns[25];
            provider.ProviderBusinessMailingAddressTelephoneNumber = columns[26];
            provider.ProviderBusinessMailingAddressFaxNumber = columns[27];
            provider.ProviderFirstLineBusinessPracticeLocationAddress = columns[28];
            provider.ProviderSecondLineBusinessPracticeLocationAddress = columns[29];
            provider.ProviderBusinessPracticeLocationAddressCityName = columns[30];
            provider.ProviderBusinessPracticeLocationAddressStateName = columns[31];
            provider.ProviderBusinessPracticeLocationAddressPostalCode = columns[32];
            provider.ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS = columns[33];
            provider.ProviderBusinessPracticeLocationAddressTelephoneNumber = columns[34];
            provider.ProviderBusinessPracticeLocationAddressFaxNumber = columns[35];
            provider.ProviderEnumerationDate = columns[36];
            provider.LastUpdateDate = columns[37];
            provider.NPIDeactivationReasonCode = columns[38];
            provider.NPIDeactivationDate = columns[39];
            provider.NPIReactivationDate = columns[40];
            provider.ProviderGenderCode = columns[41];
            provider.AuthorizedOfficialLastName = columns[42];
            provider.AuthorizedOfficialFirstName = columns[43];
            provider.AuthorizedOfficialMiddleName = columns[44];
            provider.AuthorizedOfficialTitleorPosition = columns[45];
            provider.AuthorizedOfficialTelephoneNumber = columns[46];

            for(int i = 0; i < 15; i++)
            {
                var pt = ProviderTaxonomy.Load(provider.NPI, columns[47 + (i * 4)], columns[48 + (i * 4)], columns[49 + (i * 4)], columns[50 + (i * 4)]);
                if (pt != null)
                    provider.ProviderTaxonomies.Add(pt);
            }

            for (int i = 0; i < 50; i++)
            {
                var pi = ProviderIdentifier.Load(provider.NPI, columns[107 + (i * 4)], columns[108 + (i * 4)], columns[109 + (i * 4)], columns[110 + (i * 4)]);
                if (pi != null)
                    provider.ProviderIdentifiers.Add(pi);
            }

            provider.IsSoleProprietor = columns[307];
            provider.IsOrganizationSubpart = columns[308];
            provider.ParentOrganizationLBN = columns[309];
            provider.ParentOrganizationTIN = columns[310];
            provider.AuthorizedOfficialNamePrefixText = columns[311];
            provider.AuthorizedOfficialNameSuffixText = columns[312];
            provider.AuthorizedOfficialCredentialText = columns[313];
            provider.HealthcareProviderTaxonomyGroup_1 = columns[314];
            provider.HealthcareProviderTaxonomyGroup_2 = columns[315];
            provider.HealthcareProviderTaxonomyGroup_3 = columns[316];
            provider.HealthcareProviderTaxonomyGroup_4 = columns[317];
            provider.HealthcareProviderTaxonomyGroup_5 = columns[318];
            provider.HealthcareProviderTaxonomyGroup_6 = columns[319];
            provider.HealthcareProviderTaxonomyGroup_7 = columns[320];
            provider.HealthcareProviderTaxonomyGroup_8 = columns[321];
            provider.HealthcareProviderTaxonomyGroup_9 = columns[322];
            provider.HealthcareProviderTaxonomyGroup_10 = columns[323];
            provider.HealthcareProviderTaxonomyGroup_11 = columns[324];
            provider.HealthcareProviderTaxonomyGroup_12 = columns[325];
            provider.HealthcareProviderTaxonomyGroup_13 = columns[326];
            provider.HealthcareProviderTaxonomyGroup_14 = columns[327];
            provider.HealthcareProviderTaxonomyGroup_15 = columns[328];
            provider.CertificationDate = columns[329];


            return provider;
        }

        public override string InsertQuery(bool bulk = false)
        {
            string insert = bulk ? "," : "INSERT INTO provider" +
                "(NPI, EntityTypeCode, ReplacementNPI, EmployerIdentificationNumberEIN, ProviderOrganizationNameLegalBusinessName," +
                "ProviderLastNameLegalName, ProviderFirstName, ProviderMiddleName, ProviderNamePrefixText, ProviderNameSuffixText," +
                "ProviderCredentialText, ProviderOtherOrganizationName, ProviderOtherOrganizationNameTypeCode, ProviderOtherLastName, ProviderOtherFirstName," +
                "ProviderOtherMiddleName, ProviderOtherNamePrefixText, ProviderOtherNameSuffixText, ProviderOtherCredentialText, ProviderOtherLastNameTypeCode," +
                "ProviderFirstLineBusinessMailingAddress, ProviderSecondLineBusinessMailingAddress, ProviderBusinessMailingAddressCityName, ProviderBusinessMailingAddressStateName, ProviderBusinessMailingAddressPostalCode," +
                "ProviderBusinessMailingAddressCountryCodeIfoutsideUS, ProviderBusinessMailingAddressTelephoneNumber, ProviderBusinessMailingAddressFaxNumber, ProviderFirstLineBusinessPracticeLocationAddress, ProviderSecondLineBusinessPracticeLocationAddress," +
                "ProviderBusinessPracticeLocationAddressCityName, ProviderBusinessPracticeLocationAddressStateName, ProviderBusinessPracticeLocationAddressPostalCode, ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS, ProviderBusinessPracticeLocationAddressTelephoneNumber," +
                "ProviderBusinessPracticeLocationAddressFaxNumber, ProviderEnumerationDate, LastUpdateDate, NPIDeactivationReasonCode, NPIDeactivationDate," +
                "NPIReactivationDate, ProviderGenderCode, AuthorizedOfficialLastName, AuthorizedOfficialFirstName, AuthorizedOfficialMiddleName," +
                "AuthorizedOfficialTitleorPosition, AuthorizedOfficialTelephoneNumber, IsSoleProprietor, IsOrganizationSubpart, ParentOrganizationLBN," +
                "ParentOrganizationTIN, AuthorizedOfficialNamePrefixText, AuthorizedOfficialNameSuffixText, AuthorizedOfficialCredentialText, CertificationDate," +
                "HealthcareProviderTaxonomyGroup_1, HealthcareProviderTaxonomyGroup_2, HealthcareProviderTaxonomyGroup_3, HealthcareProviderTaxonomyGroup_4, HealthcareProviderTaxonomyGroup_5," +
                "HealthcareProviderTaxonomyGroup_6, HealthcareProviderTaxonomyGroup_7, HealthcareProviderTaxonomyGroup_8, HealthcareProviderTaxonomyGroup_9, HealthcareProviderTaxonomyGroup_10," +
                "HealthcareProviderTaxonomyGroup_11, HealthcareProviderTaxonomyGroup_12, HealthcareProviderTaxonomyGroup_13, HealthcareProviderTaxonomyGroup_14, HealthcareProviderTaxonomyGroup_15) VALUES ";

            return insert + 
                String.Format("(" +
                "'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'," +
                "'{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}'," +
                "'{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}'," +
                "'{30}','{31}','{32}','{33}','{34}','{35}','{36}','{37}','{38}','{39}'," +
                "'{40}','{41}','{42}','{43}','{44}','{45}','{46}','{47}','{48}','{49}'," +
                "'{50}','{51}','{52}','{53}','{54}','{55}','{56}','{57}','{58}','{59}'," +
                "'{60}','{61}','{62}','{63}','{64}','{65}','{66}','{67}','{68}','{69}')",
                NPI, EntityTypeCode, ReplacementNPI, EmployerIdentificationNumberEIN, ProviderOrganizationNameLegalBusinessName,
                ProviderLastNameLegalName, ProviderFirstName, ProviderMiddleName, ProviderNamePrefixText, ProviderNameSuffixText,
                ProviderCredentialText, ProviderOtherOrganizationName, ProviderOtherOrganizationNameTypeCode, ProviderOtherLastName, ProviderOtherFirstName,
                ProviderOtherMiddleName, ProviderOtherNamePrefixText, ProviderOtherNameSuffixText, ProviderOtherCredentialText, ProviderOtherLastNameTypeCode,
                ProviderFirstLineBusinessMailingAddress, ProviderSecondLineBusinessMailingAddress, ProviderBusinessMailingAddressCityName, ProviderBusinessMailingAddressStateName, ProviderBusinessMailingAddressPostalCode,
                ProviderBusinessMailingAddressCountryCodeIfoutsideUS, ProviderBusinessMailingAddressTelephoneNumber, ProviderBusinessMailingAddressFaxNumber, ProviderFirstLineBusinessPracticeLocationAddress, ProviderSecondLineBusinessPracticeLocationAddress,
                ProviderBusinessPracticeLocationAddressCityName, ProviderBusinessPracticeLocationAddressStateName, ProviderBusinessPracticeLocationAddressPostalCode, ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS, ProviderBusinessPracticeLocationAddressTelephoneNumber,
                ProviderBusinessPracticeLocationAddressFaxNumber, ProviderEnumerationDate, LastUpdateDate, NPIDeactivationReasonCode, NPIDeactivationDate,
                NPIReactivationDate, ProviderGenderCode, AuthorizedOfficialLastName, AuthorizedOfficialFirstName, AuthorizedOfficialMiddleName,
                AuthorizedOfficialTitleorPosition, AuthorizedOfficialTelephoneNumber, IsSoleProprietor, IsOrganizationSubpart, ParentOrganizationLBN,
                ParentOrganizationTIN, AuthorizedOfficialNamePrefixText, AuthorizedOfficialNameSuffixText, AuthorizedOfficialCredentialText, CertificationDate,
                HealthcareProviderTaxonomyGroup_1, HealthcareProviderTaxonomyGroup_2, HealthcareProviderTaxonomyGroup_3, HealthcareProviderTaxonomyGroup_4, HealthcareProviderTaxonomyGroup_5,
                HealthcareProviderTaxonomyGroup_6, HealthcareProviderTaxonomyGroup_7, HealthcareProviderTaxonomyGroup_8, HealthcareProviderTaxonomyGroup_9, HealthcareProviderTaxonomyGroup_10,
                HealthcareProviderTaxonomyGroup_11, HealthcareProviderTaxonomyGroup_12, HealthcareProviderTaxonomyGroup_13, HealthcareProviderTaxonomyGroup_14, HealthcareProviderTaxonomyGroup_15);
        }
    }
}
 