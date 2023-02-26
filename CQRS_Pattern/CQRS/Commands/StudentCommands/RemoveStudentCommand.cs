namespace CQRS_Pattern.CQRS.Commands.ProductCommands
{
    public class RemoveStudentCommand
    {
        public RemoveStudentCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
