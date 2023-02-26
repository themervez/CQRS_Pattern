using CQRS_Pattern.CQRS.Commands.StudentCommands;
using CQRS_Pattern.DAL.Context;

namespace CQRS_Pattern.CQRS.Handlers.StudentHandlers
{
    public class UpdateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public UpdateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(UpdateStudentCommand command)
        {
            var values = _context.Students.Find(command.ID);
            values.City = command.City;
            values.Name = command.Name;
            values.Surname = command.Surname;
            values.Age = command.Age;
            _context.SaveChanges();
        }
    }
}
