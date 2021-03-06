using System.Collections.Generic;
using asuka.Api.Queries;
using CommandLine;

namespace asuka.CommandOptions
{
    [Verb("search", HelpText = "Search something in the gallery")]
    public record SearchOptions : ICommonOptions
    {
        [Option('q', "queries",
            Required = false,
            HelpText = "Search queries.")]
        public IEnumerable<string> Queries { get; init; }
        
        [Option('e', "exclude",
            Required = false,
            HelpText = "Exclude something on search.")]
        public IEnumerable<string> Exclude { get; init; }
        
        [Option("page",
            Required = true,
            Default = 1,
            HelpText = "Page to view its contents")]
        public int Page { get; init; }
        
        [Option('d', "dateRange",
            Required = false,
            HelpText = "Specify uploaded date to search")]
        public IEnumerable<string> DateRange { get; init; }
        
        [Option("pageRange",
            Required = false,
            HelpText = "Specify page range of the gallery")]
        public IEnumerable<string> PageRange { get; init; }
        
        [Option("sort",
            Required = false,
            Default = SearchSortOptions.Recent,
            HelpText = "Sort options")]
        public SearchSortOptions Sort { get; init; }
        
        public bool Pack { get; init; }
        public string Output { get; init; }
    }
}