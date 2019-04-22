using System;
using NUnit.Compatibility;
using NUnit.Framework;

namespace FileReader
{
    [TestFixture]
    class FileReaderUnitTests
    {
        [SetUp]
        public void Setup()
        {
            var fileReader = new FileReader();
        }
    }
}
