using Microsoft.EntityFrameworkCore;
using OmahaMRG.Application.Common.Models;

namespace OmahaMRG.Application.Common.ExtensionMethods
{
    public static class QueryableExtensions
    {
        public static async Task<SkipTakeSet<T>> AsSkipTakeSet<T>(this IQueryable<T> query, int skip, int take,
            CancellationToken cancellationToken)
        {
            var result = new SkipTakeSet<T>
            (
                TotalRecords: query.Count(),
                Records: await query.Skip(skip).Take(take).ToListAsync(cancellationToken),
                Skipped: skip,
                Taken: take
            );
            return result;
        }
    }
}