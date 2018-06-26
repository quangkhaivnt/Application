namespace Application.entity
{
    public class Product
    {
        private string productId;
        private string productName;
        private string price;

        public Product()
        {
        }

        public Product(string productId, string productName, string price)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
        }

        public string ProductId
        {
            get => productId;
            set => productId = value;
        }

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public string Price
        {
            get => price;
            set => price = value;
        }
    }
}