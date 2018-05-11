using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace RestfulApi.Common.Logging.UnitTest
{
    public class LoggingBuilderExtensionsUnitTest
    {
        [Test]
        public void GetProviderByConfiguationSection_Provider_NotExist()
        {
            var providerType = GetProviderType(TestContext.CurrentContext.TestDirectory, "null.appsettings.json");

            Assert.IsNotNull(providerType);

            Assert.That(providerType, Is.EqualTo(ProviderType.Unknown));
        }

        [Test]
        public void GetProviderByConfiguationSection_Provider_IsEmpty()
        {
            var providerType = GetProviderType(TestContext.CurrentContext.TestDirectory, "empty.appsettings.json");

            Assert.IsNotNull(providerType);

            Assert.That(providerType, Is.EqualTo(ProviderType.Unknown));
        }

        [Test]
        public void GetProviderByConfiguationSection_Provider_Value_IsEmpty()
        {
            var providerType = GetProviderType(TestContext.CurrentContext.TestDirectory, "emptyValue.appsettings.json");

            Assert.IsNotNull(providerType);

            Assert.That(providerType, Is.EqualTo(ProviderType.Default));
        }

        [Test]
        public void GetProviderByConfiguationSection_Provider_Value_Incorrect()
        {
            var providerType = GetProviderType(TestContext.CurrentContext.TestDirectory, "incorrectValue.appsettings.json");

            Assert.That(providerType, Is.EqualTo(ProviderType.Default));
        }

        [Test]
        public void GetProviderByConfiguationSection_Success()
        {
            var providerType = GetProviderType(TestContext.CurrentContext.TestDirectory, "appsettings.json");

            Assert.That(providerType, Is.EqualTo(ProviderType.Default));
        }

        private ProviderType GetProviderType(string outputPath, string jsonFile)
        {
            var configurationSection = GetRootConfiguration(outputPath, jsonFile).GetSection("LoggingProvider");

            return LoggingBuilderExtensions.GetProvider(configurationSection);
        }

        private IConfigurationRoot GetRootConfiguration(string outputPath, string jsonFile)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile(jsonFile, optional: true)
                .Build();
        }
    }
}
