using PersonalWebAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebAPI.Domain.Entities
{
    public class Project :BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<ProjectImage> ProjectImages { get; set; }
    }
}
