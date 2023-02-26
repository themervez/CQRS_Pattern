namespace CQRS_Pattern.CQRS.Results.StudentResults
{
    public class GetStudentByIDQueryResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }
}
