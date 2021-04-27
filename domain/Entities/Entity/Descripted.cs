namespace domain.Entities
{
    public abstract class Descripted : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
