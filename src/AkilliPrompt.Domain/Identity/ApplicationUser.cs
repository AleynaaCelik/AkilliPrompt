using AkilliPrompt.Domain.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Identity
{
    public sealed class ApplicationUser:IdentityUser<long>,ICreatedByEntity,IModifiedByEntity
    {
      
        public DateTimeOffset  CreatedOn { get; set; }
        public string?  CreatedByUserId { get; set; }


        public string?  ModifiedByUserId { get; set; }
        public DateTimeOffset?  ModifiedAt { get; set; }


       
    }
}
