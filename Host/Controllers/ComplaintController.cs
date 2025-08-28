using System;
using System.Threading.Tasks;
using CitiWatch.Application.DTOs;
using CitiWatch.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CitiWatch.Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComplaintController(ComplaintService complaintService) : ControllerBase
    {
        private readonly ComplaintService _complaintService = complaintService;

        [HttpGet("GetAll")]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            var response = await _complaintService.GetAll();
            return response.Status ? Ok(response) : BadRequest(response);
        }

        [HttpGet("GetById/{id}")]
        [Authorize]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await _complaintService.GetById(id);
            return response.Status ? Ok(response) : BadRequest(response);
        }

        [HttpPost("Submit")]
        [Authorize]
        public async Task<IActionResult> Submit([FromForm] ComplaintCreateDto createDto, [FromForm] IFormFile formFile)
        {
            var response = await _complaintService.Submit(createDto, formFile);
            return response.Status ? Ok(response) : BadRequest(response);
        }

        [HttpPut("UpdateStatus/{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateStatus([FromRoute] Guid id,ComplaintStatusUpdateDto statusDto)
        {
            var response = await _complaintService.UpdateStatus(id, statusDto);
            return response.Status ? Ok(response) : BadRequest(response);
        }
    }
}
