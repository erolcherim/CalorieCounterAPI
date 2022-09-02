using System.ComponentModel.DataAnnotations;

namespace CalorieCounterAPI.DAL.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string UnitSize { get; set; } // 100g, 1 piece, etc.
        public int ProteinPerUnit { get; set; }
        public int CarbsPerUnit { get; set; }
        public int FatPerUnit { get; set; }
        public virtual ICollection<UserFood> UserFoods { get; set; }
    }
}
