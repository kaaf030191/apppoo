using apppersona;
using Moq;
using NUnit.Framework;
using repositorio;
using System.Collections.Generic;
using System.Linq;

namespace apppersonatest
{
    
    [TestFixture]
    public class PersonaTest
    {
        //Ipersona<Persona> persona = null;

        [SetUp]
        /* public void Init()
         {
           persona= new Ipersona<Persona>()

         */


        [TestCase]
        public void listaDni()
        {
            Mock<Ipersona<Persona>> moq = new Mock<Ipersona<Persona>>();

            moq.Setup(x => x.GetByEdad().ToList()).Returns(new List<Persona>()
            {
                new Persona() { nombre = "asd", dni="asd" },
                new Persona() { nombre = "asd", dni="asd" },
                new Persona() { nombre="pedro" ,dni="apellido"}
            });

            List<Persona>listPersona= moq.Object.GetByEdad().ToList();

            Assert.That(listPersona, Is.EqualTo(3));
        }

    }
}
