using System.ComponentModel.DataAnnotations.Schema;

namespace CalorieCounterAPI.DAL.Models
{
    public class UserFood
    {
        //defining relation
        public int UserFoodId { get; set; }
        public int FoodId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("FoodId")]
        public Food Food { get; set; }
        [ForeignKey("Id")]
        public User User { get; set; }

        //speicific attributes
        public DateTime DateTime { get; set; }
        public int Quantity { get; set; }

    }
}

