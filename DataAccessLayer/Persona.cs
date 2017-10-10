namespace DataAccessLayer
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public string dni;
        public int edad;

        public Persona(string _nombre, string _apellido, string _dni, int _edad)
        {
            nombre = _nombre;
            apellido = _apellido;
            dni = _dni;
            edad = _edad;
        }
    }
}
