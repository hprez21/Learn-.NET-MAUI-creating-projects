using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DevsPark.Utilities
{
    public static class Utils
    {
        public static string GetName(this ContentPage page)
        {
            return Regex.Replace(page.GetType().Name, "([a-z])([A-Z])", "$1 $2");
        }
    }
}
