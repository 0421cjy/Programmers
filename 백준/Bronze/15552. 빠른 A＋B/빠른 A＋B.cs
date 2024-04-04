using System.Text;

public partial class Program
{
    static void Main(string[] args)
    {
        var sb = new StringBuilder();

        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++)
        {
            var nums = Console.ReadLine().Split();
            var a = Int32.Parse(nums[0]);
            var b = Int32.Parse(nums[1]);

            sb.AppendLine((a + b).ToString());
        }

        Console.WriteLine(sb.ToString());
    }
}