using NUnit.Framework;

namespace AppCalculadora
{
    [testFixture]

    [SetTUp]//inicialza primero 
    public void Int(){
     operacion=new operacion();
}
    public class OperaciontTest
    {      [testCase]
        punlic void SumaSieteYTres(){
        
            Operacion  operacion =new Operacion();
            float resultad =operacion.Sumar(7,4);
            Assert.That(resultad, is.)
        }
      
        [TearDown]
        public void Finis[]

       
    } 
}
