using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
internal class Program
{
    static async Task Main(string[] args)
    {
        await ListDataStructure.Run();

        
        
        WriteLine("Press any key to end...");
        ReadKey();
    }
}

