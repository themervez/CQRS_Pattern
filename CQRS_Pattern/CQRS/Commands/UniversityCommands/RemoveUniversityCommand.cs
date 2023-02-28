using MediatR;

namespace CQRS_Pattern.CQRS.Commands.UniversityCommands
{
    public class RemoveUniversityCommand:IRequest
    {
        public RemoveUniversityCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
