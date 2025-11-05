namespace Cartify.API.Contracts.ProductDtos
{
	public class DtoProductCreate
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int TypeId { get; set; }
    }
}
