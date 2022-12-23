using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using SES.Core.Domain.Aggregates.CommonAgg.Repositories;
using System.Linq.Expressions;

namespace SES.Core.Infra.Data.Repositories
{
    public abstract class MongoRepository<T> : IDisposable, IMongoRepository<T>
        where T : class
    {
        protected IMongoCollection<T> Collection { get; }
        protected const string _collectionName = $"tb_{nameof(T)}";
        public MongoRepository()
        {

        }
        public async Task RenameCollection(string newName, string oldName = _collectionName)
        {
            await Collection.Database.RenameCollectionAsync(_collectionName, newName);
        }
        public async Task DropCollection(string collectionName)
        {
            await Collection.Database.DropCollectionAsync(collectionName);
        }

        public async Task Duoplicate(string newName)
        {
            var aggDoc = new Dictionary<string, object>
            {
                {"aggregate" , _collectionName},
                {"pipeline", new []
                    {
                        new Dictionary<string, object> { { "$match" , new BsonDocument() }},
                        new Dictionary<string, object> { { "$out" , newName } }
                    }
                }
            };

            var doc = new BsonDocument(aggDoc);
            var command = new BsonDocumentCommand<BsonDocument>(doc);
            Collection.Database.RunCommand(command);
        }

        public MongoRepository(IConfiguration configuration)
        {
            var settings = MongoClientSettings.FromConnectionString(configuration["ConnectionStrings:MongoDB:Uri"]);
            var _client = new MongoClient(settings);
            var _database = _client.GetDatabase(configuration["ConnectionStrings:MongoDB:DatabaseName"]);
            Collection = _database.GetCollection<T>(_collectionName);
            MapClass();
        }

        public async Task InsertAsync(T entity)
        {
            SetAudit(entity, DatabaseOperationEnum.Insert);

            await Collection.InsertOneAsync(entity);
        }

        public async Task InsertRangeAsync(IEnumerable<T> entities)
        {
            var inserts = new List<WriteModel<T>>();
            foreach (var entity in entities)
            {
                SetAudit(entity, DatabaseOperationEnum.Insert);
                inserts.Add(new InsertOneModel<T>(entity));
            }

            await Collection.BulkWriteAsync(inserts, new BulkWriteOptions() { IsOrdered = false });
        }


        public async Task ClearDatabase()
        {
            await Collection.DeleteManyAsync(x => true);
        }

        public async Task UpdateAsync(T entity)
        {
            SetAudit(entity, DatabaseOperationEnum.Update);
            var filter = Builders<T>.Filter.Eq("Id", "Id");

            await Collection.ReplaceOneAsync(filter, entity);
        }

        public async Task UpdateRangeAsync(List<T> entities)
        {
            var updates = new List<WriteModel<T>>();
            foreach (var entity in entities)
            {
                var filter = Builders<T>.Filter.Eq("Id", "Id");
                SetAudit(entity, DatabaseOperationEnum.Update);
                updates.Add(new ReplaceOneModel<T>(filter, entity));
            }

            await Collection.BulkWriteAsync(updates, new BulkWriteOptions() { IsOrdered = false });
        }

        public async Task UpdateLogRangeAsync(List<T> entities)
        {
            var updates = new List<WriteModel<T>>();
            foreach (var entity in entities)
            {
                var filter = Builders<T>.Filter.Eq("Id", "Id");
                updates.Add(new ReplaceOneModel<T>(filter, entity));
            }

            await Collection.BulkWriteAsync(updates, new BulkWriteOptions() { IsOrdered = false });
        }

        public async Task DeleteAsync(T entity)
        {
            SetAudit(entity, DatabaseOperationEnum.Delete);
            var filter = Builders<T>.Filter.Eq("Id", "Id");

            await Collection.ReplaceOneAsync(filter, entity);
        }

        public async Task DeleteRangeAsync(List<T> entities)
        {
            var deletes = new List<WriteModel<T>>();
            foreach (var entity in entities)
            {
                var filter = Builders<T>.Filter.Eq("Id", "Id");
                SetAudit(entity, DatabaseOperationEnum.Delete);
                deletes.Add(new ReplaceOneModel<T>(filter, entity));
            }

            await Collection.BulkWriteAsync(deletes, new BulkWriteOptions() { IsOrdered = false });
        }

        public async Task<List<T>> GetAllAsync()
            => await Collection.Find(x => true).ToListAsync();
        public async Task<long> CountAsync()
            => await Collection.CountDocumentsAsync(x => true);

        public async Task<T> FindAsync(Expression<Func<T, bool>> query)
            => await Collection.Find(query).FirstOrDefaultAsync();

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
            => await Collection.Find(filter).ToListAsync();

        public async Task DeleteManyWithAuditAsync(Expression<Func<T, bool>> expression)
        {
            var entities = await Collection.Find(expression).ToListAsync();

            foreach (var entity in entities)
            {
                SetAudit(entity, DatabaseOperationEnum.Delete);
                var filter = Builders<T>.Filter.Eq("Id", "Id");
                await Collection.ReplaceOneAsync(filter, entity);
            }
        }

        private void SetAudit(T entity, DatabaseOperationEnum operation)
        {
            if (!typeof(T).IsSubclassOf(typeof(Entity))) return;

            var utcNowAuditDate = DateTime.UtcNow;

            switch (operation)
            {
                case DatabaseOperationEnum.Insert:
                    entity.GetType().GetProperty(nameof(Entity.CreatedAt))?.SetValue(entity, utcNowAuditDate, null);
                    break;
                case DatabaseOperationEnum.Update:
                    entity.GetType().GetProperty(nameof(Entity.UpdatedAt))?.SetValue(entity, utcNowAuditDate, null);
                    break;
                case DatabaseOperationEnum.Delete:
                    entity.GetType().GetProperty(nameof(Entity.DeletedAt))?.SetValue(entity, utcNowAuditDate, null);
                    break;
                default:
                    break;
            }
        }

        private void MapClass()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(Entity)))
            {
                BsonClassMap.RegisterClassMap<Entity>(cm =>
                {
                    cm.AutoMap();
                    cm.SetIgnoreExtraElements(true);
                });
            }
        }

        public void Dispose()
        {
        }
    }

    public enum DatabaseOperationEnum
    {
        Insert = 1,
        Update = 2,
        Delete = 3
    }
}
