using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using CourseProjectRazor.Models.AboutPModel;

namespace CourseProjectRazor.Controllers
{
    public class AboutModel : PageModel
    {
        public AboutPModel aboutP { get; private set; }
        public void OnGet()
        {
            aboutP = new AboutPModel();
        }
    }
}