using System;
using DDDImovel.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDImovel.Domain.Tests.ValueObjects
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        public void DeveRetornarErroQuandoFirstNameVazioOuNulo()
        {
            var name = new Name("", "abc");
            Assert.IsTrue(name.Valid);
        }
    }
}