using CitiWatch.Application.DTOs;

namespace CitiWatch.Application.Interfaces
{
    public interface IStatusService
    {
        Task<BaseResponse<IEnumerable<StatusResponseDto>>> GetAll();
    }
}