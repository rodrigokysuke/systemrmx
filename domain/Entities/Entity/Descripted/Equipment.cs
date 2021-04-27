namespace domain.Entities
{
    public abstract class Equipment : Descripted
    {
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}