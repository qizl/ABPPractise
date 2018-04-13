using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using SimpleTaskSystem.Tasks.Dtos;

namespace SimpleTaskSystem.Tasks
{
    public class ProjectAppService : SimpleTaskSystemAppServiceBase, IProjectAppService
    {
        private readonly IRepository<Project, Guid> _projectRepository;

        public ProjectAppService(IRepository<Project, Guid> projectRepository)
        {
            this._projectRepository = projectRepository;
        }

        public async Task<ListResultDto<ProjectListDto>> GetAll(GetAllProjectsInput input)
        {
            var projects = await this._projectRepository
                .GetAll()
                .Include(m => m.AssignedPerson)
                //.Where(m => m.Title.Contains(input.Title))
                .WhereIf(!string.IsNullOrEmpty(input.Title), m => m.Title.Contains(input.Title))
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<ProjectListDto>(ObjectMapper.Map<List<ProjectListDto>>(projects));
        }
    }
}
