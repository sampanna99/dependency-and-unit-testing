using DependencyInjection.Models;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;


        private Product[] products =
        {
            new Product {Name = "Kayak", Category = "WaterSports", Price = 275M },
            new Product {Name = "Lifejacket", Category = "WaterSports", Price = 48.95M },
            new Product {Name = "Corner flag", Category = "soccer", Price = 34.95M }

        };
        public HomeController(IValueCalculator calcParam, IValueCalculator calc2)
        {
            calc = calcParam;
        }

        public ActionResult Index()
        {
            //IKernel ninjectKernel = new StandardKernel();
            //ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            //IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();
            //IValueCalculator calc = new LinqValueCalculator();
            ShoppingCart cart = new ShoppingCart(calc) { products = products };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);

            //  return View();
        }




        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}