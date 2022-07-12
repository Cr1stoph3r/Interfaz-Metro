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
    public class ActividadEmpresaTests
    {
        [TestMethod()]
        public void ReadTestValido()
        {
            ActividadEmpresa val = new ActividadEmpresa();
            val.IdActividadEmpresa = 4;
            bool result = val.Read();
            Assert.AreEqual(true, result);
            if (result!= true)
                Assert.Fail("La prueba falla");
        }
    }
}