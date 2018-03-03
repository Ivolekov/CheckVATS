namespace InnovasysVatCheck.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InnovasysVatCheck.Data.InnovasysVatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(InnovasysVatCheck.Data.InnovasysVatContext context)
        {
            context.Vats.AddOrUpdate(v=>v.VatNumber,
                new Vat{VatNumber = "BG101662883" },
                new Vat{VatNumber = "BG000275929" },
                new Vat{VatNumber = "BG122056515" },
                new Vat{VatNumber = "BG131437885" },
                new Vat{VatNumber = "BG000000000"},
                new Vat{VatNumber = "ац121437885"},
                new Vat{VatNumber = "BG1313131313131131"});
        }
    }
}
