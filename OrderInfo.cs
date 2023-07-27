using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umed_Alif_Academy_Day_9_HW_9
{
    public readonly struct OrderInfo
    {
        public string OrderNumber { get; }
        public DateTime OrderDate { get; }

        public OrderInfo(string orderNumber, DateTime orderDate)
        {
            OrderNumber = orderNumber;
            OrderDate = orderDate;
        }
    }
}