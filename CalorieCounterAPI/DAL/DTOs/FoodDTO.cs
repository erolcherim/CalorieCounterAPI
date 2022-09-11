using CalorieCounterAPI.DAL.Models;

namespace CalorieCounterAPI.DAL.DTOs
{
    public class FoodDTO
    {
        public int FoodID { get; set; }
        public string? FoodName { get; set; }
        public string UnitSize { get; set; } // 100g, 1 piece, etc.
        public int ProteinPerUnit { get; set; }
        public int CarbsPerUnit { get; set; }
        public int FatPerUnit { get; set; }

        public FoodDTO(Food food)
        {
            FoodName = food.FoodName;
            UnitSize = food.UnitSize;
            ProteinPerUnit = food.ProteinPerUnit;
            CarbsPerUnit = food.CarbsPerUnit;
            FatPerUnit = food.FatPerUnit;
        }
        public FoodDTO() { }
    }
}
