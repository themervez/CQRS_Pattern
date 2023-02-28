using CQRS_Pattern.CQRS.Results.UniversityResults;
using MediatR;

namespace CQRS_Pattern.CQRS.Queries.UniversityQueries
{
    public class GetUniversityByIDQuery:IRequest<GetUniversityByIDQueryResult>
    {
        public GetUniversityByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
