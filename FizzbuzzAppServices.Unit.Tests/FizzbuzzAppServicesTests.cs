using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzbuzzAppServices.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using FizzbuzzAppServices.Contracts;
using Moq;
using Domain.Entities;
using Infrastructure.FizzbuzzRepository.Contracts;
using CrossCutting.Configuration;

namespace FizzbuzzAppServices.Implementations.Unit.Tests
{
    [TestClass()]
    public class FizzbuzzAppServicesTests
    {
        [TestMethod()]
        public void GetFizzbuzzTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var fizzbuzzServicesInput = "1";
                var maxNumber = 10;
                var expectedFizzbuzz = new FizzbuzzList()
                {
                    Number = maxNumber,
                    StringList = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" }
                };

                mock.Mock<IFizzbuzzRepository>()
                    .Setup(fizzbuzzRepository => fizzbuzzRepository.SaveFizzbuzzList(expectedFizzbuzz))
                    .Returns(expectedFizzbuzz.StringList);

                mock.Mock<IConfiguration>()
                    .Setup(configuration => configuration.MaxNumber)
                    .Returns(maxNumber);

                var fizzbuzzAppService = mock.Create<FizzbuzzAppServices>();

                var result = fizzbuzzAppService.GetFizzbuzz(fizzbuzzServicesInput);

                mock.Mock<IConfiguration>()
                    .Verify(configuration => configuration.MaxNumber, Times.Exactly(1));

                /*mock.Mock<IFizzbuzzRepository>()
                    .Verify(fizzbuzzRepository => fizzbuzzRepository.SaveFizzbuzzList(expectedFizzbuzz), Times.Exactly(1));*/

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

                //Assert.IsTrue(result.Equals(expectedFizzbuzz.StringList));
            }
        }

        [TestMethod()]
        public void ParseNumberTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var fizzbuzzServicesInput = "1";
                var maxNumber = 10;
                var expectedFizzbuzz = new FizzbuzzList()
                {
                    Number = maxNumber,
                    StringList = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" }
                };

                var fizzbuzzAppService = mock.Create<FizzbuzzAppServices>();

                var result = fizzbuzzAppService.ParseNumber(fizzbuzzServicesInput);

                Assert.IsTrue(result == 1);
            }
        }
    }
}