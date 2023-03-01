using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Models
{
    internal class LibraryCard
    {
        public string cardId { get; set; }
        public string ownerName { get; set; }
        public string cmndId { get; set; }
        public DateOnly dateCreated { get; set; }

        public LibraryCard(string cardId, string ownerName, string cmndId, DateOnly dateCreated)
        {
            this.cardId = cardId;
            this.ownerName = ownerName;
            this.cmndId = cmndId;
            this.dateCreated = dateCreated;
        }

        public LibraryCard()
        {
        }
    }
}
