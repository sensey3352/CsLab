using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class OrderStatus
    {
        public const string New = "Нове";
        public const string InProgress = "Готується";
        public const string Ready = "Готове";
        public const string Paid = "Оплачено";
        public const string Cancelled = "Скасоване";

        public static string[] GetAllStatuses()
        {
            return new string[] { New, InProgress, Ready, Paid, Cancelled };
        }
    }
}
