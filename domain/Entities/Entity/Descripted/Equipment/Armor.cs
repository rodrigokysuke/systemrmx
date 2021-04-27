namespace domain.Entities
{
    public class Armor : Equipment
    {
        public int PenaltyValue { get; set; }
        public string PenaltyDescription { get; set; }

        public int BonusValue { get; set; }
        public string BonusDescription { get; set; }
    }
}