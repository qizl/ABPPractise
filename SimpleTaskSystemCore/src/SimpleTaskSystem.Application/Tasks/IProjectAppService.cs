using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SimpleTaskSystem.Tasks.Dtos;

namespace SimpleTaskSystem.Tasks
{
    public interface IProjectAppService : IApplicationService
    {
        Task<ListResultDto<ProjectListDto>> GetAll(GetAllProjectsInput input);
    }
}
