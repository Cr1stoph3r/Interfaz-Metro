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
    public class ModalidadServicioTests
    {
        [TestMethod()]
        public void ReadTestValido()
        {
            ModalidadServicio mod = new ModalidadServicio();
            mod.IdModalidad = "CB001";
            bool result = mod.Read();
            Assert.AreEqual(true, result);
            if (result != true)
                Assert.Fail("La prueba falla");
        }
    }
}