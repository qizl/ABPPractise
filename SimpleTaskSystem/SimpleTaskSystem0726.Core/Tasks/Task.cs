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
            State = TaskState.Active;
            CreationTime = DateTime.Now;
        }

        public virtual int? AssignedPersonId { get; set; }
        public virtual string Description { get; set; }
        public virtual TaskState State { get; set; }
        public virtual DateTime CreationTime { get; set; }

        [ForeignKey("AssignedPersonId")]
        public virtual Person AssignedPerson { get; set; }
    }

    /// <summary>
    /// Possible state of a <see cref="Task"/>
    /// </summary>
    public enum TaskState : byte
    {
        Active = 1,
        Completed = 2
    }
}
