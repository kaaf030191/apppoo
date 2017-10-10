namespace DAL
{
    public class Persona
    {
        public string dni;
        public string nombre;
        public string apellidos;
        public string edad;
        
        public Persona(string _dni, string _nombre, string _apellidos, string _edad)
        {
            dni = _dni;
            nombre = _nombre;
            apellidos = _apellidos;
            edad = _edad;
        }

    }
}
