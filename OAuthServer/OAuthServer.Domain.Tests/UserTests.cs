using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OAuthServer.Domain.Tests
{
    [TestClass]
    public class Dado_um_novo_usuario
    {
        private string invalidUsername = "&*¨%@#$::nada";
        private string invalidPassword = "sim";
        private string validUsername = "my-us3r_n4m3";
        private string validPassword = "myp4ssw0rd";

        [TestMethod]
        [TestCategory("User - Novo")]
        [ExpectedException(typeof(InvalidCastException))]
        public void O_username_deve_ser_valido()
        {
            var user = new User(invalidUsername, validPassword);
        }

        [TestMethod]
        [TestCategory("User - Novo")]
        [ExpectedException(typeof(InvalidCastException))]
        public void A_senha_deve_ser_valida()
        {
            var user = new User(validUsername, invalidPassword);
        }

        [TestMethod]
        [TestCategory("User - Novo")]
        public void O_usuario_pode_ser_criado()
        {
            var user = new User(validUsername, validPassword);
        }
    }
}
