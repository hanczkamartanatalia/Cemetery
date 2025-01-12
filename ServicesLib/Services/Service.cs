using EntitiesLib.Entities;
using ServicesLib.Config;
using ServicesLib.Interfaces;

namespace ServicesLib.Services
{
    public abstract class Service<T, G>
        where T : Service<T, G>, IValidate<G>, new()
        where G : Entity
    {
        private readonly AppDbContext _context;

        public Service()
        {
            _context = new AppDbContext();
        }

        public static T Instance()
        {
            return new T();
        }

        public G? Create(G entity)
        {
            bool isValid = Instance().Validate(entity);
            if (!isValid) return null;

            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public G? Edit(G edited)
        {
            G? fromDb = _context.Set<G>().First(x => x.Id == edited.Id);
            if (fromDb == null) return null;
            
            bool isValid = Instance().Validate(edited);
            if (!isValid) return null;

            _context.Update(edited);
            _context.SaveChanges();
            return edited;
        }

        public G? Delete(G edited)
        {
            G? fromDb = _context.Set<G>().First(x => x.Id == edited.Id);
            if (fromDb == null) return null;

            if (edited.IsDeleted) return null;
            
            edited.IsDeleted = true;
            _context.Update(edited);
            _context.SaveChanges();
            return edited;
        }
    }
}
