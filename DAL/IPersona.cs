using System.Collections.Generic;
namespace DAL
{
    public interface IPersona
    {
        List<Persona> getByEdad(string edad); 
    }
}
