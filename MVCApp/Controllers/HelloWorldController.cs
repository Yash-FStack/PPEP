using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
       public static List<IndexModelView>? Obj { get; set; }
       public static List<ServicesModelView>? ServiceList = new List<ServicesModelView>();


        public HelloWorldController()
        {
            Obj = new List<IndexModelView> {
            new IndexModelView{ColName = "New Destinations", imgName="./destination.jpg" },
               new IndexModelView{ColName = "New Combo Offers", imgName="./combo.jpg"},
                  new IndexModelView{ColName = "Surprise Plans", imgName="./surprise.jpg"},
                     new IndexModelView{ColName = "Corporate Events", imgName="./corporate.jpg"},
                      new IndexModelView{ColName = "Wedding Functions", imgName="./plate.jpg"},
                       new IndexModelView{ColName = "Anniversary Events", imgName="./anniversary.png"}
            };

        }
        public IActionResult Index()
        {
            
            return View(Obj);
        }
        [HttpPost]
        public IActionResult Index(IndexModelView ac)
        {
            Obj.Add(ac);
            return View(Obj);
        }
      
        public IActionResult Services()
        {
            return View(ServiceList);
        }
        
        public IActionResult CreateService(ServicesModelView servicesModelView)
        {
            ServiceList.Add(servicesModelView);
            return RedirectToAction(nameof(Services));
        }

        public IActionResult Destination()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

    }
}
