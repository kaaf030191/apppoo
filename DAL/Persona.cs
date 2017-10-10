namespace DAL
{
    public class Persona
    {
        string dni;
        string nombre;
        string apellidos;
        string edad;
        
        public Persona(string _dni, string _nombre, string _apellidos, string _edad)
        {
            dni = _dni;
            nombre = _nombre;
            apellidos = _apellidos;
            edad = _edad;
        }

    }
}
