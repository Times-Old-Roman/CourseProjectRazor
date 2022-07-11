using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CourseProjectRazor.Models.FinishPModel;

namespace CourseProjectRazor.Controllers
{
    public class FinishModel : PageModel
    {
        public FinishPModel finishP { get; private set; }
        public void OnGet()
        {
            finishP = new FinishPModel();
        }
    }
}
