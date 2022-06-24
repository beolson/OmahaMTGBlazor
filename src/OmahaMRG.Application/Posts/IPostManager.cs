using OmahaMRG.Application.Common.Models;
using OmahaMTG.PublicContracts.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmahaMRG.Application.Posts
{
    public interface IPostManager
    {
        public Task<int> CreatePost(SavePostCommand command, CancellationToken cancellationToken);
        public Task DeletePost(DeletePostCommand command, CancellationToken cancellationToken);
        public Task<PostResult> GetPostById(GetPostQuery query, CancellationToken cancellationToken);
        public Task UpdatePost(int Id, SavePostCommand command, CancellationToken cancellationToken);
        public Task<SkipTakeSet<PostResult>> FindPosts(FindPostsQuery query, CancellationToken cancellationToken);
    }
}
