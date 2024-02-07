using EasyBlog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBlog.Components
{
    public class SidebarCategoriesViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public SidebarCategoriesViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _db.Categories.ToListAsync());
        }
    }
}
