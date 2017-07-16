using System;

public static class DateModifier
{
    public static double CalculateDiff(string firstDate, string secondDate)
    {
        DateTime fDate = DateTime.ParseExact(firstDate, "yyyy MM dd",
            System.Globalization.CultureInfo.InvariantCulture);

        DateTime sDate = DateTime.ParseExact(secondDate, "yyyy MM dd",
            System.Globalization.CultureInfo.InvariantCulture);

        var dateDiff = Math.Abs((fDate - sDate).TotalDays);
        return dateDiff;
    }
}