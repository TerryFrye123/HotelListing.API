﻿using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Models.Users;
using HotelListing.API.Repository;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<IEnumerable<IdentityError>> RegisterAdmin(ApiUserDto userDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);
        Task<string> CreateRefreshToken();
        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
    }
}
