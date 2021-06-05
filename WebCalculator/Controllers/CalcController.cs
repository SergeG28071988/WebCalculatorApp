using System.Web.Mvc;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new Calculator());
        }


        [HttpPost]

        public ActionResult Index(Calculator c, string calculate)
        {
            // Проверка условий

            if(calculate == "add")
            {
                c.Result = c.No1 + c.No2;
            }
            else if (calculate == "sub")
            {
                c.Result = c.No1 - c.No2;
            }
            else if (calculate == "mult")
            {
                c.Result = c.No1 * c.No2;
            }
            else 
            {
                c.Result = c.No1 / c.No2;
            }

            return View(c);
        }
    }
}