using CQRS_Pattern.CQRS.Queries.StudentQueries;
using CQRS_Pattern.CQRS.Results.StudentResults;
using CQRS_Pattern.DAL.Context;

namespace CQRS_Pattern.CQRS.Handlers.StudentHandlers
{
    public class GetStudentByIDQueryHandler
    {
        private readonly ProductContext _context;

        public GetStudentByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public GetStudentByIDQueryResult Handle(GetStudentByIDQuery query)
        {
            var values = _context.Students.Find(query.id);
            return new GetStudentByIDQueryResult
            {
                Age = values.Age,
                City = values.City,
                Name = values.Name,
                Surname = values.Surname,
                ID = values.ID
            };
        }
    }
}
