using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _34_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a regular expression for repeated randomWords.
            Regex rx = new Regex(@"\b(?<randomWord>\w+)\s+(\k<randomWord>)\b",
              RegexOptions.Compiled | RegexOptions.IgnoreCase);

            // Define a test string.
            string text = "The the quick brown fox  fox jumps over the lazy dog dog.";

            // Find matches.
            MatchCollection matches = rx.Matches(text);

            // Report the number of matches found.
            Console.WriteLine("{0} matches found in:\n\t{1}",
                              matches.Count,
                              text);

            // Report on each match.
            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("'{0}' repeated at positions {1} and {2}",
                                  groups["randomWord"].Value,
                                  groups[0].Index,
                                  groups[1].Index);
            }

            string propertyname = "awesome";
            Regex rx2 = new Regex(@"^Project/Network[[](?<networkindex>\d+)[]]/(?<propertyname>.*)$",
                RegexOptions.Compiled);
            string text2 = "Project/Network[12]/AddressAddress";
            MatchCollection matches2 = rx2.Matches(text2);
            Console.WriteLine("{0} matches found in:\n\t{1}",
                              matches2.Count,
                              text2);

            foreach (Match match in matches2)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("networkindex: {0}; propertyname: {1}",
                                  groups["networkindex"].Value,
                                  groups["propertyname"].Value);
            }

            Console.ReadKey();
        }
    }
}
