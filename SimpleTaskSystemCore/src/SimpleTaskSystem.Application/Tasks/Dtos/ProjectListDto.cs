using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;

namespace SimpleTaskSystem.Tasks.Dtos
{
    [AutoMapFrom(typeof(Project))]
    public class ProjectListDto : EntityDto<Guid>, IHasCreationTime
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? AssignedPersonId { get; set; }
        public string AssignedPersonName { get; set; }
    }
}
