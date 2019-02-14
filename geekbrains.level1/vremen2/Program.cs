﻿using System;
using System.Reflection;
class Program
{
    static PropertyInfo GetPropertyInfo(object obj, string str)
    {
        return obj.GetType().GetProperty(str);
    }

    static void Main(string[] args)
    {
        DateTime dateTime = new DateTime();
        //dateTime.DayOfWeek
        Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanRead);
        Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanWrite);
        Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null));
        Console.ReadKey();
    }
}
