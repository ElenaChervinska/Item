using ItemWF.DTOs;

namespace ItemWF
{
    public partial class MainForm : Form
    {
        private IList<Item> items;
        
        public MainForm()
        {
            InitializeComponent();

            this.items = new List<Item>()
            {
                new Product(12, "UK", "Cheese", DateTime.UtcNow, "Some info 1", DateTime.Now, 122, "Kilos"),
                new Product(22, "USA", "Cheese", DateTime.UtcNow, "Some info 2", DateTime.Now, 1, "Kilos"),
                new Product(32, "UKRAINE", "Cheese", DateTime.UtcNow, "Some info 3", DateTime.Now, 40, "Kilos"),
                new Book(52, "Spain", "Book1", DateTime.UtcNow, "Some info about book", 100, "Publisher 1", new List<string> { "author1", "author2"})
            };

            this.InitializeGrid();
        }

        private void InitializeGrid()
        {
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.ShowCellToolTips = true;
            this.dataGridView1.DataSource = this.items;
        }
    }
}