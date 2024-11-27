using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Common
{
    public abstract class EntityBase:ICreatedByEntity,IModifiedByEntity
    {
        public long Id { get; set; }
        public string? CreatedByUserId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public string? ModifiedByUserId { get; set; }
        public DateTimeOffset? ModifiedAt { get; set; }
      
    }
}
