using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiWatch.Application.DTOs;
using CitiWatch.Application.Interfaces;

namespace CitiWatch.Application.Services
{
    public class ComplaintService : IComplaintService
    {
        public Task<BaseResponse<IEnumerable<ComplaintResponseDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<ComplaintResponseDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<ComplaintCreateDto>> Submit(ComplaintCreateDto createDto)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<ComplaintResponseDto>> UpdateStatus(Guid complaintId, StatusUpdateDto statusDto)
        {
            throw new NotImplementedException();
        }
    }
}