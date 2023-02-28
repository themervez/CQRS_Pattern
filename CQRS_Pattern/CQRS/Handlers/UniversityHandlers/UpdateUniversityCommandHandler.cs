using CQRS_Pattern.CQRS.Commands.UniversityCommands;
using CQRS_Pattern.DAL.Context;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace CQRS_Pattern.CQRS.Handlers.UniversityHandlers
{
    public class UpdateUniversityCommandHandler:IRequestHandler<UpdateUniversityCommand>
    {
        private readonly ProductContext _context;

        public UpdateUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateUniversityCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Universities.Find(request.ID);
            values.Name = request.Name;
            values.City = request.City;
            values.Population = request.Population;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
