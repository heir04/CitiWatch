using CitiWatch.Application.DTOs;
using CitiWatch.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CitiWatch.Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController(ICategoryService categoryService) : ControllerBase
    {
        private readonly ICategoryService _categoryService = categoryService;

        [HttpPost("Create")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Create(CategoryCreateDto createDto)
        {
            var response = await _categoryService.Create(createDto);
            return response.Status ? Ok(response) : BadRequest(response);
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Update([FromRoute]Guid id, CategoryUpdateDto updateDto)
        {
            var response = await _categoryService.Update(id, updateDto);
            return response.Status ? Ok(response) : BadRequest(response);
        }

        [HttpPut("Delete/{id}")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Delete([FromRoute]Guid id)
        {
            var response = await _categoryService.Delete(id);
            return response.Status ? Ok(response) : BadRequest(response);
        }

        [HttpGet("Get/{id}")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var response = await _categoryService.Get(id);
            return response.Status ? Ok(response) : BadRequest(response);
        }

        [HttpGet("GetAll")]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryService.GetAll();
            return response.Status ? Ok(response) : BadRequest(response);
        }
    }
}