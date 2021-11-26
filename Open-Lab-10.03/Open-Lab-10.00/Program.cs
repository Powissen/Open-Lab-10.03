using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            //LOTR.title = "Title";    
            //Console.WriteLine(LOTR.title);
            LOTR.Title("Title");
            LOTR.Pages(50);
            LOTR.Category("Category");
            LOTR.Author("Author");
            LOTR.ReleaseDate(2020);
        }
    }
    public class Book
    {
        public string title;
        public int pages;
        public string category;
        public string author;
        public int releaseDate;

        public void Title(string NewTitle) 
        { 
            title = NewTitle;
            Console.WriteLine("Title: " + title);
        }
        public void Pages(int NewPages) 
        {
            pages = NewPages; 
            if (pages < 0)
            {
                pages = 1;
            }
            Console.WriteLine("Pages: " + pages);
        }
        public void Category(string NewCategory) 
        { 
            category = NewCategory;
            Console.WriteLine("Category: " + category);
        }
        public void Author(string NewAuthor) 
        { 
            author = NewAuthor;
            Console.WriteLine("Author: " + author);
        }
        public void ReleaseDate(int NewReleaseDate) 
        { 
            releaseDate = NewReleaseDate;
            if (releaseDate < 1450 || releaseDate > 2021)
            {
                releaseDate = -1;
            }
            Console.WriteLine("Release date: " + releaseDate);
        }


        public void WriteAllVariables()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Release date: " + releaseDate);

        }
    }
}
