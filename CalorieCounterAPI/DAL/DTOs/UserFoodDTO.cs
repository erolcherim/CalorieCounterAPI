using CalorieCounterAPI.DAL.Models;

namespace CalorieCounterAPI.DAL.DTOs
{
    public class UserFoodDTO
    {
        public int FoodId { get; set; }
        public int UserId { get; set; }
        public string DateTime { get; set; }
        public int Quantity { get; set; }
        public int TotalCalories { get; set; }
        public int TotalProtein { get; set; }
        public int TotalFat { get; set; }
        public int TotalCarbs { get; set; }

        public UserFoodDTO(UserFood userFood)
        { 
            FoodId = userFood.FoodId;
            UserId = userFood.UserId;
            DateTime = userFood.DateTime;
            Quantity = userFood.Quantity;
            TotalCalories = userFood.TotalCalories;
            TotalProtein = userFood.TotalProtein;
            TotalFat = userFood.TotalFat;
            TotalCarbs = userFood.TotalCarbs;
        }
        public UserFoodDTO() { }
    }
}
