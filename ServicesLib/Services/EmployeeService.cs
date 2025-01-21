using EntitiesLib.Entities;
using ServicesLib.Config;
using ServicesLib.Interfaces;
using HelpersLib;
using ValidatorLib;

namespace ServicesLib.Services
{
    public class EmployeeService : Service<EmployeeService, Employee>, IValidate<Employee>
    {
        public bool Validate(Employee employee)
        {
            bool result = true;
            if (!BaseValidator.LengthValidator(employee.FirstName, ParamsConfig.MIN_LENGTH_NAME, ParamsConfig.MAX_LENGTH_NAME)) result = false;
            if (!BaseValidator.LengthValidator(employee.LastName, ParamsConfig.MIN_LENGTH_NAME, ParamsConfig.MAX_LENGTH_NAME)) result = false;
            return result;
        }

        private readonly AppDbContext _context;

        public EmployeeService()
        {
            _context = new AppDbContext();
        }

        public override Employee? Create(Employee entity)
        {
            bool isValid = Instance().Validate(entity);
            if (!isValid) return null;

            entity.Password = PasswordHelper.Hash(entity.Password);

            _context.Add(entity);
            return entity;
        }

    }
}
