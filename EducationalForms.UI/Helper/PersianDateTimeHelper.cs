using System.Globalization;

namespace EducationalForms.UI.Helper;

public static class PersianDateTimeHelper
{
    public static string ToPersianDateTime(this DateTime dateTime)
    {
        PersianCalendar persianCalendar = new PersianCalendar();
        var year = persianCalendar.GetYear(dateTime);
        var month = persianCalendar.GetMonth(dateTime);
        var day = persianCalendar.GetDayOfMonth(dateTime);
        return $"{year}/{month}/{day} {dateTime.Hour}:{dateTime.Minute}:{dateTime.Second}";
    }
}