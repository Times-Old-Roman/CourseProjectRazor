using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using CourseProjectRazor.Models.MainPModel;
using System.IO;

namespace CourseProjectRazor.Controllers
{
	public class IndexModel : PageModel
	{
		public MainPModel mainPModel { get; private set; }
		public void OnGet()
		{
			mainPModel = new MainPModel();
		}
	}
}
