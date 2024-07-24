using System;

DateTime date = DateTime.Today;
date = new DateTime(date.Year, date.Month, 1);
Console.WriteLine(date); // This will output the date with the day set to the 1st of the current month
