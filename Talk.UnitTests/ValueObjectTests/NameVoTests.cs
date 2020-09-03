using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Talk.Domain.Context.ValueObjects;

namespace Talk.UnitTests.ValueObjectTests
{
    public class NameVoTests
    {
        private NomeVo _nomeValido;
        private NomeVo _nomeInvalido;
        [SetUp]
        public void Setup()
        {
            _nomeValido = new NomeVo("Jeff", "Almeida");
            _nomeInvalido = new NomeVo("D", "M");
        }

        [Test]
        public void NameVoTests_IsValid_ReturnTrue()
        {
            Assert.AreEqual(true, _nomeValido.Valid);
        }

        [Test]
        public void NameVoTests_IsInvalid_ReturnFalse()
        {
            Assert.AreEqual(false, _nomeInvalido.Valid);
        }
    }
}
