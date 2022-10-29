using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Transacao_API.Models;

namespace Transacao_API.Services
{
    public class TransacoesServices
    {
        private readonly IMongoCollection<Transacao> _transacaoCollection;

        public TransacoesServices(IOptions<TransacaoDbSettings> transacoesServices)
        {
            var mongoClient = new MongoClient(transacoesServices.Value.ConnectionString);
            var mongoDataBase = mongoClient.GetDatabase(transacoesServices.Value.DataBase);

            _transacaoCollection = mongoDataBase.GetCollection<Transacao>(transacoesServices.Value.CollectionName);
        }

        public async Task CreateAsync(Transacao transacao) =>
            await _transacaoCollection.InsertOneAsync(transacao);
    }
}
