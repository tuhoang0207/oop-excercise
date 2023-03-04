using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Models
{
    internal class LoanCard
    {
        public LoanCard()
        {
        }

        public int loanCardId { get; set; }
        public int libraryCardId { get; set; }
        public string bookName { get; set; }
        public int bookId { get; set; }
        public DateOnly dateCreated { get; set; }

        public DateOnly giveBackDate { get; set; }
        
        public LoanCard(int loanCardId, int libraryCardId, string bookName, int bookId, DateOnly dateCreated, DateOnly giveBackDate)
        {
            this.loanCardId = loanCardId;
            this.libraryCardId = libraryCardId;
            this.bookName = bookName;
            this.bookId = bookId;
            this.dateCreated = dateCreated;
            this.giveBackDate = giveBackDate;
        }
    }
}
