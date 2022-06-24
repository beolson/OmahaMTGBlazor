namespace OmahaMRG.Application.Common.Models
{
    public record SkipTakeSet<T>(
        int Skipped,
        int Taken,
        int TotalRecords,
        IEnumerable<T> Records
    );
}