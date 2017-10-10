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

            List<Persona> lista = new List<Persona>(new Persona[] {
                    new Persona("Robert", "Huaman Caceres", "11111111", 20),
                    new Persona("Juan", "Carrales Lopinta", "22222222", 20),
                    new Persona("Karlos", "Rios Reyna", "33333333", 20)
                });
            moq.Setup(x => x.getByEdad("20")).Returns(lista);

            List<Persona> resultado = moq.Object.getByEdad("20");


            Assert.That(resultado, Is.EquivalentTo(new List<Persona>(new Persona[] {
                    new Persona("Robert", "Huaman Caceres", "11111111", 20),
                    new Persona("Juan", "Carrales Lopinta", "22222222", 20),
                    new Persona("Karlos", "Rios Reyna", "33333333", 20)
                })));
        }
        [TearDown]
        public void Finish()
        {
            operacion = null;
        }
    }
}
