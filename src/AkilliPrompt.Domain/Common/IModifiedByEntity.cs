using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Common
{
    public interface IModifiedByEntity
    {
        string? ModifiedByUserId { get; set; }
        DateTimeOffset? ModifiedAt { get; set; }
    }
}
