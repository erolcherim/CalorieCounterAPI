using CalorieCounterAPI.DAL.DTOs;
using CalorieCounterAPI.DAL.Models;
using CalorieCounterAPI.Repositories.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalorieCounterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public FoodsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //GET: api/Foods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodDTO>>> GetFoods()
        {
            if (_unitOfWork.Foods == null)
            {
                return NotFound();
            }
            var results = (await _unitOfWork.Foods.GetAll()).Select(a => new FoodDTO(a)).ToList();
            return results;
        }

        //GET: api/Foods/Id
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodDTO>> GetFoods(int id)
        {
            var result = await _unitOfWork.Foods.GetById(id);

            if(result == null)
            {
                return NotFound("Food with speicified id does not exist");
            }

            return new FoodDTO(result);
        }

        //GET: api/Foods/name
        [HttpGet("{name}")]
        public async Task<ActionResult<FoodDTO>> GetFoods(string name)
        {
            var result = await _unitOfWork.Foods.GetFoodByFoodName(name);

            if (result == null)
            {
                return NotFound("Food with speicified id does not exist");
            }

            return new FoodDTO(result);
        }

        //POST: api/Foods
        [HttpPost]
        public async Task<ActionResult<FoodDTO>> PostFoods(FoodDTO food)
        {
            var foodToAdd = new Food();
            foodToAdd.FoodName = food.FoodName;
            foodToAdd.CarbsPerUnit = food.CarbsPerUnit;
            foodToAdd.ProteinPerUnit = food.ProteinPerUnit;
            foodToAdd.FatPerUnit = food.FatPerUnit;
            foodToAdd.UnitSize = food.UnitSize;

            await _unitOfWork.Foods.Create(foodToAdd);
            _unitOfWork.Save();

            return Ok();
        }

        //PUT: api/Foods/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFood(int id, FoodDTO food)
        {
            var foodInDb = await _unitOfWork.Foods.GetById(id);

            if (foodInDb == null)
            {
                return NotFound("Food with specified id doesn't exist");
            }

            foodInDb.FoodName = food.FoodName;
            foodInDb.CarbsPerUnit = food.CarbsPerUnit;
            foodInDb.ProteinPerUnit = food.ProteinPerUnit;
            foodInDb.FatPerUnit = food.FatPerUnit;
            foodInDb.UnitSize = food.UnitSize;

            await _unitOfWork.Foods.Update(foodInDb);
            _unitOfWork.Save();

            return Ok();
        }

        //DELETE: api/Foods/id
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var foodInDb = await _unitOfWork.Foods.GetById(id);

            if (foodInDb == null)
            {
                return NotFound("Food with specified id doesn't exist");
            }

            await _unitOfWork.Foods.Delete(foodInDb);
            _unitOfWork.Save();

            return Ok();
        }

    }
}
