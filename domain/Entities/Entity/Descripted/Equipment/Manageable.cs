namespace domain.Entities
{
    public abstract class Manageable : Equipment
    {
        public int DifficultyValue { get; set; }
        public string DifficultyDescription { get; set; }
    }
}
