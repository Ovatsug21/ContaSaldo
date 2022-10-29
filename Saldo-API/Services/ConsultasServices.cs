using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Saldo_API.Models;

namespace Saldo_API.Services
{
    public class ConsultasServices
    {
        private readonly IMongoCollection<Consulta> _saldoCollection;

        public ConsultasServices(IOptions<ConsultaDbSettings> consultasServices)
        {
            var mongoClient = new MongoClient(consultasServices.Value.ConnectionString);
            var mongoDataBase = mongoClient.GetDatabase(consultasServices.Value.DataBase);

            _saldoCollection = mongoDataBase.GetCollection<Consulta>(consultasServices.Value.CollectionName);
        }

        public async Task<List<Consulta>> GetAsync( int id) =>
            await _saldoCollection.Find(x => x.IdUsuario == id).ToListAsync();
    }
}
