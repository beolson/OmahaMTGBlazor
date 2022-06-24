using OmahaMRG.Application.Entities;
using OmahaMTG.PublicContracts.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmahaMRG.Application.Posts
{
    internal static class MappingExtensions
    {
        internal static Post ToPost(this SavePostCommand command)
        {
            return new Post()
            {
                Title = command.Title,
                Body = command.Body,
                PublishStartTime = command.PublishStartTime,
                PostTags = command.Tags.Select(t => new PostTag { Tag = new Tag() { Name = t } }).ToList()
            };
        }

        internal static PostResult ToPostResponse(this Post post)
        {
            return new PostResult(
                post.Id,
                post.Title,
                post.Body,
                Tags: post.PostTags.Select(pt => pt.Tag.Name).ToList(),

                CreatedTime: post.CreatedDate,
                LastUpdatedTime: post.UpdatedDate,
                CreatedBy: post.CreatedByUser.UserName,
                LastUpdatedBy: post.UpdatedByUser.UserName
            )
            {
                IsDraft = post.IsDraft,
                PublishStartTime = post.PublishStartTime,


            };
        }

        internal static Post ApplyUpdateCommand(this Post target, SavePostCommand command)
        {
            target.Title = command.Title;
            target.Body = command.Body;
            target.PublishStartTime = command.PublishStartTime;
            target.IsDraft = command.IsDraft;
            target.PostTags = command.Tags.Select(t => new PostTag { Tag = new Tag() { Name = t } }).ToList();

            return target;
        }


    }
}
