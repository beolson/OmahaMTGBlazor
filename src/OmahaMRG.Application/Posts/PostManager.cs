using Microsoft.EntityFrameworkCore;
using OmahaMRG.Application.Common.Enum;
using OmahaMRG.Application.Common.Exceptions;
using OmahaMRG.Application.Common.ExtensionMethods;
using OmahaMRG.Application.Common.Interfaces;
using OmahaMRG.Application.Common.Models;
using OmahaMRG.Application.Entities;
using OmahaMTG.PublicContracts.Posts;

namespace OmahaMRG.Application.Posts
{
    internal class PostManager : ManagerBase, IPostManager
    {
        private readonly IApplicationDbContext _dbContext;

        public PostManager(IApplicationDbContext dbContext, UserContext userContext) : base(userContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreatePost(SavePostCommand command, CancellationToken cancellationToken)
        {
            EnsureUserInRoll(new List<ApplicationRoles> { ApplicationRoles.Admin });

            var post = command.ToPost();
            await _dbContext.Posts.AddAsync(post, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return post.Id;
        }

        public async Task DeletePost(DeletePostCommand command, CancellationToken cancellationToken)
        {
            EnsureUserInRoll(new List<ApplicationRoles> { ApplicationRoles.Admin });

            var dbPost = await _dbContext.Posts.FirstOrDefaultAsync(w => w.Id == command.Id, cancellationToken);

            if (dbPost == null)
            {
                throw new NotFoundException("Post", command.Id);
            }

            if (command.Perm)
            {
                _dbContext.Posts.Remove(dbPost);
            }
            else
            {
                dbPost.IsDeleted = true;
            }

            await _dbContext.SaveChangesAsync(cancellationToken);

            return;
        }

        public async Task<SkipTakeSet<PostResult>> FindPosts(FindPostsQuery query, CancellationToken cancellationToken)
        {
            EnsureUserInRoll(new List<ApplicationRoles> { ApplicationRoles.Admin });

            var result = await _dbContext
                .Posts
                .Where(p => string.IsNullOrWhiteSpace(query.Text) || p.Title.Contains(query.Text) ||
                            p.Body.Contains(query.Text) || p.PostTags.Any(pt => pt.Tag.Name == query.Text))
                .Include(p => p.PostTags)
                .ThenInclude(pt => pt.Tag)
                .Include(p => p.CreatedByUser)
                .Include(p => p.UpdatedByUser)
                .Select(p => p.ToPostResponse())
                .AsSkipTakeSet(query.Skip, query.Take, cancellationToken);

            return result;
        }

        public async Task<PostResult> GetPostById(GetPostQuery query, CancellationToken cancellationToken)
        {
            EnsureUserInRoll(new List<ApplicationRoles> { ApplicationRoles.Admin });

            var result = await _dbContext
                .Posts
                .Include(p => p.PostTags)
                .ThenInclude(pt => pt.Tag)
                .Include(p => p.CreatedByUser)
                .Include(p => p.UpdatedByUser)
                .FirstOrDefaultAsync(p => p.Id == query.Id, cancellationToken);

            if (result == null)
            {
                throw new NotFoundException("Post", query.Id);
            }

            return result.ToPostResponse();
        }

        public async Task UpdatePost(int Id, SavePostCommand command, CancellationToken cancellationToken)
        {
            EnsureUserInRoll(new List<ApplicationRoles> { ApplicationRoles.Admin });

            var dbPost = await _dbContext
                .Posts
                .Include(p => p.PostTags)
                .ThenInclude(pt => pt.Tag)
                .FirstOrDefaultAsync(w => w.Id == Id, cancellationToken);

            if (dbPost == null)
            {
                throw new NotFoundException("Post", Id);
            }

            _dbContext.Posts.Update(dbPost.ApplyUpdateCommand(command));

            await _dbContext.SaveChangesAsync(cancellationToken);

            return;
        }
    }
}
