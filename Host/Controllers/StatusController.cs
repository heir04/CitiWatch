using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiWatch.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CitiWatch.Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController(IStatusService statusService) : ControllerBase
    {
        private readonly IStatusService _statusService = statusService;
        
        [HttpGet("GetAll")]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            var response = await _statusService.GetAll();
            return response.Status ? Ok(response) : BadRequest(response);
        }
    }
}