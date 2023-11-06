using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fizzbuzz.DistributedServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using Domain.Entities;
using Moq;
using FizzbuzzAppServices.Contracts;
using FizzbuzzAppServices.Implementations;

namespace Fizzbuzz.DistributedServices.Unit.Tests
{
    [TestClass()]
    public class FizzbuzzTests
    {
        [TestInitialize]
        [TestMethod()]
        public void GetFizzbuzzTest_ReturnsStringList()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var userInput = "1";
                var expectedFizzbuzz = new FizzbuzzList()
                {
                    Number = 10,
                    StringList = new List<string>() { "1, 2, fizz, 4, 5, fizz, 7, 8, fizz, 10" }
                };

                mock.Mock<IFizzbuzzAppServices>()
                    .Setup(fizzbuzzAppService => fizzbuzzAppService.GetFizzbuzz(userInput))
                    .Returns(expectedFizzbuzz.StringList);

                var fizzbuzzService = mock.Create<Fizzbuzz>();

                var result = fizzbuzzService.GetFizzbuzz(userInput);

                mock.Mock<IFizzbuzzAppServices>()
                    .Verify(fizzbuzzAppService => fizzbuzzAppService.GetFizzbuzz(userInput), Times.Exactly(1));

                Assert.IsTrue(result.Equals(expectedFizzbuzz.StringList));
            }
        }
    }
}