using System;
using System.Collections.Generic;
using System.Text;

namespace Torens
{
    static class StringExt
    {
        public static void SponsoredBy(this string s, string brand)
        {
            Console.WriteLine($"{s} is sponsored by {brand}");
        }
    }
}
