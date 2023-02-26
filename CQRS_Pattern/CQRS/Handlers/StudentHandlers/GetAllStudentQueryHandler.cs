using CQRS_Pattern.CQRS.Results.StudentResults;
using CQRS_Pattern.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CQRS_Pattern.CQRS.Handlers.StudentHandlers
{
    public class GetAllStudentQueryHandler
    {
        private readonly ProductContext _context;

        public GetAllStudentQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public List<GetAllStudentQueryResult> Handle()
        {
            var values = _context.Students.Select(x =>
              new GetAllStudentQueryResult
              {
                  City = x.City,
                  Department = x.Department,
                  Name = x.Name,
                  ID = x.ID,
                  Surname = x.Surname
              }).AsNoTracking().ToList();


            return values;
        }
    }
}
