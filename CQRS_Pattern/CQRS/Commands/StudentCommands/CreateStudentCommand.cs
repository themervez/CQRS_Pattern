namespace CQRS_Pattern.CQRS.Commands.StudentCommands
{
    public class CreateStudentCommand
    {
        //Ekleme işlemlerinde kullanmak için
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public bool Status { get; set; }
        public int Age { get; set; }
    }
}
