using AkilliPrompt.Domain.Common;
using AkilliPrompt.Domain.Entities;
using AkilliPrompt.Domain.ValueObjects;
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
      public  FullName FullName { get; set; }
        public DateTimeOffset  CreatedOn { get; set; }
        public string?  CreatedByUserId { get; set; }


        public string?  ModifiedByUserId { get; set; }
        public DateTimeOffset?  ModifiedAt { get; set; }


        public ICollection<UserSocialMediaAccount> userSocialMediaAccounts { get; set; } = [];
        public ICollection<UserPromptComment> UserPromptComments { get; set; } = [];
        public ICollection<UserFavoritePrompt> UserFavoritePrompts { get; set; } = [];
        public ICollection<UserLikePrompt> UserLikePrompts { get; set; } = [];

    }
}
