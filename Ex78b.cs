using System;
using System.Text;
using System.Threading.Tasks;

class Program
{
    
    static async Task Main(string[] args)
    {
        await async1();
    }

    public static async Task async1()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Async bắt đầu.");
        await Task.Delay(1000);
        Console.WriteLine("Async kết thúc.");
    }
}
