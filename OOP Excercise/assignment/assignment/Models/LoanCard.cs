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

        public string loanCardId { get; set; }
        public string libraryCardId { get; set; }
        public string bookName { get; set; }
        public string bookId { get; set; }
        public DateOnly dateCreated { get; set; }

        public DateOnly giveBackDate { get; set; }
        

        public LoanCard(string loanCardId, string libraryCardId, string bookName, string bookId, DateOnly dateCreated, DateOnly giveBackDate)
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
