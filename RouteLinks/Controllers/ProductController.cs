using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace RouteLinks.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id, string name)
        {
            return "Id Value is: " + id + " Name value is: " + name;
        }
    }
}
