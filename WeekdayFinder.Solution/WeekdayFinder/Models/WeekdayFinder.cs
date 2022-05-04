using System;

namespace WeekdayFinder.Models
{
  public class DateFinder
  {
    private const int AnchorMonth = 1;
    private const int AnchorDay = 1;
    private const int AnchorYear = 1800;
    private const int AnchorDayOfWeek = 3;

    private static int[] t = {0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4};

    public static string Find(int month, int day, int year)
    {
      try
      {
        DateTime date = new DateTime(year, month, day);
        return date.DayOfWeek.ToString();
      }
      catch (Exception exception)
      {
        return "Invalid date";
      }
    }

    public static string DayOfWeek(int m, int d, int y)
    {
      if (!CheckDateIsValid(m, d, y)) return "Invalid date - Input";
      if (m < 3)
      {
        y -= 1;
      }
      return DayNumberToString((y + y/4 - y/100 + y/400 + t[m-1] + d) % 7);
    }

    public static bool CheckDateIsValid(int month, int day, int year)
    {
      if (month < 1 || month > 12 || day < 1 || day > 31)
      {
        return false;
      }
      else if (day > 28)
      {
        if (month == 2)
        {
          if (day > 29 || Math.Abs(year) % 4 != 0)
          {
            return false;
          }
        }
        else if (day == 31)
        {
          if ((month < 8 && month % 2 == 0) || (month >= 8 && month % 2 == 1))
          {
            return false;
          }
        }
      }
      return true;
    }

    private static string DayNumberToString(int day)
    {
      switch (day)
      {
        case 1: return "Monday";
        case 2: return "Tuesday";
        case 3: return "Wednesday";
        case 4: return "Thursday";
        case 5: return "Friday";
        case 6: return "Saturday";
        case 7: return "Sunday";
        default: return "Invalid date";
      }
    }
  }
}