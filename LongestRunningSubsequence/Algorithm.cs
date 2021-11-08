using System;
using System.Threading.Tasks;

namespace LongestRunningSubsequence
{
    public class Algorithm
    {
        private string Input;
        public Algorithm(string input)
        {
            Input = input;
        }

        public async Task<string> Run()
        {
            var lrs = await Task.Run(()=>
            {
                return "";
            });

            return lrs;
        }
    }
}
