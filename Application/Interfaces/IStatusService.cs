using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiWatch.Application.DTOs;

namespace CitiWatch.Application.Interfaces
{
    public interface IStatusService
    {
        Task<BaseResponse<IEnumerable<StatusResponseDto>>> GetAll();
    }
}