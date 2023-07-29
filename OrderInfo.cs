using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umed_Alif_Academy_Day_9_HW_9
{
    public readonly struct OrderInfo
    {
        public string OrderNumber { get; init; }
        public DateTime OrderDate { get; init; }

        public OrderInfo(string orderNumber, DateTime orderDate)
        {
            OrderNumber = orderNumber;
            OrderDate = orderDate;
        }

        public string _orderNumber 
        {
            get => _orderNumber;
            init => _orderNumber = value is { Length: > 0 } ? value : throw new ArgumentException("Order Number cannot be empty or null.");
        }
    }
}