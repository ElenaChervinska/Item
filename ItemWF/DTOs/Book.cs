namespace ItemWF.DTOs
{
    public class Book : Item
    {
        public int PageQuantity { get; set; }
        public string Publisher { get; set; }
        public IEnumerable<string> Authors { get; set; }
        public Book(
            double price,
            string country,
            string name,
            DateTime packingDate, 
            string description, 
            int pageQuantity,
            string publisher,
            IEnumerable<string> authors) 
            : base(price, country, name, packingDate, description)
        {
            this.PageQuantity = pageQuantity;
            this.Publisher = publisher;
            this.Authors = authors;
        }
    }
}
