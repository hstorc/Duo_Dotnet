using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snippets;
namespace getAkey
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(9000);
            string s = rand.NextDouble().ToString();
            string akey = SHA1Util.SHA1HashStringForUTF8String(s);
            Console.WriteLine(akey);
            Console.ReadLine();
        }
    }


}
