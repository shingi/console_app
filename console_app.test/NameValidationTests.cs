using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using console_app.library;

namespace console_app.test {
    [TestFixture]
    public class NameValidationTests {
        [Test]
        public void should_say_name_is_invalid() {
            var name = "name 123";
            Assert.That(name.Validate(), Is.False);
            name = "123_name";
            Assert.That(name.Validate(), Is.False);
            name = "na123 me";
            Assert.That(name.Validate(), Is.False);
        }

        [Test]
        public void should_say_name_is_valid() {
            var name = "test_name";
            Assert.That(name.Validate(), Is.True);
            name = "test name";
            Assert.That(name.Validate(), Is.True);
        }
    }
}
