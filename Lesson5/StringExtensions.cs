using System.Text.RegularExpressions;

namespace Lesson5;

/// <summary>
///  This class contains extension methods for the string class.
/// </summary>
public static class StringExtensions
{
    /// <summary>  This method removes all non-alphanumeric characters from a string and strips from both sides. </summary>
    /// <param name="str"> The string to be cleared. </param> 
    /// <returns> The cleared string. </returns>
    public static string Clear(this string str)
    {
        char[] delimiterChars = {' ', '\t', '\n'};

        var resultArray = new Regex("[^a-zA-Z0-9 -]")
            .Replace(str, "")
            .Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

        return string.Join(" ", resultArray);
    }
}