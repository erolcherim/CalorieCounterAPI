﻿using CalorieCounterAPI.DAL.Models;

namespace CalorieCounterAPI.DAL.DTOs
{
    public class UserFoodDTO
    {
        public int UserFoodId { get; set; }
        public int FoodId { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public int Quantity { get; set; }
        public int TotalCalories { get; set; }
        public int TotalProtein { get; set; }
        public int TotalFat { get; set; }

        public UserFoodDTO(UserFood userFood)
        {
            UserFoodId = userFood.UserFoodId;
            FoodId = userFood.FoodId;
            UserId = userFood.UserId;
            DateTime = userFood.DateTime;
            Quantity = userFood.Quantity;
            TotalCalories = userFood.TotalCalories;
            TotalProtein = userFood.TotalProtein;
            TotalFat = userFood.TotalFat;
        }
        public UserFoodDTO() { }
    }
}