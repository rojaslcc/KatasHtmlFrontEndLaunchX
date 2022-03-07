using System;

namespace mi_pasteleria.Models
{
    public class Order
    {
        public int id { get; set; }
        public String orderType { get; set; }
        public String productDesc { get; set; }
        public String flavor1 { get; set; }
        public String flavor2 { get; set; }
        public String cover { get; set; }
        public String addOn1 { get; set; }
        public String addOn2 { get; set; }
        public String clientName { get; set; }
        public String clientPhone { get; set; }
        public String clientSchedule { get; set; }
        public String status { get; set; }
    }
}
