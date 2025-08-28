using CitiWatch.Application.DTOs;

namespace CitiWatch.Application.Interfaces
{
    public interface IComplaintService
    {
        Task<BaseResponse<ComplaintCreateDto>> Submit(ComplaintCreateDto createDto, IFormFile formFile);
        Task<BaseResponse<ComplaintResponseDto>> GetById(Guid id);
        Task<BaseResponse<IEnumerable<ComplaintResponseDto>>> GetAll();
        Task<BaseResponse<ComplaintResponseDto>> UpdateStatus(Guid complaintId, ComplaintStatusUpdateDto statusDto);
    }
}