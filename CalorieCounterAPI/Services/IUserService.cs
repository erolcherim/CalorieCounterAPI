﻿using CalorieCounterAPI.DAL.DTOs;

namespace CalorieCounterAPI.Services
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(UserRegisterDTO dto);
    }
}