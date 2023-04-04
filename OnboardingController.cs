using System.Web.Mvc;
using OnboardingForm.Models;

namespace OnboardingForm.Controllers
{
    public class OnboardingController : Controller
    {
        public ActionResult Index()
        {
            return View(new OnboardingFormModel());
        }

        [HttpPost]
        public ActionResult Index(OnboardingFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Perform further validation and processing here...

            return RedirectToAction("Success");
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
