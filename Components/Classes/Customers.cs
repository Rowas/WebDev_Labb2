namespace WebDev_Labb2.Client.Classes
{
    public class Customers
    {
        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string mobile_number { get; set; }
        public string userlevel { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DeliveryAddress delivery_adress { get; set; }
    }

    public class DeliveryAddress
    {
        public string street { get; set; }
        public string post_code { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
}
