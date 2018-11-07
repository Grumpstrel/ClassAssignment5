using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalApp
{
    enum InsuranceCoverageType
    {
        FullCoverage,
        LiabilityOnly
    }
    class InsuranceInformation
    {
        #region Properties
        public string CompanyName { get; set; }
        public string InsuranceCompanyAccountNumber { get; set; }
        public InsuranceCoverageType TypeOfCoverage { get; set; }
        #endregion

        public static InsuranceInformation CustomerInsuranceInformation(string companyName, string insuranceCompanyAccountNumber)
        {
            var customerinsuranceInfo = new InsuranceInformation
            {
                CompanyName = companyName,
                InsuranceCompanyAccountNumber = insuranceCompanyAccountNumber,
                //InsuranceCoverageType insuranceCoverageType = InsuranceCoverageType.FullCoverage
                //TypeOfCoverage = insuranceCoverageType
            };

            return customerinsuranceInfo;
        }
    }
}
