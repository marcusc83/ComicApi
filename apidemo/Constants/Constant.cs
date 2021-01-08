using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apidemo.Constants
{
    public class Constant
    {
        private static string currentComicURL = "http://xkcd.com/info.0.json";
        private static string specifiedComicUrl = "http://xkcd.com/{0}/info.0.json"; // format with comic number specified

        public string GetCurrentURL()
        {
            return currentComicURL;
        }
        public string GetSpecifiedURL()
        {
            return specifiedComicUrl;
        }
    }
}
