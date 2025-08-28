using CitiWatch.Application.DTOs;
using CitiWatch.Application.Interfaces;
using CitiWatch.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CitiWatch.Application.Services
{
    public class StatusService(ApplicationContext context) : IStatusService
    {
        private readonly ApplicationContext _context = context;

        public async Task<BaseResponse<IEnumerable<StatusResponseDto>>> GetAll()
        {
            var response = new BaseResponse<IEnumerable<StatusResponseDto>>();

            var statuses = await _context.Statuses.Where(x => !x.IsDeleted).ToListAsync();
            if (!statuses.Any())
            {
                response.Message = "No statuses found.";
                return response;
            }

            response.Data = statuses.Select(x => new StatusResponseDto
            {
                Id = x.Id,
                Name = x.Name
            });
            response.Status = true;
            response.Message = "Success";
            return response;
        }
    }
}