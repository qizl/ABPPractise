using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using SimpleTaskSystem.People;

namespace SimpleTaskSystem.Tasks
{
    public class Task : Entity<long>
    {
        public Task()
        {
            CreationTime = DateTime.Now;
            State = TaskState.Active;
        }

        public virtual int? AssignedPersonId { get; set; }
        
        public virtual string Description { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public virtual TaskState State { get; set; }

        [ForeignKey("AssignedPersonId")]
        public virtual Person AssignedPerson { get; set; }
    }
    
}
