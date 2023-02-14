using DinoAPI.Datas;
using DinoAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DinoAPI.Repositories
{
    public class DinoRepository : IRepository<Dinosaur>
    {
        private readonly ApplicationDbContext _dbContext;

        public DinoRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<bool> Add(Dinosaur entity)
        {
            var addedObj = _dbContext.Dinosaurs.Add(entity);
            await _dbContext.SaveChangesAsync();
            return addedObj.Entity.Id >0;
        }

        public async Task<bool> Delete(int id)
        {
            var dino = await GetById(id);
            if (dino == null)
                return false;
            _dbContext.Dinosaurs.Remove(dino);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<Dinosaur?> Get(Expression<Func<Dinosaur, bool>> predicate)
        {
            return await _dbContext.Dinosaurs.FirstOrDefaultAsync(predicate);
        }
        public async Task<IEnumerable<Dinosaur>> GetAll(Expression<Func<Dinosaur, bool>> predicate)
        {
            return await _dbContext.Dinosaurs.Where(predicate).ToListAsync();
        }
        public async Task<IEnumerable<Dinosaur>> GetAll()
        {
            return await _dbContext.Dinosaurs.ToListAsync();
        }

        public async Task<Dinosaur?> GetById(int id)
        {
            return await _dbContext.Dinosaurs.FindAsync(id);
        }

        public async Task<bool> Update(Dinosaur entity)
        {
            var dinoFromDb = await _dbContext.Dinosaurs.FindAsync(entity.Id);

            if (dinoFromDb == null) return false;

            if (dinoFromDb.Name != entity.Name)
                dinoFromDb.Name = entity.Name;
            if (dinoFromDb.Species != entity.Species)
                dinoFromDb.Species = entity.Species;
            if (dinoFromDb.Age != entity.Age)
                dinoFromDb.Age = entity.Age;
            if (dinoFromDb.Color != entity.Color)
                dinoFromDb.Color = entity.Color;

            if (await _dbContext.SaveChangesAsync() == 0) return false;

            return true;
        }
    }
}
