using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectRazor.Models.Movies;
using System.IO;

namespace CourseProjectRazor.Models.MoviePModel
{
	public class MoviePModel
	{
		public string desc { get; private set; }
		public Movie mv { get; private set; }
		public MoviePModel(string id)
		{
			string descPath = @"~/../wwwroot/Movies/Data/Descs.txt";
			string dataPath = @"~/../wwwroot/Movies/Data/MoviesData.txt";
			// ищет данные фильма по его номеру
			desc = findData(id, descPath);
			parseForMovie(findData(id, dataPath), id);
			desc = desc.Substring(mv.Name.Length + 1);
		}
		private string findData(string id, string filePath)
		{
			StreamReader read = new StreamReader(filePath);
			string line;
			string idStr;
			while ((line = read.ReadLine()) != null)
			{
				idStr = "";
				foreach (char ch in line)
				{
					if (ch == ' ')
					{
						if (idStr == id)
						{
							read.Close();
							line = line.Substring(idStr.Length + 1);
							return line;
						}
						else break;
					}
					idStr += ch;
				}
			}
			return null;
		}
		private void parseForMovie(string data, string id)
		{
			string name = "", date = "", img = "";
			int price = 0;
			int count = 0;
			string movieLine = "";
			foreach (char ch in data)
			{
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
			mv = new Movie(name, price, date, img,
				movieLine.Replace('_', ' '), id);
		}
	}
}
