using PersonasApi.Models;

namespace PersonasApi.Interfaces
{
    public interface IPersonaService
    {
        Task<List<Persona>> GetAll();
        Task<Persona?> GetById(int id);
        Task<Persona> Create(Persona persona);
        Task<bool> Update(int id, Persona persona);
        Task<bool> Delete(int id);
        Task<List<Persona>> Search(string texto);
    }
}