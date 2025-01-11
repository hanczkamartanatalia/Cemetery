using EntitiesLib.Entities;

namespace ServicesLib.Interfaces
{
    public interface IValidate<T> where T : class
    {
        public bool Validate(T entity);
    }
}