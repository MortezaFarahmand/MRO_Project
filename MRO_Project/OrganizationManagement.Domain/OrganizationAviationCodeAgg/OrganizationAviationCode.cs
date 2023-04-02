using _0_Framework.Domain;
using OrganizationManagement.Domain.CountryAgg;

namespace OrganizationManagement.Domain.OrganizationAviationCodeAgg
{
    public class OrganizationAviationCode : EntityBase
    {
        public string ICAO { get; private set; }
        public string IATA { get; private set; }
        public string CivilAutority { get; private set; }
        public string Comment { get; private set; }
        public string Description { get; private set; }
        public string CallSign { get; private set; }
        //public Country Country { get; private set; }

        public OrganizationAviationCode(string iCAO, string iATA, string civilAutority, string comment,
            string description, string callSign)
        {
            ICAO = iCAO;
            IATA = iATA;
            CivilAutority = civilAutority;
            Comment = comment;
            Description = description;
            CallSign = callSign;
        }
    }
}
