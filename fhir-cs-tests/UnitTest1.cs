using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyProject;

using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace fhir_cs_tests
{
    [TestClass]
    public class FhirHelperTests
    {

        [DataRow("https://something.com/something-that-has-values-1", 1L)]
        [DataRow("https://something.com/something-that-has-values-8", 8L)]
        [DataRow("https://something.com/something-that-has-values-11", 11L)]
        [DataRow("https://something.com/something-that-has-values-412341", 412341L)]
        [DataTestMethod]
        public void When_BaseUrlHasVersion_ReturnVersion(string url, long expected)
        {
            var actual = FhirHelper.GetVersionNumber(url);
            Assert.AreEqual(expected, actual);
        }
    }
}