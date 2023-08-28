using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeCChallenge.Core.Helpers
{
    public static class JsonValidation
    {
        public static bool ValidateJson(string jsonResult)
        {
            if (jsonResult.Contains("undefined", StringComparison.InvariantCultureIgnoreCase) ||
                jsonResult.Contains("error", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
