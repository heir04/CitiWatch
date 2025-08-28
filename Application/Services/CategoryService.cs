using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiWatch.Application.DTOs;
using CitiWatch.Application.Helper;
using CitiWatch.Application.Interfaces;
using CitiWatch.Domain.Entities;
using CitiWatch.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CitiWatch.Application.Services
{
    public class CategoryService(ApplicationContext context, ValidatorHelper validatorHelper) : ICategoryService
    {
        private readonly ApplicationContext _context = context;
        private readonly ValidatorHelper _validatorHelper = validatorHelper;
        public async Task<BaseResponse<CategoryResponseDto>> Create(CategoryCreateDto createDto)
        {
            var response = new BaseResponse<CategoryResponseDto>();

            var ifExist = await _context.Categories.AnyAsync(c => c.Name == createDto.Name && !c.IsDeleted);
            if (ifExist)
            {
                response.Message = "Category already Exist";
                return response;
            }

            var category = new Category
            {
                Name = createDto.Name,
                CreatedBy = _validatorHelper.GetUserId()
            };

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            response.Status = true;
            response.Message = "Success";
            return response;
        }

        public async Task<BaseResponse<bool>> Delete(Guid categoryId)
        {
            var response = new BaseResponse<bool>();

            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId && !c.IsDeleted);

            if (category is null)
            {
                response.Message = "Not found";
                return response;
            }

            category.IsDeleted = true;
            category.IsDeletedBy = _validatorHelper.GetUserId();

            await _context.SaveChangesAsync();

            response.Status = true;
            response.Message = "Success";
            return response;
        }

        public async Task<BaseResponse<CategoryResponseDto>> Get(Guid categoryId)
        {
            var response = new BaseResponse<CategoryResponseDto>();

            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId && !c.IsDeleted);
            if (category is null)
            {
                response.Message = "Not found";
                return response;
            }

            response.Status = true;
            response.Message = "Success";
            response.Data = new CategoryResponseDto
            {
                Id = category.Id,
                Name = category.Name
            };
            return response;
        }

        public async Task<BaseResponse<IEnumerable<CategoryResponseDto>>> GetAll()
        {
            var response = new BaseResponse<IEnumerable<CategoryResponseDto>>();

            var categories = await _context.Categories
                .Where(c => !c.IsDeleted)
                .ToListAsync();

            response.Status = true;
            response.Message = "Success";
            response.Data = categories.Select(c => new CategoryResponseDto
            {
                Id = c.Id,
                Name = c.Name
            });

            return response;
        }

        public async Task<BaseResponse<CategoryResponseDto>> Update(Guid categoryId, CategoryUpdateDto updateDto)
        {
            var response = new BaseResponse<CategoryResponseDto>();

            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId && !c.IsDeleted);
            if (category is null)
            {
                response.Message = "Not found";
                return response;
            }

            category.Name = updateDto.Name;
            category.LastModifiedBy = _validatorHelper.GetUserId();
            category.LastModifiedOn = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            response.Status = true;
            response.Message = "Success";
            response.Data = new CategoryResponseDto
            {
                Id = category.Id,
                Name = category.Name
            };
            return response;
        }
    }
}