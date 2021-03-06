using Refit;

namespace asuka.Api.Queries
{
    public record SearchQuery
    {
        [AliasAs("query")]
        public string Queries { get; init; }
        
        [AliasAs("page")]
        public int PageNumber { get; init; }
        
        [AliasAs("sort")]
        public SearchSortOptions Sort { get; init; }
    }
}