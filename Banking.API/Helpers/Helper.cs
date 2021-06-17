using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Helpers
{
    public static class Helper
    {
        public static bool IsCustomerNumber(this string text)
        {
            if (text.Length != 5)
                return false;

            if (!text.StartsWith("6"))
                return false;

            return int.TryParse(text, out int number);
        }
    }
}
