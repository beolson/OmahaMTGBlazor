using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmahaMTG.PublicContracts.Posts
{
    public record SavePostCommand(string Title, string Body, IEnumerable<string> Tags)

    {
        public bool IsDraft { get; init; }
        public DateTime? PublishStartTime { get; init; }
    }



}
