using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiWatch.Application.DTOs;

namespace CitiWatch.Application.Interfaces
{
    public interface IComplaintService
    {
        Task<BaseResponse<ComplaintCreateDto>> Submit(ComplaintCreateDto createDto);
        Task<BaseResponse<ComplaintResponseDto>> GetById(Guid id);
        Task<BaseResponse<IEnumerable<ComplaintResponseDto>>> GetAll();
        Task<BaseResponse<ComplaintResponseDto>> UpdateStatus(Guid complaintId, StatusUpdateDto statusDto);
    }
}