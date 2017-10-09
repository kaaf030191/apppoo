namespace apppoo.SingleTon
{
    public class SingleTon
    {
        private static SingleTon p;

        
        public SingleTon()
        {

        }

        public static SingleTon getInstance
        {
            get 
            {
                if ( p == null )
                    p = new SingleTon();
                return p;
            }
        }

        public string saludar(string nombre)
        {
            return "hola " + nombre;
        }
    }
}