﻿using AkilliPrompt.Domain.Common;
using AkilliPrompt.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Entities
{
    public sealed  class UserFavoritePrompt:EntityBase
    {
        public long UserId {  get; set; }
        public ApplicationUser User { get; set; }

        public long PromptId {  get; set; }
        public  Prompt Prompt { get; set; }

    }
}
