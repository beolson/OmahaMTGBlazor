using Microsoft.AspNetCore.Mvc;
using OmahaMRG.Application.Posts;
using OmahaMTG.PublicContracts.Posts;

namespace OmahaMTG.Web
{
    public static class AppExtensions
    {
        public static void MapRoutes(this WebApplication app)
        {
            app.MapGet("/Post/{id}", async (
                [FromRoute] int id,
                [FromServices] IPostManager service,
                CancellationToken cancellationToken
            ) => await service.GetPostById(new GetPostQuery(id), cancellationToken));
        }
    }
}
