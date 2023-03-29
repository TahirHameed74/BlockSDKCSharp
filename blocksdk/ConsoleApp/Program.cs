using System;
using System.Threading.Tasks;
using BlockSdk;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Webhook bas = BlockSDK.createWebHOOK("B1zZARyW1d2FdqWxPUpB79izHmtAc2Az693WF9DD");
            var res = bas.listPrice();
            Console.WriteLine(res);
        }
    }
}
