using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Models
{
    internal class Book
    {
        public int bookId { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
        public int quantity { get; set; }
        public string genre { get; set; }

        
        public Book()
        {
        }
        public Book(int bookId, string bookName, string author, int quantity, string genre)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.author = author;
            this.quantity = quantity;
            this.genre = genre;
        }

    }
}
