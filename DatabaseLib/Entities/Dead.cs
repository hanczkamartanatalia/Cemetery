using EntitiesLib.Interfaces;
namespace EntitiesLib.Entities
{
    public class Dead : Entity, IPersonality
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime DateTimeDeath { get; set; }
    }
}
