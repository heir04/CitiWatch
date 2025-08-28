using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiWatch.Application.DTOs;

namespace CitiWatch.Application.Interfaces
{
    public interface IUserService
    {
        Task<BaseResponse<UserCreateDto>> Register(UserCreateDto userCreateDto);
        Task<BaseResponse<UserResponseDto>> Login(LoginDto loginDto);
        Task<BaseResponse<IEnumerable<UserResponseDto>>> GetAll();
        Task<BaseResponse<bool>> Update(Guid userId, UserUpdateDto userUpdateDto);
        Task<BaseResponse<bool>> Delete(Guid userId);
    }
}