using OmahaMTG.PublicContracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmahaMTG.PublicContracts.Posts
{
    public record FindPostsQuery()
    {
        public OrderBy Order { get; init; } = OrderBy.Asc;
        public string? Text { get; init; }
        public int Skip { get; init; } = 0;
        public int Take { get; init; } = 20;
    }
}
