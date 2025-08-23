using Microsoft.AspNetCore.Mvc;

namespace RouteLinks.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id)
        {
            return "Id Value is: " + id;
        }
    }
}
