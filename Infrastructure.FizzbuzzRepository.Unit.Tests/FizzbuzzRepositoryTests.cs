using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.FizzbuzzRepository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using Infrastructure.FizzbuzzRepository.Contracts;
using CrossCutting.Configuration;
using Domain.Entities;
using Moq;

namespace Infrastructure.FizzbuzzRepository.Implementations.Unit.Tests
{
    [TestClass()]
    public class FizzbuzzRepositoryTests
    {
        [TestMethod()]
        public void SaveFizzbuzzListTest_InvokesRequiredMethods()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var filePath = "2023-11-06-13-32-24";
                var maxNumber = 10;
                var expectedFizzbuzz = new FizzbuzzList()
                {
                    Number = maxNumber,
                    StringList = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" }
                };

                mock.Mock<IConfiguration>()
                    .Setup(configuration => configuration.FilePath)
                    .Returns(filePath);

                mock.Mock<IFileManager>()
                    .Setup(fileManager => fileManager.CreateFile(filePath))
                    .Returns(1);

                mock.Mock<IFileManager>()
                    .Setup(fileManager => fileManager.WriteFile(filePath, It.IsAny<List<string>>()))
                    .Returns(1);

                var fizzbuzzAppService = mock.Create<FizzbuzzRepository>();

                var result = fizzbuzzAppService.SaveFizzbuzzList(expectedFizzbuzz);

                mock.Mock<IConfiguration>()
                    .Verify(configuration => configuration.FilePath, Times.Exactly(1));

                mock.Mock<IFileManager>()
                    .Verify(fileManager => fileManager.CreateFile(filePath), Times.Exactly(1));

                mock.Mock<IFileManager>()
                    .Verify(fileManager => fileManager.WriteFile(filePath, expectedFizzbuzz.StringList), Times.Exactly(1));
            }
        }
    }
}