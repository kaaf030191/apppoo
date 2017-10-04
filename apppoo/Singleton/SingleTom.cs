namespace apppoo.Singleton
{
    public class SingleTom
    {
        private static SingleTom s;
        public SingleTom(){}

        public static SingleTom getInstance
        {
            get{
                if(s==null)
                {
                    s=new SingleTom();
                }
                return s;
            }
        }
        public string saludar(string nombre)
        {
            return "hola"+nombre;

        }
       
    }
}
