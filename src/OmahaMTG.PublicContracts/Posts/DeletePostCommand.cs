using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmahaMTG.PublicContracts.Posts
{
    public record DeletePostCommand(int Id)
    {
        public bool Perm { get; init; } = false;
    }
}
