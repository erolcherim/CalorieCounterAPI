using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalorieCounterAPI.DAL.Models
{
    public class UserFood
    {
        //defining relation
        [Key]
        public int UserFoodId { get; set; }
        public int FoodId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("FoodId")]
        public Food? Food { get; set; }
        [ForeignKey("Id")]
        public User? User { get; set; }

        //speicific attributes
        public string DateTime { get; set; }
        public int Quantity { get; set; }
        public int TotalCalories { get; set; }
        public int TotalProtein { get; set; }
        public int TotalFat { get; set; }
        public int TotalCarbs { get; set; }

    }
}

