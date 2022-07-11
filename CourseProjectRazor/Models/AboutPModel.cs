using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CourseProjectRazor.Models.AboutPModel
{
	public class AboutPModel
	{
		public string aboutText { get; private set; } 
		// Текст-информация о сайте
		public AboutPModel()
		{
			StreamReader read = new StreamReader(@"~/../wwwroot/AboutText.txt");
			aboutText = read.ReadToEnd();
		}
	}
}
