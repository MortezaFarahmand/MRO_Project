using OrganizationManagement.Application.Contracts.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationManagement.Application.Contracts.OrganizationAviationCode
{
    public class CreateOrganizationAviationCode
    {
        public string ICAO { get; set; }
        public string IATA { get; set; }
        public string CivilAutority { get; set; }
        public string Comment { get; set; }
        public string Description { get; set; }
        public string CallSign { get; set; }
        //public Country Country { get; set; }
    }
    public class EditOrganizationAviationCode : CreateOrganizationAviationCode
    {
            public long Id { get; set; }
        }

        public class OrganizationAviationCodeViewModel
    {
        public string ICAO { get; set; }
        public string IATA { get; set; }
        public string CivilAutority { get; set; }
        public string Comment { get; set; }
        public string Description { get; set; }
        public string CallSign { get; set; }
        //public Country Country { get; set; }
    }

    public class OrganizationAviationCodeSearchModel
    {
        public string ICAO { get; set; }
        public string IATA { get; set; }
        public string CivilAutority { get; set; }
        public string Description { get; set; }
        public string CallSign { get; set; }
    }

}
