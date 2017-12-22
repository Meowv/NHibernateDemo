using Shop.Business;
using Shop.Domain.Entities;
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customers model)
        {
            customersBusiness.Insert(model);
            return View();
        }

        public ActionResult Edit(string id)
        {
            var result = customersBusiness.GetById(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(Customers model)
        {
            customersBusiness.Update(model);
            return View();
        }

        public ActionResult Details(string id)
        {
            var result = customersBusiness.GetById(id);
            return View(result);
        }

        public ActionResult Delete(string id)
        {
            customersBusiness.Delete(id);
            return View("Index");
        }
    }
}