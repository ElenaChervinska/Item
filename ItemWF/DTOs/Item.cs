namespace ItemWF.DTOs
{
    public class Item
    {
        public double Price { get; set; }
        public string? Country { get; set; }
        public string? Name { get; set; }
        public DateTime PackingDate { get; set; }
        public string? Description { get; set; }

        public Item(double price, string country, string name, DateTime packingDate, string description)
        {
            this.Price = price;
            this.Country = country;
            this.Name = name;
            this.PackingDate = packingDate;
            this.Description = description;
        }
    }
}
