using System;
using System.Text;

namespace Discussion.Core.Utilities
{
    public static class StringUtility
    {
        public static string Random(int length = 8)
        {
            var sb = new StringBuilder();
            var random = new Random();
            
            do
            {
                var rand = random.Next(87, 122);
                if (rand < 97)
                {
                    rand -= 39;
                }

                sb.Append((char) rand);
            } while (sb.Length < length);

            return sb.ToString();
        }
        
        
        public static bool IgnoreCaseEqual(this string one, string theOther)
        {
            if (one == null && theOther == null)
            {
                return true;
            }
            
            if (one == null || theOther == null)
            {
                return false;
            }
            
            return one.Equals(theOther, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}