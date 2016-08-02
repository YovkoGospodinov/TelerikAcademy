namespace Cosmetics.Test
{
    using System;
    using Cosmetics.Common;
    using NUnit.Framework;

    [TestFixture]
    public class ValidatorTest
    {
        [Test]
        public void CheckIfNullShouldThrowNullReferenceExceptionIfTheParameterObjIsNull()
        {
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfNull(null));
        }

        [Test]
        public void CheckIfNullShouldNotThrowNullReferenceExceptionIfTheParameterObjIsNotNull()
        {
            Assert.DoesNotThrow(() => Validator.CheckIfNull(String.Empty));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void CheckIfStringIsNullOrEmptyShouldThrowNullReferenceExceptionWhenTheParameterTextIsNullOrEmpty(string text)
        {
            Assert.Throws<NullReferenceException>((() => Validator.CheckIfStringIsNullOrEmpty(text)));
        }

        [Test]
        public void CheckIfStringIsNullOrEmptyShouldNotThrowNullReferenceExceptionWhenTheParameterTextIsNotNullOrEmpty()
        {
            Assert.DoesNotThrow(() => Validator.CheckIfStringIsNullOrEmpty("a"));
        }

        [Test]
        [TestCase("ca", 20, 3)]
        [TestCase("cacacacacacacacacacaca", 20, 3)]
        public void CheckIfStringLengthIsValidShouldThrowIndexOutOfRangeExceptionWhenLengthOfParameterTextIsLowerThanMinimumAllowedValueOrGreaterThanTheMaximumAllowed
            (string text, int max, int min)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Validator.CheckIfStringLengthIsValid(text, max, min));
        }

        [Test]
        [TestCase("cat", 20, 3)]
        [TestCase("turtle", 10, 4)]
        public void CheckIfStringLengthIsValidShouldNotThrowIndexOutOfRangeExceptionWhenLengthOfParameterTextIsValid(string text, int max, int min)
        {
            Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid(text, max, min));
        }
    }
}
