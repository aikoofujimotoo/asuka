using FluentValidation;
using asuka.CommandOptions;

namespace asuka.Validators
{
    public class SearchValidator : AbstractValidator<SearchOptions>
    {
        public SearchValidator()
        {
            RuleForEach(opts => opts.Queries)
                .Must(query => !query.StartsWith("-"));

            RuleFor(opts => opts.Page)
                .GreaterThan(0);

            RuleForEach(opts => opts.DateRange)
                .Matches(@"(>|<)?(=)?(\d+)(d|m|w|y)")
                .WithMessage("One or more arguments on your date range is wrong.");

            RuleForEach(opts => opts.PageRange)
                .Matches(@"(>|<)?(=)?(\d+)")
                .WithMessage("One or more arguments on your page range is wrong.");
        }
    }
}