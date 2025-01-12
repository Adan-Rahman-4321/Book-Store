using System.ComponentModel.DataAnnotations;

namespace Website.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation property to show relation with Book
        public ICollection<Book> Books { get; set; }
    }
}
