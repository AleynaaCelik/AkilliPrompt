using AkilliPrompt.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Entities
{
    public sealed  class Prompt:EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public ICollection<PromptCategory> PromptCategories { get; set; } = [];
    }
}
