namespace CQRS_Pattern.CQRS.Queries.ProductQueries
{
    public class GetProductHRByIDQuery
    {
        public GetProductHRByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
