using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Model
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        public string bookName { get; set; }
        public string AuthorName { get; set; }
        public string BookCategory { get; set; }
        public string Edition { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
