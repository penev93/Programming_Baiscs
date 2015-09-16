using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_9.Extract_URLs_from_Text
{
    class ExtractURLsfromText
    {
        static void Main(string[] args)
        {
            /*\b       -matches a word boundary (spaces, periods..etc)
(?:      -define the beginning of a group, the ?: specifies not to specifically capture the data within this group.
http://  -literal string, match http://
|        -OR
www\.    -literal string, match www. (the \. means a literal ".")
)        -end group
\S+      -match a series of non-whitespace characters.
\b       -match the closing word boundary.
             */
            Regex linkParser = new Regex(@"\b(?:http://|www\.|\.domain|bg\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            string rawString = Console.ReadLine();
            foreach (Match m in linkParser.Matches(rawString))
                Console.WriteLine(m.Value);
        }
    }
}
