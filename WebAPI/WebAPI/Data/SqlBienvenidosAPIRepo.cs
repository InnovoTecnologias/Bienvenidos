using BienvenidosWebAPI.Models;
using Microsoft.EntityFrameworkCore;
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
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }

            db.Pais.Add(p);
        }

        public void CrearProvincia(Provincia p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }

            db.Provincia.Add(p);
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

        public Pais TraerPais(int id)
        {
            return db.Pais.FirstOrDefault(p => p.Id == id);
        }

        public Provincia TraerProvincia(int id)
        {
            return db.Provincia.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Provincia> TraerTodasProvincias()
        {
            return db.Provincia.ToList();
        }

        public IEnumerable<Centro> TraerTodosCentros()
        {
            return db.Centro.ToList();
        }

        public IEnumerable<Pais> TraerTodosPaises()
        {
            return db.Pais.ToList();
        }
    }
}
