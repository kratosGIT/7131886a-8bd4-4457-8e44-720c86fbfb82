using System.Globalization;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LongestRunningSubsequence
{
    public class Algorithm
    {
        public string GenerateResult(IEnumerable<int> lrs)
        {
            string result = "";

            foreach (var number in lrs)
            {
                if (result == "")
                    result = number.ToString();
                else
                    result = result + " " + number.ToString();
            }

            return result;
        }

        public async Task<string> Run(string input)
        {
            var lrs = await Task.Run(()=>
            {
                // Get a numeric array
                var numbers = input.Split(' ').Select(x => int.Parse(x)).ToArray();

                // Handle edge cases with 0 or 1 number in the array
                if (numbers.Length <= 1)
                {
                    return input;
                }

                // lrsStart : Start Index of the identified LRS.
                // lrsLength : Length of the identified LRS.
                // start: Incrementing identifier
                // end: Incrementing identifier
                int lrsStart, lrsLength, start, end;
                lrsStart = lrsLength = start = end = 1;

                for (int i = 1 ; i < numbers.Length; ++i)
                {
                    if (numbers[i-1] < numbers[i])
                    {
                        end = i;
                    }
                    else
                    {
                        var currLRSLength = end - start;
                        if (lrsLength < currLRSLength)
                        {
                            lrsLength = currLRSLength;
                            lrsStart = start;
                        }
                        start = i;
                        end = i;
                    }

                    // For cases where the LRS reaches the end of the array
                    if (i + 1 == numbers.Length && lrsLength < (end - start))
                    {
                        lrsLength = (end - start);
                        lrsStart = start;
                    }
                }

                return GenerateResult(numbers.Skip(lrsStart).Take(lrsLength + 1));
            });

            return lrs;
        }
    }
}
