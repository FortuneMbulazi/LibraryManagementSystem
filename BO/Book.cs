using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BO
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime DeletedOn { get; set; }

    }
}
