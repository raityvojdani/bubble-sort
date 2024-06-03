
Console.Write("1nter numbers:");
int[] number = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
sort();


void sort()
{

    for (int i = 0; i <= Math.Ceiling(Convert.ToDecimal(number.Length) / 2); i++)
    {
        for (int j = 0; j < number.Length - 1; j++)
        {
            if (number[j] > number[j + 1])
            {
                int temp = number[j];
                number[j] = number[j + 1];
                number[j + 1] = temp;
            }
        }
    }
    log();
}
void log()
{
    foreach (int num in number)
    {
        Console.WriteLine($"sorted:{num}");
    }
}