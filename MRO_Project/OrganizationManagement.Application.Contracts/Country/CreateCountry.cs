

namespace OrganizationManagement.Application.Contracts.Country
{
    public class CreateCountry
    {
        public string Name { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string UNCode { get; set; }
        public string DialCode { get; set; }
        public string Picture { get; set; }
        public string TailCode { get; set; }
    }

    public class EditCountry : CreateCountry
    {
        public long Id { get; set; }
    }

    public class CountryViewModel
    {
        public string Name { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string UNCode { get; set; }
        public string DialCode { get; set; }
        public string Picture { get; set; }
        public string TailCode { get; set; }
    }

    public class CountrySearchModel
    {
        public string Name { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string TailCode { get; set; }
    }
}
