using System;
using System.Globalization;

namespace ModrenDentalClinic
{
    public static class Global
    {
        // بيانات المستخدم الحالي
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }

        // هل يوجد مستخدم مسجل حالياً

    public static string FormatDateWithDay(DateTime date)
        {
            CultureInfo culture = new CultureInfo("ar-IQ");
            string dayName = date.ToString("dddd", culture);
            string formattedDate = date.ToString("dd/MM/yyyy", culture);

            DateTime today = DateTime.Today;

            if (date.Date == today)
                return $"اليوم {dayName} {formattedDate}";
            else if (date.Date < today)
                return $"{dayName}  {formattedDate}";
            else
                return $"{dayName}  {formattedDate}";
        }
    }
}
