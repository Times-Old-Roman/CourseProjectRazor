using System;

namespace CourseProjectRazor.Models.Movies
{
	public class Movie
	{
		public string Name { get; private set; }
		public int Price { get; private set; }
		public string Date { get; private set; }
		public string ImgPath { get; private set; }
		public string Tags { get; private set; }
		public string Id { get; private set; }
		public Movie(string name, 
			int price, string date, 
			string imgPath, string tags, string id)
		{
			Name = name;
			Price = price;
			Date = date;
			ImgPath = imgPath;
			Tags = tags;
			Id = id;
		}
	}
}
