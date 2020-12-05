using BienvenidosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BienvenidosWebAPI.Data
{
    public interface IBienvenidosAPIRepo
    {
        bool SaveChanges();

        // Centros
        IEnumerable<Centro> TraerTodosCentros();
        Centro TraerCentro(int id);
        void CrearCentro(Centro c);
        void ModificarCentro(Centro c);
        void EliminarCentro(Centro c);

        // Países
        void CrearPais(Pais p);
        IEnumerable<Pais> TraerTodosPaises();
        Pais TraerPais(int id);


        // Provincias
        void CrearProvincia(Provincia p);
        IEnumerable<Provincia> TraerTodasProvincias();
        IEnumerable<Provincia> TraerProvinciaIdPais(int id);
        Provincia TraerProvincia(int id);


        // Ciudades
        void CrearCiudad(Ciudad c);
    }
}
