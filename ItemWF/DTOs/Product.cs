namespace ItemWF.DTOs
{
    public class Product : Item
    {
        public DateTime BestBeforeDate { get; set; }
        public int Quantity { get; set; }
        public string Scalar { get; set; }
        public Product(
            double price,
            string country,
            string name,
            DateTime packingDate, 
            string description, 
            DateTime bestBeforeDate, 
            int quantity, 
            string scalar) 
            : base(price, country, name, packingDate, description)
        {
            this.BestBeforeDate = bestBeforeDate;
            this.Quantity = quantity;
            this.Scalar = scalar;
        }
    }
}
