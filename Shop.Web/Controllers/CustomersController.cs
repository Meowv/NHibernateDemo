using Shop.Business;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class CustomersController : Controller
    {
        CustomersBusiness customersBusiness = new CustomersBusiness();

        public ActionResult Index()
        {
            var result = customersBusiness.GetCustomersList(c => 1 == 1);

            return View(result);
        }
    }
}