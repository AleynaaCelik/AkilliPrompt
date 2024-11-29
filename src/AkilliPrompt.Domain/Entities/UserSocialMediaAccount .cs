using AkilliPrompt.Domain.Common;
using AkilliPrompt.Domain.Enums;
using AkilliPrompt.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Entities
{
    public class UserSocialMediaAccount:EntityBase
    {
        public SocialMediaType SocialMediaType { get; set; }
        public string Url { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
