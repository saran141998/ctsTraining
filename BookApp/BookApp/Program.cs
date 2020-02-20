using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
	class Program
	{
		static void Main(string[] args)
		{
		   //insertInitialData();
		   showAll();
			Console.ReadKey();
		}
		private static void insertInitialData()
		{
			DetailContext dc = new DetailContext();

			//var books = new List<Book>
			//{
			//	new Book{ Title="Ramayana",Genre="Drama",price=400},
			//	new Book{ Title="Black Widow",Genre="Comics",price=650}
			//};
			//books.ForEach(b => dc.books.Add(b));
			//dc.SaveChanges();

			//var authors = new List<Author>
			//{
			//	new Author{ AuthorName="Vaalmiki",Address="unknown"},
			//	new Author{AuthorName="Stanley",Address="New York"}
			//};
			//authors.ForEach(a => dc.authors.Add(a));
			//dc.SaveChanges();

			var details = new List<Detail>
			{
				new Detail{BookId=1,AuthorId=1},
				new Detail{ BookId=2,AuthorId=2}
			};
			details.ForEach(d => dc.details.Add(d));
			dc.SaveChanges();
		}
		private static void showAll()
		{
			DetailContext dc = new DetailContext();

			var books = dc.books;
			foreach(var b in books)
			{
				Console.WriteLine("{0}\t{1}\t{2}\t{3}", b.BookId,b.Title, b.price, b.Genre);
			}

			var authors = dc.authors;
			foreach(var a in authors)
			{
				Console.WriteLine("{0}\t{1}\t{2}", a.AuthorId, a.AuthorName, a.Address);
			}

			var details = dc.details;
			Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10}{5,8}", "DetailsId","BookId", "AuthorName", "Title", "Price", "Genre");

			foreach(var d in details)
			{
				Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10}{5,8}", d.DetailId, d.Book.BookId, d.Author.AuthorName, d.Book.Title, d.Book.price, d.Book.Genre);
			}
		}
		
	}
}
