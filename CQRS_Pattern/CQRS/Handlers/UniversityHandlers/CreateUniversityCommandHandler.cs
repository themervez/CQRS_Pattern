using CQRS_Pattern.CQRS.Commands.UniversityCommands;
using CQRS_Pattern.DAL.Context;
using CQRS_Pattern.DAL.Entities;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace CQRS_Pattern.CQRS.Handlers.UniversityHandlers
{
    public class CreateUniversityCommandHandler :IRequestHandler<CreateUniversityCommand>
    {
        private readonly ProductContext _context;

        public CreateUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateUniversityCommand request, CancellationToken cancellationToken)
        {
            _context.Universities.Add(new University
            {
                City = request.City,
                Name = request.Name,
                Population = request.Population,
                FacultyCount = request.FacultyCount
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
