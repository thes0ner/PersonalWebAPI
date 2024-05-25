using PersonalWebAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebAPI.Domain.Entities
{
    public class ProjectImage : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public Project Project { get; set; }
    }
}
