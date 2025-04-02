namespace WebDev_Labb2.Model.Classes
{
    public class Order
    {
        public string username { get; set; }
        public string order_id { get; set; }
        public DateOnly order_date { get; set; }
        public DateOnly delivery_date { get; set; }
        public string status { get; set; }
        public List<ItemList> item_list { get; set; }
    }

    public class ItemList
    {
        public int sku { get; set; }
        public int quantity { get; set; }
    }
}
