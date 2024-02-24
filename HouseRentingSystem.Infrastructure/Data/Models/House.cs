using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House to rent")]
    public class House
    {
        [Comment("House Identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("House name")]
        [Required]
        [MaxLength(HouseTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Comment("House address")]
        [Required]
        [MaxLength(HouseAddressMaxLength)]
        public string Address { get; set; } = string.Empty;

        [Comment(" House Description")]
        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;


        [Comment("House ImageUrl")]
        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("House PricePerMonth")]
        [Required]
        [Column(TypeName ="decimal(18,2)")]
        //[Range(typeof(decimal), "HousePricePerMonthMinLength", "HousePricePerMonthMaxLength", ConvertValueInInvariantCulture =true)]
        public decimal PricePerMonth { get; set; }

        [Comment("CategoryIdentifier")]
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("Agent Identifier")]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

        [Comment("User id of the renterer")]
        public string? RenterId { get; set; }


    }
}
//The House class should have the following properties:
//•	Id – a unique integer, Primary Key
//•	Title – a string with min length 10 and max length 50 (required)
//•	Address – a string with min length 30 and max length 150 (required)
//•	Description – a string with min length 50 and max length 500 (required)
//•	ImageUrl – a string(required)
//•	PricePerMonth – a decimal with min value 0 and max value 2000 (required)
//•	CategoryId – an integer(required)
//•	Category – a Category object
//•	AgentId – an integer (required)
//•	Agent – an Agent object
//•	RenterId – a string
