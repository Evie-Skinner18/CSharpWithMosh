using System;
using NUnit.Compatibility;
using NUnit.Framework;
using Pt2CSharpBasics.Exercises.FileReader;

namespace FileReaderUnitTests
{
    [TestFixture]
    class FileReaderUnitTests
    {
        [SetUp]
        public void Setup()
        {
            var fileReader = new FileReader(@"/Users/eves/test_file.txt");
        }
    }
}
