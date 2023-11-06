using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.FizzbuzzRepository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using log4net;
using System.IO.Abstractions;
using CrossCutting.Logging;
using Domain.Entities;
using Infrastructure.FizzbuzzRepository.Contracts;
using Moq;
using System.IO.Abstractions.TestingHelpers;
using System.IO;

namespace Infrastructure.FizzbuzzRepository.Implementations.Unit.Tests
{
    [TestClass()]
    public class FileManagerTests
    {
        [TestInitialize]
        [TestMethod()]
        public void CreateFileTest_FileCreationAssertion()
        {
            var filePath = "2023-11-06-13-32-24";
            var fileContent = string.Empty;
            var fileData = new MockFileData(fileContent);

            var fileSystemMock = new MockFileSystem();

            var file = new MockFile(fileSystemMock);

            var inFilePath = Path.Combine("in_dir", filePath);
            fileSystemMock.AddDirectory("in_dir");
            fileSystemMock.AddFile(inFilePath, fileData);

            Assert.IsTrue(fileSystemMock.FileExists(inFilePath));
        }

        [TestMethod()]
        public void WriteFileTest_WritesCorrectData()
        {
            var filePath = "2023-11-06-13-32-24";
            var fileContent = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz";
            var fileData = new MockFileData(fileContent);

            var fileSystemMock = new MockFileSystem();

            var file = new MockFile(fileSystemMock);

            var inFilePath = Path.Combine("in_dir", filePath);
            fileSystemMock.AddDirectory("in_dir");
            fileSystemMock.AddFile(inFilePath, fileData);

            var contentRead = string.Empty;
            using (var streamReader = fileSystemMock.File.OpenText(inFilePath))
            {
                contentRead = streamReader.ReadToEnd();
            }

            Assert.IsTrue(contentRead.Equals(fileContent));
        }
    }
}