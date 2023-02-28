using CQRS_Pattern.CQRS.Commands.UniversityCommands;
using CQRS_Pattern.DAL.Context;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Pattern.CQRS.Handlers.UniversityHandlers
{
    public class RemoveUniversityCommandHandler:IRequestHandler<RemoveUniversityCommand>
    {
        private readonly ProductContext _context;

        public RemoveUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveUniversityCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Universities.Find(request.id);
            _context.Universities.Remove(values);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
