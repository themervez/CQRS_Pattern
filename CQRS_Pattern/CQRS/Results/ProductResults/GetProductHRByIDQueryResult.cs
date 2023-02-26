namespace CQRS_Pattern.CQRS.Results.ProductResults
{
    public class GetProductHRByIDQueryResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal SalePrice { get; set; }
    }
}
