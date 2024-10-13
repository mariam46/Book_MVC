using System.ComponentModel.DataAnnotations;

namespace BookWeb.Models
{
    public class Category
    {
        //primary key of the table
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
