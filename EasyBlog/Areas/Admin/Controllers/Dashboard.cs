using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBlog.Areas.Admin.Controllers
{
    public class Dashboard : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
