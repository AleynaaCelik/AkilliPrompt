using AkilliPrompt.Domain.Common;
using AkilliPrompt.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Entities
{
    public sealed  class Prompt:EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string? ImageUrl { get; set; }

        public bool IsActive { get; set; }

       // public PromptLLMType PromptLLMType { get; set; }

        //public List<string> PlaceHolders { get; set; } = [];

        //public int SavedCount { get; set; } redis kullancam


        public ICollection<PromptCategory> PromptCategories { get; set; } = [];
        public ICollection<UserFavoritePrompt> UserFavoritePrompts { get; set; } = [];
        public ICollection<UserLikePrompt> UserLikePrompts { get; set; } = [];
        public ICollection<PlaceHolder> PlaceHolders { get; set; } = [];
    }
}
