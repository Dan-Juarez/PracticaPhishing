using ApplicationLayer;
using EnterpriseEntities;
using InterfaceAdapters.Data;
using InterfaceAdapters.Models;
using MongoDB.Driver;

namespace InterfaceAdapters.Repositories
{
    public class LogInRepository : ILogInRepository
    {
        private readonly MongoDbContext _context;

        public LogInRepository(MongoDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(LogIn login)
        {
            var document = new LogInDocument
            {
                Usuario = login.Usuario,
                Contrasena = login.Contrasena
            };

            await _context.LogIns.InsertOneAsync(document);

            // Regresamos el Id generado a la entidad de dominio
            login.Id = document.Id;
        }

        public async Task<IEnumerable<LogIn>> GetAllAsync()
        {
            var documents = await _context.LogIns.Find(_ => true).ToListAsync();

            return documents.Select(d => new LogIn
            {
                Id = d.Id,
                Usuario = d.Usuario,
                Contrasena = d.Contrasena
            });
        }
    }
}
