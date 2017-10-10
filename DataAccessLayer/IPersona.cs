using System.Collections.Generic;
namespace DataAccessLayer
{
    public interface IPersona
    {
        List<Persona> getByEdad(string edad);
    }
}
