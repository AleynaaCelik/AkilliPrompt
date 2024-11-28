using AkilliPrompt.Domain.Common;
using AkilliPrompt.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Entities
{
    public class UserPromptComment:EntityBase
    {
        public int Level {  get; set; }
        public string Content { get; set; }


        public long PromptId {  get; set; }
        public Prompt Prompt { get; set; }

        public long UserId { get; set; }
        public ApplicationUser User { get; set; }


        public long? ParentCommentId { get; set; } //Yorumun da yorumu için
        public UserPromptComment ParentComment { get; set; }


        public ICollection<UserPromptComment> ChildComments { get; set; } = [];

    }
}
