using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noyan.Customers.Core.Extentions
{
    public static class DateTimeExtentions
    {
        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// </summary>
        /// <param name="date">تاریخ میلادی</param>
        /// <returns></returns>
        public static string ToPersianDate(this DateTime date)
        {
            if (date == null) return "";
            PersianCalendar p = new PersianCalendar();
            var monthes = p.GetMonth(date);
            var dayes = p.GetDayOfMonth(date);
            string month = "";
            string day = "";
            if (monthes < 10)
            {
                month = "0" + monthes;
            }
            else month = monthes.ToString();
            if (dayes < 10)
            {
                day = "0" + dayes;
            }
            else day = dayes.ToString();

            var persianDate = p.GetYear(date) + "/" + month + "/" + day;
            return persianDate.ToString();
        }
    }
}
