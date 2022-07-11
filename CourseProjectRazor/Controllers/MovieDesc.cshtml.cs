using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using CourseProjectRazor.Models.MoviePModel;

namespace CourseProjectRazor.Controllers
{
    public class MovieDescModel : PageModel
    {
		public MoviePModel thisPage { get; private set; }
		public IActionResult OnPost(string seat)
		{
			// �������� ����� ����� �� ����� �� �������� MovieDesc
			// �������������� �� ��������� ��������
			return RedirectToPage(@"Finish", new { seatNum = seat });
		}
        public void OnGet(string id)
        {
			thisPage = new MoviePModel(id);
		}
    }
}
