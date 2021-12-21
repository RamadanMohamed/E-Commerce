namespace core.Entities
{
    public class product:BaseEntity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string pictureUrl { get; set; }
       
        public prodctType ProdctType { get; set; }
        public int productTypeId { get; set; }
        public ProducBrand producBrand { get; set; }
        public int ProductBrandId { get; set; }

    }
}