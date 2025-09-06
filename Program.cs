using ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        LinkedList list = new LinkedList();
        list.Prepend(1);
        list.Prepend(2);
        int x = list.Pop();
        list.Prepend(3);
        list.Prepend(4);
        list.Append(0);
        int y = list.Unqueue();
        foreach (var item in list.ToList())
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(list.IsCircular());
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(GetNumLength(12345));
        Console.WriteLine(IsSortedPalindrome("1221"));
        Console.WriteLine(IsSortedPalindrome("12321"));
        Console.WriteLine(IsSortedPalindrome("42124"));
        SeriesOfNumbers();
    }
    public static int GetNumLength(int number)
    {
        return (int)Math.Log10(number)+1;
    }
    public static bool IsSortedPalindrome(String str)
    {
        if (str == null)  return true;
        int l = str.Length;
        for (int i = 0; i < l / 2; i++)
        {
            if (str[i] != str[l - 1 - i] || str[i] > str[i+1])
                return false;
        }
        return true;
    }
    public static void SeriesOfNumbers()
    {
        int sum = 0, cnt=0,number,cntP=0;
        Console.WriteLine("Enter numbers, -1 to stop:");
        number = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        while (number!=-1)
        {
            sum += number;
            cnt++;
            numbers.Add(number);
            if (number > 0) cntP++;
            number = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Avarage: " + (double)sum/cnt);
        Console.WriteLine("Count Of Positive: " + cntP);
        numbers.Sort();
        Console.WriteLine("Numbers: " + string.Join(", ", numbers));

    }
}