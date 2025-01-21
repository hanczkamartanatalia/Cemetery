using EntitiesLib.Entities;
using EntitiesLib.Interfaces;
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

        public virtual G? Create(G entity)
        {
            bool isValid = Instance().Validate(entity);
            if (!isValid) return null;

            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual G? Edit(G edited)
        {
            G? fromDb = _context.Set<G>().FirstOrDefault(x => x.Id == edited.Id);
            if (fromDb == null) return null;

            bool isValid = Instance().Validate(edited);
            if (!isValid) return null;

            _context.Entry(fromDb).CurrentValues.SetValues(edited);

            _context.SaveChanges();

            return fromDb;
        }


        public virtual G? Delete(G edited)
        {
            G? fromDb = _context.Set<G>().FirstOrDefault(x => x.Id == edited.Id);
            if (fromDb == null) return null;
            if (fromDb.IsDeleted) return null;
            fromDb.IsDeleted = true;
            _context.SaveChanges();
            return fromDb;
        }


        public virtual List<G> List()
        {
            return _context.Set<G>()
                           .ToList();
        }

    }
}
