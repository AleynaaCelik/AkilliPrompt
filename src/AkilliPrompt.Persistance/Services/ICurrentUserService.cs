using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Persistance.Services
{
    public interface ICurrentUserService
    {

        Guid UserId { get; }
        string IpAddress { get; }
    }
}
