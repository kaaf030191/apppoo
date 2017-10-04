
namespace apppoo.Singleton
{
    public class Practicante
    {
        private static Practicante P;
        public Practicante()
        {

        }
        public static Practicante GetInstance
        {
            get
            {
                if (P==null)
                {
                    P = new Practicante(); 
                }

                return P;
            }
        }
        public string Saludar(string nombre)
        {
            return "hola " + nombre;
        }

    }
}
