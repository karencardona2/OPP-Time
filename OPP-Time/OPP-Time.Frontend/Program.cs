using OPP_Time.Backend;

try
{
    var time1 = new Time();
    var time2 = new Time(14);
    var time3 = new Time(9, 34);
    var time4 = new Time(19, 45, 56);
    var time5 = new Time(23, 3, 45, 678);
    var times = new List<Time> { time1, time2, time3, time4, time5 };

    foreach (Time time in times)
    {
        Console.WriteLine($"Time: {time}");
        Console.WriteLine($"\tMilliseconds: {time.ToMilliseconds(),15:N0}");
        Console.WriteLine($"\tSeconds     : {time.ToSeconds(),15:N0}");
        Console.WriteLine($"\tMinutes     : {time.ToMinutes(),15:N0}");
        Console.WriteLine($"\tAdd         : {time.Add(time3),15:N0}");
        Console.WriteLine($"\tIs Other day: {time.IsOtherDay(time4)}");
        Console.WriteLine();
    }


    var t6 = new Time(45, -7, 90, -87);
}
catch (Exception exception)
{

    Console.WriteLine(exception.Message);
}

