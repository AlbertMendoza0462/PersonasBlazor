using PersonasBlazor.DAL;
using PersonasBlazor.Models;

namespace PersonasBlazor.BLL
{
    public class PersonasBLL
    {
        private Contexto _contexto { get; set; }

        public PersonasBLL(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public bool Save(Personas persona)
        {
            return (!Existe(persona.PersonaID)) ? Insert(persona) : Update(persona);
        }

        public bool Existe(int PersonaID)
        {
            return _contexto.personas.Any(per => per.PersonaID == PersonaID);
        }

        public bool Insert(Personas persona)
        {
            _contexto.personas.Add(persona);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public bool Update(Personas persona)
        {
            _contexto.Entry(persona).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public Personas Find(int personaID)
        {
            return _contexto.personas.Find(personaID);
        }

        public bool Delete(Personas persona)
        {
            _contexto.Entry(persona).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public List<Personas> GetPersonas()
        {
            return _contexto.personas.ToList();
        }
    }
}
