using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using LongestRunningSubsequence;

namespace LongestRunningSubsequence.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public async Task TestCase1()
        {
            var algorithm = new LongestRunningSubsequence.Algorithm("6 1 5 9 2");
            var result = await algorithm.Run();
            Assert.AreEqual("1 5 9", result);
        }
    }
}
