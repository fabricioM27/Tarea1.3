using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1._3.Models;

namespace Tarea1._3.Controller
{
    public class DataBaseSQLite
    {
        readonly SQLiteAsyncConnection db;

        // Constructor de la clase DataBaseSQLite
       
        public DataBaseSQLite(String pathdb)
        {

            // Crear una conexion a la base de datos
            db = new SQLiteAsyncConnection(pathdb);

            // Creacion de la tabla personas dentro de SQLite
            db.CreateTableAsync<Personas>().Wait();
        }

        // Operaciones CRUD con SQLite
        // READ List Way

        public Task<List<Personas>> ObtenerListaPersonas()
        {
            return db.Table<Personas>().ToListAsync();
        }

        //READ one by one
        public Task<Personas> ObtenerPersona(int pcodigo)
        {
            return db.Table<Personas>()
                .Where(i => i.id == pcodigo)
                .FirstOrDefaultAsync();
        }


        // CREATE persona
        public Task<int> GrabarPersonas(Personas personas)
        {
            if (personas.id != 0)
            {
                return db.UpdateAsync(personas);
            }
            else
            {
                return db.InsertAsync(personas);
            }
        }

        //DELETE

        public Task<int> EliminarPersonas(Personas personas)
        {
            return db.DeleteAsync(personas);
        }

    
}


}
