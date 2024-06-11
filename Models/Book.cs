using System.ComponentModel.DataAnnotations;

namespace BookManagementAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Published year is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Published year must be a valid year.")]
        public int PublishedYear { get; set; }
        [Required(ErrorMessage ="Author is required")]
        public string Author { get; set; }
    }
}
