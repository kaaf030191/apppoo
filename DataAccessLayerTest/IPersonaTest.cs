using DataAccessLayer;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace DataAccessLayerTest
{
    [TestFixture]
    public class IPersonaTest
    {
        IPersona operacion = null;

        [SetUp]
        public void Init()
        {
            operacion = new QPersona();
        }

        [TestCase]
        public void getByEdadVienteRCincoPersonas()
        {
            Mock<IPersona> moq = new Mock<IPersona>();

            moq.Setup(x => x.getByEdad("20")).Returns(new List<Persona>()
            {
                new Persona("Robert", "Huaman Caceres", "11111111", 20),
                new Persona("Juan", "Carrales Lopinta", "22222222", 20),
                new Persona("Karlos", "Rios Reyna", "33333333", 20)
            });

            List<Persona> resultado = moq.Object.getByEdad("20");

            List<Persona> listaPersonaTemp = new List<Persona>()
            {
                new Persona("Robert", "Huaman Caceres", "11111111", 20),
                new Persona("Juan", "Carrales Lopinta", "22222222", 20),
                new Persona("Karlos", "Rios Reyna", "33333333", 20)
            };

            for (int i = 0; i < resultado.Count; i++)
            {
                Assert.IsTrue(resultado[i].nombre.Equals(listaPersonaTemp[i].nombre));
                Assert.IsTrue(resultado[i].apellido.Equals(listaPersonaTemp[i].apellido));
            }
        }

        [TearDown]
        public void Finish()
        {
            operacion = null;
        }
    }
}
