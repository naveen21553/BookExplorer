using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.Data
{
    class BookData
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public  string ImageSource { get; set; }
            
        public static List<BookData> GetBooks()
        {
            var Books = new List<BookData>();
            Books.Add(new BookData() { BookId = 1, BookTitle = "Book 1", BookAuthor = "Author 1", ImageSource = "Assets/1.png" });
            Books.Add(new BookData() { BookId = 2, BookTitle = "Book 2", BookAuthor = "Author 2", ImageSource = "Assets/2.png" });
            Books.Add(new BookData() { BookId = 3, BookTitle = "Book 3", BookAuthor = "Author 3", ImageSource = "Assets/3.png" });
            Books.Add(new BookData() { BookId = 4, BookTitle = "Book 4", BookAuthor = "Author 4", ImageSource = "Assets/4.png" });
            Books.Add(new BookData() { BookId = 5, BookTitle = "Book 5", BookAuthor = "Author 5", ImageSource = "Assets/5.png" });
            Books.Add(new BookData() { BookId = 6, BookTitle = "Book 6", BookAuthor = "Author 6", ImageSource = "Assets/6.png" });
            Books.Add(new BookData() { BookId = 7, BookTitle = "Book 7", BookAuthor = "Author 7", ImageSource = "Assets/7.png" });
            Books.Add(new BookData() { BookId = 8, BookTitle = "Book 8", BookAuthor = "Author 8", ImageSource = "Assets/8.png" });
            Books.Add(new BookData() { BookId = 9, BookTitle = "Book 9", BookAuthor = "Author 9", ImageSource = "Assets/9.png" });
            Books.Add(new BookData() { BookId = 10, BookTitle = "Book 10", BookAuthor = "Author 10", ImageSource = "Assets/10.png" });
            Books.Add(new BookData() { BookId = 11, BookTitle = "Book 11", BookAuthor = "Author 11", ImageSource = "Assets/11.png" });

            return Books;
        }
    }

}
