using System;
using System.Collections.Generic;
using CourseProjectRazor.Models.Movies;
using System.IO;

namespace CourseProjectRazor.Models.MainPModel
{
	public class MainPModel
	{
		public string dataPath { get; private set; }
		public List<Movie> Movies { get; private set; }
		public MainPModel()
		{
			dataPath = @"~/../wwwroot/Movies/Data/MoviesData.txt";
			Movies = new List<Movie>();
			StreamReader read = new StreamReader(dataPath);
			string line;
			while ((line = read.ReadLine()) != null)
				parseForMovie(line);
		}
		private void parseForMovie(string line)
		{
			string name = "", date = "", img = "", id = "";
			int price = 0;
			int count = -1;
			string movieLine = "";
			foreach (char ch in line)
			{
				// в базе данных каждый элемент информации фильма разделен
				// пробелом. При встрече пробела вызывается следующий блок кода
				if (ch == ' ' || ch == '\n')
				{
					count++;
					switch (count)
					{
						case 0: // номер фильма
							id = movieLine;
							break;
						case 1: // название фильма
							name = movieLine.Replace('_', ' '); ;
							break;
						case 2: // цена фильма
							price = Convert.ToInt32(movieLine);
							break;
						case 3: // время проведения фильма
							date = movieLine.Replace('_', ' ');
							break;
						case 4: // название файла с изображением фильма
							img = movieLine;
							break;
					}
					movieLine = "";
				}
				else movieLine += ch;
			}
			Movies.Add(new Movie(name, price, date, img,
				movieLine.Replace('_', ' '), id));
		}
	}
}
