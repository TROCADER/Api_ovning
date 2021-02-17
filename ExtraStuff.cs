using System;

namespace Api_ovning
{
    public class ExtraStuff
    {
        // Metod som capitaliserar första bokstaven i en string
        // Ej jag som gjort den, hittade den på internet
        static public string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
