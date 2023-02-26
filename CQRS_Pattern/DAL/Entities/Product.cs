using System;

namespace CQRS_Pattern.DAL.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public int Tax { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Cost { get; set; }
        public string Warehouse { get; set; }
        public string SizeType { get; set; }
        public decimal Size { get; set; }
        public string Description { get; set; }
        public string Suplier { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime ProductionDate { get; set; }
        public bool Status { get; set; }

    }
}
