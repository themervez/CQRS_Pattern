﻿namespace CQRS_Pattern.CQRS.Results.ProductResults
{
    public class GetProductAccountantByIDQueryResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public int Tax { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Description { get; set; }
    }
}
