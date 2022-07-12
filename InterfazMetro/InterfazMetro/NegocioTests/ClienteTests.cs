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
    public class ClienteTests
    {
        [TestMethod()]
        public void ReadTestValido()
        {
            Cliente clie = new Cliente();
            clie.RutCliente = "20498813-7";
            bool Result = clie.Read();
            Assert.AreEqual(true, Result);
            if (Result != true)
                Assert.Fail("La prueba falla");
        }

        [TestMethod()]
        public void UpdateTestValido()
        {
            Cliente clie = new Cliente();
            clie.RutCliente = "20498813-7";
            clie.Read();
            clie.NombreContacto = "Perro Loko";
            bool result = clie.Update();
            Assert.AreEqual(true, result);

            if (result != true)
                Assert.Fail("La prueba falla");
        }

        [TestMethod()]
        public void DeleteTestValido()
        {
            Cliente clie = new Cliente();
            clie.RutCliente = "12345678-9";
            clie.Read();
            clie.RutCliente = "12345678-9";
            bool result = clie.Delete();
            Assert.AreEqual(true, result);

            if (result != true)
                Assert.Fail("La prueba falla");
        }

        [TestMethod()]
        public void CreateTestValido()
        {
            Cliente clie = new Cliente();
            clie.RutCliente = "12345678-9";
            clie.Read();
            clie.RutCliente = "12345678-9";
            clie.RazonSocial = "gdfsgdsf";
            clie.NombreContacto = "juan";
            clie.MailContacto = "gsdgdsg";
            clie.Direccion = "fdsfdasf";
            clie.Telefono = "35523532532";
            clie.IdActividadEmpresa = 4;
            clie.IdTipoEmpresa = 30;
            bool result = clie.Create();
            Assert.AreEqual(true, result);
            if(result!=true)
                Assert.Fail("La prueba falla");
        }
    }

}