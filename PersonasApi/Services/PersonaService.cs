using Microsoft.EntityFrameworkCore;
using PersonasApi.Data;
using PersonasApi.Interfaces;
using PersonasApi.Models;

namespace PersonasApi.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly AppDbContext _context;

        public PersonaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Persona>> GetAll()
        {
            return await _context.Personas.ToListAsync();
        }

        public async Task<Persona?> GetById(int id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task<Persona> Create(Persona persona)
        {
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task<bool> Update(int id, Persona persona)
        {
            var existente = await _context.Personas.FindAsync(id);
            if (existente == null) return false;

            existente.Nombre = persona.Nombre;
            existente.Apellido = persona.Apellido;
            existente.Email = persona.Email;
            existente.Telefono = persona.Telefono;
            existente.Direccion = persona.Direccion;
            existente.FechaNacimiento = persona.FechaNacimiento;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona == null) return false;

            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Persona>> Search(string texto)
        {
            return await _context.Personas
                .Where(p =>
                    p.Nombre.Contains(texto) ||
                    p.Apellido.Contains(texto) ||
                    p.Email.Contains(texto))
                .ToListAsync();
        }
    }
}
