using DAL;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
namespace DALTest
{
    [TestFixture]
    class PersonaTest
    {
        IPersona persona = null;

        [SetUp]
        public void Init()
        {
            persona = new Qpersona();
        }

        [TestCase]
        public void EdadPersonaRVeintetres()
        {
            List<Persona> listaPersona = new List<Persona>( new Persona[] {
                new Persona("12345678","Alice","Alvarez Vargas","23"),
                new Persona("12456755","Angeli","Suares Fernanez","23"),
                new Persona("45566667","Genesis","Gomez chavez","23")

            });

            Mock<IPersona> moq = new Mock<IPersona>();

            moq.Setup(x => x.getByEdad("23")).Returns(listaPersona);


            List<Persona> resultado = moq.Object.getByEdad("23");

           /*
            Assert.That(resultado, Is.EquivalentTo(
                 new List<Persona>( new Persona[] {
                new Persona("12345678","Alice","Alvarez Vargas","23"),
                new Persona("12456755","Angeli","Suares Fernanez","23"),
                new Persona("45566667","Genesis","Gomez chavez","23")
            })));*/

            CollectionAssert.AreEquivalent(resultado, new List<Persona>(new Persona[] {
                new Persona("12345678","Alice","Alvarez Vargas","23"),
                new Persona("12456755","Angeli","Suares Fernanez","23"),
                new Persona("45566667","Genesis","Gomez chavez","23")
                }));
        }

        [TearDown]
        public void Finish()
        {
            persona = null;
        }



    }
}
