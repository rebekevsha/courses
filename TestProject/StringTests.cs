using NUnit.Framework;
using LessonFour;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class StringTests
    {
        [TestCase("abc", ExpectedResult = "cba", Description = "dfdfddfd")]
        [TestCase("", ExpectedResult = "", Description = "dfdfddfd")]
        [TestCase("a", ExpectedResult = "a", Description = "dfdfddfd")]
        [TestCase("ab", ExpectedResult = "ba", Description = "dfdfddfd")]
        [TestCase("aaa", ExpectedResult = "ccc", Reason ="dfdfd")]
        public string Given_String_When_Reverse_Then_StringReversed(string input)
        {
            return Program.Reverse(input);
        }

        [TestCase("asdfghjk", ExpectedResult = true)]
        [TestCase("aaasdfgg", ExpectedResult = false)]
        [TestCase("a", ExpectedResult = true)]
        [TestCase("", ExpectedResult = true)]

        public bool Given_String_When_IsUnique_Then_UniqueString(string input)
        {
            return Program.IsUnique(input);
        }
    }
}
