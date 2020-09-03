using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Talk.Domain.Context.ValueObjects;

namespace Talk.UnitTests.ValueObjectTests
{
    public class EmailVoTests
    {
        private EmailVo _emailValido;
        private EmailVo _emailInvalido;

        [SetUp]
        public void Setup()
        {
            _emailValido = new EmailVo("jefferson.almeida@konia.com.br");
            _emailInvalido = new EmailVo("jefferson.almeida.konia");
        }

        [Test]
        public void EmailVoTests_IsValid_ReturnTrue()
        {
            Assert.AreEqual(true, _emailValido.Valid);
        }

        [Test]
        public void EmailVoTests_IsInvalid_ReturnTrue()
        {
            Assert.AreEqual(false, _emailInvalido.Valid);
        }
    }
}
