namespace CQRS_Pattern.CQRS.Commands.StudentCommands
{
    public class UpdateStudentCommand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }
}
