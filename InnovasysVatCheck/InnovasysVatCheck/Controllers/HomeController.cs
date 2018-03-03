using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InnovasysVatCheck.Data;
using InnovasysVatCheck.Models.Bindings;
using InnovasysVatCheck.Services.InnovasysVatCheckService;

namespace InnovasysVatCheck.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            using (InnovasysVatContext context = new InnovasysVatContext())
            {
                List<Vat> viewModel = context.Vats.ToList();
                return View(viewModel);
            }
        }

        public ActionResult _Index(int? id)
        {
            checkVatPortTypeClient client = new checkVatPortTypeClient();
            Vat vat;
            CompanyBindingModel companyDetails = new CompanyBindingModel();
            using (InnovasysVatContext context = new InnovasysVatContext())
            {
                vat = context.Vats.FirstOrDefault(v => v.Id == id);
            }

            if (vat != null)
            {
                string countryCode = vat.VatNumber.Substring(0,2);
                string vatNumber = vat.VatNumber.Substring(2,vat.VatNumber.Length-2).TrimEnd();
                client.checkVat(ref countryCode, ref vatNumber, out var isValid, out var name, out var address);
                companyDetails.VatNumber = vatNumber;
                companyDetails.CountryCode = countryCode;
                companyDetails.Address = address;
                companyDetails.Name = name;
                companyDetails.IsValid = isValid;
            }

            client.Close();

            return PartialView(companyDetails);
        }
    }
}