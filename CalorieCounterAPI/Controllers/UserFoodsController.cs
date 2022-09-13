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
    public class UserFoodsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserFoodsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Authorize(Roles ="User")]

        //GET: api/UserFoods
        public async Task<IActionResult> GetUserFoods()
        {
            if (_unitOfWork.UserFoods == null)
            {
                return NotFound();
            }
            var result = (await _unitOfWork.UserFoods.GetAll()).Select(a => new UserFoodDTO(a)).ToList();
            
            return Ok(result);
        }

        //GET: api/UserFoods/{UserId}
        [HttpGet("{UserId}")]
        public async Task<IActionResult> GetUserFoodsByUserId(int id)
        {
            var result = await _unitOfWork.UserFoods.GetAllByUserId(id);

            if (result == null)
            {
                return NotFound("User has no food logged");
            }

            return Ok(result);
        }

        //@erol TODO Get entries for current day

        //POST: api/UserFoods
        [HttpPost]
        public async Task<ActionResult<UserFoodDTO>> PostUserFoods(UserFoodDTO userFood)
        {
            var time = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            var userFoodToAdd = new UserFood();
            userFoodToAdd.UserFoodId = userFood.UserFoodId;
            userFoodToAdd.FoodId = userFood.FoodId;
            userFoodToAdd.UserId = userFood.UserId;
            userFoodToAdd.DateTime = time;
            userFoodToAdd.Quantity = userFood.Quantity;
            userFoodToAdd.TotalCalories = userFood.TotalCalories;
            userFoodToAdd.TotalProtein = userFood.TotalProtein;
            userFoodToAdd.TotalFat = userFood.TotalFat;

            await _unitOfWork.UserFoods.Create(userFoodToAdd);
            _unitOfWork.Save();

            return Ok();
        }

        //PUT: api/Foods/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserFood(int id, UserFoodDTO userFood)
        {
            var userFoodInDb = await _unitOfWork.UserFoods.GetById(id);

            if (userFoodInDb == null)
            {
                return NotFound("Entry with specified id doesn't exist");
            }

            userFoodInDb.UserFoodId = userFood.UserFoodId;
            userFoodInDb.FoodId = userFood.FoodId;
            userFoodInDb.UserId = userFood.UserId;
            userFoodInDb.DateTime = userFood.DateTime;
            userFoodInDb.Quantity = userFood.Quantity;
            userFoodInDb.TotalCalories = userFood.TotalCalories;
            userFoodInDb.TotalProtein = userFood.TotalProtein;
            userFoodInDb.TotalFat = userFood.TotalFat;

            await _unitOfWork.UserFoods.Update(userFoodInDb);
            _unitOfWork.Save();

            return Ok();
        }

        //DELETE: api/Foods/id
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUserFood(int id)
        {
            var userFoodInDb = await _unitOfWork.UserFoods.GetById(id);

            if (userFoodInDb == null)
            {
                return NotFound("Entry with specified id doesn't exist");
            }

            await _unitOfWork.UserFoods.Delete(userFoodInDb);
            _unitOfWork.Save();

            return Ok();
        }

    }



}
