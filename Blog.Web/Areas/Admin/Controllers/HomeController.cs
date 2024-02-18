using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
        private readonly UserManager<AppUser> userManager;

        public HomeController(IArticleService articleService,UserManager<AppUser> userManager)
        {
            this.articleService = articleService;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeleteAsync();
            var loggedInUser = await userManager.GetUserAsync(HttpContext.User);
            return View(articles);
        }

    }
}
