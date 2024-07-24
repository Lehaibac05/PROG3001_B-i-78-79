using System;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var thread = new Thread(() =>
        {
            Console.WriteLine("Thread bắt đầu.");
            Thread.Sleep(1000);
            Console.WriteLine("Thread kết thúc.");
        });
        thread.Start();
        thread.Join();
    }
}
