using AkilliPrompt.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Entities
{
    public sealed class PlaceHolder:EntityBase
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }


        public long PromptId { get; set; }
        public Prompt Prompt { get; set; }
    }
}
