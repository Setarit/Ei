using NUnit.Framework;
using Com.Setarit.Ei.Factory;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework.Constraints;
using Com.Setarit.Ei.Provider.Configuration;
using Com.Setarit.Ei.Exception;

namespace Com.Setarit.EiTests.Factory
{
    [TestFixture]
    class ProviderFactoryTest
    {
        private ProviderFactory factory;

        [SetUp]
        public void SetUp()
        {
            factory = new ProviderFactory();
        }
        
        [Test]
        public void CreateFromThrowsInvalidProviderExceptionIfUnknownProvider()
        {
            //Arrange
            IConfiguration config = new WrongConfiguration{};            

            //Act
            ActualValueDelegate<object> testDelegate = () => factory.CreateFrom(config);

            //Assert
            Assert.That(testDelegate, Throws.TypeOf<InvalidProviderException>());
        }
    }

    class WrongConfiguration : IConfiguration { }
}
