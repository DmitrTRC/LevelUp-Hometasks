using System.Text.RegularExpressions;

namespace Lesson5;

/**
 * This class contains extension methods for the string class.
 */
public static class StringExtensions
{
    /**
    * @brief This method removes all non-alphanumeric characters from a string and strips from both sides.
    * @param str The string to be cleared.
    * @return The cleared string.
    */
    public static string Clear(this string str)
    {
        char[] delimiterChars = {' ', '\t', '\n'};

        var resultArray = new Regex("[^a-zA-Z0-9 -]")
            .Replace(str, "")
            .Split(delimiterChars.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        return string.Join(" ", resultArray);
    }
}