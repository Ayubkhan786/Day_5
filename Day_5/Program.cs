
int year= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Given year =" +year);
if (DateTime.IsLeapYear(year))
{
    Console.WriteLine(year + ": Is leap year");
}
else
{
    Console.WriteLine(year + ": Is not a leap year");
}