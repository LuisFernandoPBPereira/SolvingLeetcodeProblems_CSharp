public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        DateTime dateConvert1 = DateTime.Parse(date1);
        DateTime dateConvert2 = DateTime.Parse(date2);

        return Math.Abs((dateConvert1 - dateConvert2).Days);
    }
}