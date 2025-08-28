using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiWatch.Application.DTOs;

namespace CitiWatch.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<BaseResponse<CategoryResponseDto>> Create(CategoryCreateDto categoryCreateDto);
        Task<BaseResponse<CategoryResponseDto>> Update(Guid categoryId, CategoryUpdateDto categoryUpdateDto);
        Task<BaseResponse<bool>> Delete(Guid categoryId);
        Task<BaseResponse<CategoryResponseDto>> Get(Guid categoryId);
        Task<BaseResponse<IEnumerable<CategoryResponseDto>>> GetAll();
    }
}