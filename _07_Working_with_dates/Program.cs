namespace _07_Working_with_dates;

class Program
{
    static void Main(string[] args)
    {
        DateTime nowDate = DateTime.Now;
        Console.WriteLine("nowDate.ToString(): {0}", nowDate.ToString());
        Console.WriteLine("nowDate.ToShortDateString(): {0}", nowDate.ToShortDateString());
        Console.WriteLine("nowDate.ToShortTimeString(): {0}", nowDate.ToShortTimeString());
        Console.WriteLine("nowDate.ToLongDateString(): {0} ", nowDate.ToLongDateString());
        Console.WriteLine("my date: {0}", nowDate.ToLongTimeString());
        Console.WriteLine("my date + 3 days: {0}", nowDate.AddDays(3).ToLongTimeString());
        Console.WriteLine("my date + 3 hours: {0}", nowDate.AddHours(3).ToLongTimeString());
        Console.WriteLine("my date - 3 hours: {0}", nowDate.AddHours(-3).ToLongTimeString());
        Console.WriteLine("the month: {0}", nowDate.Month);
        Console.Write("");
        
        DateTime myBirthdate = new DateTime(1977, 4, 6);
        Console.WriteLine(myBirthdate);
        Console.WriteLine(myBirthdate.ToShortDateString());
        Console.Write("");

        DateTime myBirthday = DateTime.Parse("6/4/1977");
        TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
        Console.WriteLine(myAge);
        Console.WriteLine(myAge.TotalDays);
        Console.WriteLine(myAge.TotalHours);
        //Console.ReadLine();
    }
}