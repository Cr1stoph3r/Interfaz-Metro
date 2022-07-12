using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Tests
{
    [TestClass()]
    public class ContratoTests
    {
        [TestMethod()]
        public void CreateTestValido()
        {
            Contrato con = new Contrato();
            con.Numero = "432";
            bool result = con.Read();
            Assert.AreEqual(true, result);
            if (result != true)
                Assert.Fail("La prueba falla");
        }
    }
}