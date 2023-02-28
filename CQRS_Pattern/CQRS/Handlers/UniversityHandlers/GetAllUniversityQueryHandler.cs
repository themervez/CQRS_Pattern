using CQRS_Pattern.CQRS.Queries.UniversityQueries;
using CQRS_Pattern.CQRS.Results.UniversityResults;
using CQRS_Pattern.DAL.Context;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MediatR;

namespace CQRS_Pattern.CQRS.Handlers.UniversityHandlers
{
    public class GetAllUniversityQueryHandler:IRequestHandler<GetAllUniversityQuery, List<GetAllUniversityQueryResult>>
    {
        private readonly ProductContext _context;
        public GetAllUniversityQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public async Task<List<GetAllUniversityQueryResult>> Handle(GetAllUniversityQuery request, CancellationToken cancellationToken)
        {
            return await _context.Universities.Select(x =>
            new GetAllUniversityQueryResult
            {
                ID = x.ID,
                Name = x.Name,
                Town = x.City
            }).AsNoTracking().ToListAsync();
        }
    }
}
