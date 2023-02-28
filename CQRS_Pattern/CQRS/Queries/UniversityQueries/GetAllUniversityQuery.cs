using CQRS_Pattern.CQRS.Results.UniversityResults;
using MediatR;
using System.Collections.Generic;

namespace CQRS_Pattern.CQRS.Queries.UniversityQueries
{
    public class GetAllUniversityQuery : IRequest<List<GetAllUniversityQueryResult>>
    {
    }
}
