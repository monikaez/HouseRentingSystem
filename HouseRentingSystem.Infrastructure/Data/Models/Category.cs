using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House Category")]
    public class Category
    {
        [Comment("Category Identifier")]
        [Key]
        public int Id { get; set; }


        [Comment("Category name")]
        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        public List<House> Houses { get; set; } = new List<House>();

    }
}
//The Category class should have the following properties:
//•	Id – a unique integer, Primary Key
//•	Name – a string with max length 50 (required)
//•	Houses – a collection of House
