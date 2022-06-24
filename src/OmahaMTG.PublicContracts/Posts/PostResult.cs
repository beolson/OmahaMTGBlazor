using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmahaMTG.PublicContracts.Posts
{
    public record PostResult(
        int Id,
        string Title,
        string Body,
        IEnumerable<string> Tags,
        DateTime CreatedTime,
        DateTime LastUpdatedTime,
        string CreatedBy,
        string LastUpdatedBy
     )

    {
        public bool IsDraft { get; init; }
        public DateTime? PublishStartTime { get; init; }
    }
}
