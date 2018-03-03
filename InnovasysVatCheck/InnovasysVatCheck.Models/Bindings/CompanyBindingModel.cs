namespace InnovasysVatCheck.Models.Bindings
{
    public class CompanyBindingModel
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string CountryCode { get; set; }

        public string VatNumber { get; set; }

        public bool IsValid { get; set; }
    }
}
