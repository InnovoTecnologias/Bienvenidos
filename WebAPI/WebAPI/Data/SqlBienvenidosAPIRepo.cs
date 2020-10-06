using BienvenidosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BienvenidosWebAPI.Data
{
    public class SqlBienvenidosAPIRepo : IBienvenidosAPIRepo
    {
        private readonly bienvenidosContext db;

        public SqlBienvenidosAPIRepo(bienvenidosContext dbContext)
        {
            db = dbContext;
        }

        public void CrearCentro(Centro c)
        {
            if (c == null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            db.Centro.Add(c);
        }

        public void CrearCiudad(Ciudad c)
        {
            throw new NotImplementedException();
        }

        public void CrearPais(Pais p)
        {
            throw new NotImplementedException();
        }

        public void CrearProvincia(Provincia p)
        {
            throw new NotImplementedException();
        }

        public void EliminarCentro(Centro c)
        {
            if (c == null)
            {
                throw new ArgumentNullException(nameof(c));
            }
            db.Centro.Remove(c);
        }

        public void ModificarCentro(Centro c)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (db.SaveChanges() >= 0);
        }

        public Centro TraerCentro(int id)
        {
            return db.Centro.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Centro> TraerTodosCentros()
        {
            return db.Centro.ToList();
        }
    }
}
