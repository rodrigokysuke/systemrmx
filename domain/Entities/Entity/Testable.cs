namespace domain.Entities
{
    public abstract class Testable : Entity
    {
        public int? TestValue { get; set; }
        public int? TestValueEfficiencyLimit { get; set; }
    }
}
