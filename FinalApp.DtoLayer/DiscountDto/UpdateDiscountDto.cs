namespace FinalApp.DtoLayer.Discount
{
    public class UpdateDiscountDto
    {
        public int DiscountID { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
