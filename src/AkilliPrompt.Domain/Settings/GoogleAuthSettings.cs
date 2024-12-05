using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliPrompt.Domain.Settings
{
    public sealed record GoogleAuthSettings
    {
        public string ClientId { get; init; }

        public GoogleAuthSettings(string clientId)
        {
            ClientId = clientId;
        }

        public GoogleAuthSettings()
        {

        }
    };
}
