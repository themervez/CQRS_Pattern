using MediatR;

namespace CQRS_Pattern.CQRS.Commands.UniversityCommands
{
    public class UpdateUniversityCommand: IRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
    }
}
