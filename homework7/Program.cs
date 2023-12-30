// See https://aka.ms/new-console-template for more information

#region task1
var radius = Convert.ToInt32(Console.ReadLine());
var midarea = Math.Pow(radius * 2, 2) / 2;
Console.WriteLine(midarea);
#endregion

#region task2
var list1 = new List<char>();
Console.WriteLine("enter symbols, press S for stop");
char ch;
while (true)
{
    ch = char.Parse(Console.ReadLine());
    if (ch != 's') list1.Add(ch);
    else break;
}
bool jackpot = true;
for (int i = 0; i < list1.Count; i++)
{
    if (list1[0] != list1[i]) jackpot = false;
}
Console.WriteLine(jackpot);
#endregion

#region task3
Console.WriteLine("მოგება :");
var win = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("ფრე :");
var draw = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("წაგება :");
Console.WriteLine(win * 3 + draw * 1);
#endregion

#region task4
Console.WriteLine("Insert worked hours separated with commas: ");
string[] hours = Console.ReadLine().Split(", ");
int sum = 0;
for (int i = 0; i < hours.Length; i++)
{
    int perday = Convert.ToInt16(hours[i]);
    if (i > 5)
    {
        if (perday > 8) sum = sum + 80 + (perday - 8) * 5;
        else sum += perday * 10;
    }
    else sum += perday * 20;
}
Console.WriteLine($"total salary in the week is: {sum}");
#endregion