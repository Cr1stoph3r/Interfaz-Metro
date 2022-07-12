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
    public class TipoEmpresaTests
    {
        [TestMethod()]
        public void ReadTestValido()
        {
            TipoEmpresa tip = new TipoEmpresa();
            tip.IdTipoEmpresa = 30;
            bool result = tip.Read();
            Assert.AreEqual(true, result);
            if (result != true)
                Assert.Fail("La prueba falla");
        }
    }
}