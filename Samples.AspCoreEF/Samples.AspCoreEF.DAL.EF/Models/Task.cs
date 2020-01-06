using System;
using System.Collections.Generic;
using System.Text;

namespace Samples.AspCoreEF.DAL.EF.Models
{
    public class Task
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public TaskState State { get; set; }
        public virtual Person AssignedTo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Task()
        {
            CreationTime = DateTime.UtcNow;
            State = TaskState.Open;
        }
    }
}
