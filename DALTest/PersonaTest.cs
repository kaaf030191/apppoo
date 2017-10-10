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

            List<Persona> listaPersonaAuxiliar = new List<Persona>(new Persona[] {
                new Persona("12345678","Alice","Alvarez Vargas","23"),
                new Persona("12456755","Angeli","Suares Fernanez","23"),
                new Persona("45566667","Genesis","Gomez chavez","23")

            });

            for (int i = 0; i < resultado.Count; i++) 
            { 
                Assert.IsTrue(resultado[i].dni.Equals(listaPersonaAuxiliar[i].dni));
                Assert.IsTrue(resultado[i].nombre.Equals(listaPersonaAuxiliar[i].nombre));
                Assert.IsTrue(resultado[i].apellidos.Equals(listaPersonaAuxiliar[i].apellidos));
                Assert.IsTrue(resultado[i].edad.Equals(listaPersonaAuxiliar[i].edad)); 
            }
          
        }

        [TearDown]
        public void Finish()
        {
            persona = null;
        }



    }
}
