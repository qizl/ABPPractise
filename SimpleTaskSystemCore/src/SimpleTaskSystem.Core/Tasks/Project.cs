using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SimpleTaskSystem.People;

namespace SimpleTaskSystem.Tasks
{
    public class Project : Entity<Guid>, IHasCreationTime
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? AssignedPersonId { get; set; }

        [ForeignKey(nameof(AssignedPersonId))]
        public Person AssignedPerson { get; set; }
    }
}
