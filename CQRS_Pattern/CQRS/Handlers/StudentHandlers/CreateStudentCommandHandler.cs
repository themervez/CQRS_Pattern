using CQRS_Pattern.CQRS.Commands.StudentCommands;
using CQRS_Pattern.DAL.Context;
using CQRS_Pattern.DAL.Entities;

namespace CQRS_Pattern.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public CreateStudentCommandHandler(ProductContext productContext)
        {
            _context = productContext;
        }
        public void Handle(CreateStudentCommand command)
        {
            _context.Students.Add(new Student//Database'de bulunan Entity'e ekleme
            {
                Age = command.Age,
                Name = command.Name,
                City = command.City,
                Surname = command.Surname,
                Status = false
            });
            _context.SaveChanges();
        }
    }
}
