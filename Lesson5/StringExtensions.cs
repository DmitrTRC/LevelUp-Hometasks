using System.Text.RegularExpressions;

namespace Lesson5;

public static class StringExtensions
{
    public static string Clear(this string str)
    {
        List<char> delimiterChars = new List<char> {' ', '\t', '\n'};
        //Delete all non-alphanumeric characters new lines , tabs ,  whitespace
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");

        var newStr = rgx.Replace(str, "")
            .Split(delimiterChars.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        return string.Join(" ", newStr);
    }
}