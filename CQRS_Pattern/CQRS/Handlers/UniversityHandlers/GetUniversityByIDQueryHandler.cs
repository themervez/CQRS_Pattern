using CQRS_Pattern.CQRS.Queries.UniversityQueries;
using CQRS_Pattern.CQRS.Results.UniversityResults;
using CQRS_Pattern.DAL.Context;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Pattern.CQRS.Handlers.UniversityHandlers
{
    public class GetUniversityByIDQueryHandler:IRequestHandler<GetUniversityByIDQuery,GetUniversityByIDQueryResult>
    {
        private readonly ProductContext _context;
        public GetUniversityByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<GetUniversityByIDQueryResult> Handle(GetUniversityByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Universities.FindAsync(request.id);
            return new GetUniversityByIDQueryResult
            {
                ID = values.ID,
                City = values.City,
                Name = values.Name,
                Population = values.Population
            };
        }
    }
}
