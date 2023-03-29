using System;
using System.Threading.Tasks;

namespace TestLibrary
{
    class Program { 
        static async Task Main(string[] args)
        {
            
            var bas = new Base("aaa");
            bas.request("GET", "", new String[] { "" });


        }
    }
}
