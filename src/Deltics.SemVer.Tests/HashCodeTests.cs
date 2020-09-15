using System;
using Xunit;


namespace Deltics.SemVer.Tests
{
    public partial class HashCodeTests
    {
        [Theory]
        [InlineData("0.0.1", "0.0.2")]
        [InlineData("0.1.0", "0.2.0")]
        [InlineData("1.0.0", "2.0.0")]
        [InlineData("1.0.0", "1.0.1")]
        [InlineData("1.0.0", "1.1.0")]
        [InlineData("1.0.0", "1.1.1")]
        [InlineData("1.0.0", "1.0.0-alpha")]
        [InlineData("1.0.0-alpha", "1.0.0-beta")]
        public void DifferentVersionsHaveDifferentHashCodes(string versionA, string versionB)
        {
            var a = SemanticVersion.Parse(versionA);
            var b = SemanticVersion.Parse(versionB);

            Assert.NotEqual(a.GetHashCode(), b.GetHashCode());
        }
    }
}