﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Common
{
    public interface ICreatedByEntity
    {
        string? CreatedByUserId { get; set; }
        DateTimeOffset CreatedOn { get; set; }
    }
}